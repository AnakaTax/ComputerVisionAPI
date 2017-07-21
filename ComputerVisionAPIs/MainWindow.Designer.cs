namespace ComputerVisionAPIs
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.pbxFaceAPI = new System.Windows.Forms.PictureBox();
            this.pbxCludVisionAPI = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFaceApiResults = new System.Windows.Forms.Label();
            this.lblCloudVisionApiResults = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFaceAPITime = new System.Windows.Forms.Label();
            this.lblCloudVisionAPITime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFaceAPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCludVisionAPI)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::ComputerVisionAPIs.Properties.Resources.header;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnLoadImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.Location = new System.Drawing.Point(12, 9);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(91, 31);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Load image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // pbxFaceAPI
            // 
            this.pbxFaceAPI.Location = new System.Drawing.Point(12, 46);
            this.pbxFaceAPI.Name = "pbxFaceAPI";
            this.pbxFaceAPI.Size = new System.Drawing.Size(640, 480);
            this.pbxFaceAPI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFaceAPI.TabIndex = 0;
            this.pbxFaceAPI.TabStop = false;
            // 
            // pbxCludVisionAPI
            // 
            this.pbxCludVisionAPI.Location = new System.Drawing.Point(658, 46);
            this.pbxCludVisionAPI.Name = "pbxCludVisionAPI";
            this.pbxCludVisionAPI.Size = new System.Drawing.Size(640, 480);
            this.pbxCludVisionAPI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCludVisionAPI.TabIndex = 1;
            this.pbxCludVisionAPI.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Face API";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cloud Vision API";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFaceAPITime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblFaceApiResults);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(117, 532);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCloudVisionAPITime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblCloudVisionApiResults);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(846, 532);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of faces:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of faces:";
            // 
            // lblFaceApiResults
            // 
            this.lblFaceApiResults.AutoSize = true;
            this.lblFaceApiResults.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceApiResults.ForeColor = System.Drawing.Color.Blue;
            this.lblFaceApiResults.Location = new System.Drawing.Point(147, 26);
            this.lblFaceApiResults.Name = "lblFaceApiResults";
            this.lblFaceApiResults.Size = new System.Drawing.Size(18, 19);
            this.lblFaceApiResults.TabIndex = 1;
            this.lblFaceApiResults.Text = "0";
            // 
            // lblCloudVisionApiResults
            // 
            this.lblCloudVisionApiResults.AutoSize = true;
            this.lblCloudVisionApiResults.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloudVisionApiResults.ForeColor = System.Drawing.Color.Green;
            this.lblCloudVisionApiResults.Location = new System.Drawing.Point(147, 26);
            this.lblCloudVisionApiResults.Name = "lblCloudVisionApiResults";
            this.lblCloudVisionApiResults.Size = new System.Drawing.Size(18, 19);
            this.lblCloudVisionApiResults.TabIndex = 2;
            this.lblCloudVisionApiResults.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Time:";
            // 
            // lblFaceAPITime
            // 
            this.lblFaceAPITime.AutoSize = true;
            this.lblFaceAPITime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceAPITime.ForeColor = System.Drawing.Color.Blue;
            this.lblFaceAPITime.Location = new System.Drawing.Point(63, 62);
            this.lblFaceAPITime.Name = "lblFaceAPITime";
            this.lblFaceAPITime.Size = new System.Drawing.Size(18, 19);
            this.lblFaceAPITime.TabIndex = 3;
            this.lblFaceAPITime.Text = "0";
            // 
            // lblCloudVisionAPITime
            // 
            this.lblCloudVisionAPITime.AutoSize = true;
            this.lblCloudVisionAPITime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloudVisionAPITime.ForeColor = System.Drawing.Color.Green;
            this.lblCloudVisionAPITime.Location = new System.Drawing.Point(63, 62);
            this.lblCloudVisionAPITime.Name = "lblCloudVisionAPITime";
            this.lblCloudVisionAPITime.Size = new System.Drawing.Size(18, 19);
            this.lblCloudVisionAPITime.TabIndex = 4;
            this.lblCloudVisionAPITime.Text = "0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1310, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxCludVisionAPI);
            this.Controls.Add(this.pbxFaceAPI);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFaceAPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCludVisionAPI)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox pbxFaceAPI;
        private System.Windows.Forms.PictureBox pbxCludVisionAPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFaceApiResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCloudVisionApiResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFaceAPITime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCloudVisionAPITime;
        private System.Windows.Forms.Label label6;
    }
}