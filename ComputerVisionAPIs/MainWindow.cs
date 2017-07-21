using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Vision.V1;
using Microsoft.ProjectOxford.Face;

namespace ComputerVisionAPIs
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private const string FaceApiKey = "";
        private const string FaceApiEndPoint = "";

        private string _imageFilePath;

        private Bitmap _originalImage;
        private Bitmap _faceApiImage;
        private Bitmap _cloudVisionApiImage;

        private string _resolution = "1600-1200";

        private async void btnLoadImage_Click(object sender, EventArgs e)
        {
            ClearGUI();
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = @"Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                if (ofd.ShowDialog() != DialogResult.OK) return;
                _imageFilePath = ofd.FileName;
                _originalImage = (Bitmap)System.Drawing.Image.FromFile(_imageFilePath);
   
                _faceApiImage = new Bitmap(_originalImage);
                _cloudVisionApiImage = new Bitmap(_originalImage);
                await CloudVisionApi();
                await FaceApi();
            }
        }

        private async Task CloudVisionApi()
        {
            var client = ImageAnnotatorClient.Create();
            var googleImage = Google.Cloud.Vision.V1.Image.FromFile(_imageFilePath);

            var stopwatch = Stopwatch.StartNew();
            var response = await client.DetectFacesAsync(googleImage);
            stopwatch.Stop();

            lblCloudVisionApiResults.Text = $"{response.Count}";
            lblCloudVisionAPITime.Text = $"{stopwatch.ElapsedMilliseconds} ms";

            using (var g = Graphics.FromImage(_cloudVisionApiImage))
            {
                var cyanPen = new Pen(Color.FromKnownColor(KnownColor.Green), 8);
                foreach (var annotation in response)
                {
                    g.DrawPolygon(cyanPen, annotation.FdBoundingPoly.Vertices.Select((vertex) => new Point(vertex.X, vertex.Y)).ToArray());
                }
            }
            pbxCludVisionAPI.Image = _cloudVisionApiImage;
        }

        private async Task FaceApi()
        {
            var faceServiceClient = new FaceServiceClient(FaceApiKey, FaceApiEndPoint);
            using (var fStream = File.OpenRead(_imageFilePath))
            {
                var stopwatch = Stopwatch.StartNew();
                var faces = await faceServiceClient.DetectAsync(fStream, false);
                stopwatch.Stop();

                lblFaceApiResults.Text = $"{faces.Length}";
                lblFaceAPITime.Text = $"{stopwatch.ElapsedMilliseconds} ms";

                using (var g = Graphics.FromImage(_faceApiImage))
                {
                    var cyanPen = new Pen(Color.FromKnownColor(KnownColor.Blue), 8);
                    foreach (var face in faces)
                    {
                        g.DrawRectangle(cyanPen, face.FaceRectangle.Left, face.FaceRectangle.Top, face.FaceRectangle.Width, face.FaceRectangle.Height);
                    }
                }
            }
            pbxFaceAPI.Image = _faceApiImage;
        }

        private void ClearGUI()
        {
            lblFaceApiResults.Text = string.Empty;
            lblCloudVisionApiResults.Text = string.Empty;
            pbxFaceAPI.Image = null;
            pbxCludVisionAPI.Image = null;          
        }
    }
}
