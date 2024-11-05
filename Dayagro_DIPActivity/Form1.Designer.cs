namespace Dayagro_DIPActivity
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxProcessed;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnApplyGreyscale;
        private System.Windows.Forms.Button btnApplyInversion;
        private System.Windows.Forms.Button btnApplyHistogram;
        private System.Windows.Forms.Button btnApplySepia;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnLoadBackground;
        private System.Windows.Forms.Button btnSubtractImages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Digital Image Processing";

            // PictureBox for Original Image
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxOriginal.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBoxOriginal);

            // PictureBox for Processed Image
            this.pictureBoxProcessed = new System.Windows.Forms.PictureBox();
            this.pictureBoxProcessed.Location = new System.Drawing.Point(340, 20);
            this.pictureBoxProcessed.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBoxProcessed);

            // PictureBox for Result Image (Subtraction Result)
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult.Location = new System.Drawing.Point(660, 20);
            this.pictureBoxResult.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBoxResult);

            // Load Image Button
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.Location = new System.Drawing.Point(20, 350);
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            this.Controls.Add(this.btnLoadImage);

            // Apply Greyscale Button
            this.btnApplyGreyscale = new System.Windows.Forms.Button();
            this.btnApplyGreyscale.Text = "Greyscale";
            this.btnApplyGreyscale.Location = new System.Drawing.Point(140, 350);
            this.btnApplyGreyscale.Click += new System.EventHandler(this.btnApplyGreyscale_Click);
            this.Controls.Add(this.btnApplyGreyscale);

            // Apply Color Inversion Button
            this.btnApplyInversion = new System.Windows.Forms.Button();
            this.btnApplyInversion.Text = "Invert Colors";
            this.btnApplyInversion.Location = new System.Drawing.Point(260, 350);
            this.btnApplyInversion.Click += new System.EventHandler(this.btnApplyInversion_Click);
            this.Controls.Add(this.btnApplyInversion);

            // Apply Histogram Button
            this.btnApplyHistogram = new System.Windows.Forms.Button();
            this.btnApplyHistogram.Text = "Histogram";
            this.btnApplyHistogram.Location = new System.Drawing.Point(380, 350);
            this.btnApplyHistogram.Click += new System.EventHandler(this.btnApplyHistogram_Click);
            this.Controls.Add(this.btnApplyHistogram);

            // Apply Sepia Button
            this.btnApplySepia = new System.Windows.Forms.Button();
            this.btnApplySepia.Text = "Sepia";
            this.btnApplySepia.Location = new System.Drawing.Point(500, 350);
            this.btnApplySepia.Click += new System.EventHandler(this.btnApplySepia_Click);
            this.Controls.Add(this.btnApplySepia);

            // Save Image Button
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.Location = new System.Drawing.Point(620, 350);
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            this.Controls.Add(this.btnSaveImage);

            // Load Background Image Button (for Image B in subtraction)
            this.btnLoadBackground = new System.Windows.Forms.Button();
            this.btnLoadBackground.Text = "Load Background";
            this.btnLoadBackground.Location = new System.Drawing.Point(740, 350);
            this.btnLoadBackground.Click += new System.EventHandler(this.btnLoadBackground_Click);
            this.Controls.Add(this.btnLoadBackground);

            // Subtract Images Button
            this.btnSubtractImages = new System.Windows.Forms.Button();
            this.btnSubtractImages.Text = "Subtract Images";
            this.btnSubtractImages.Location = new System.Drawing.Point(860, 350);
            this.btnSubtractImages.Click += new System.EventHandler(this.btnSubtractImages_Click);
            this.Controls.Add(this.btnSubtractImages);
        }

        #endregion
    }
}
