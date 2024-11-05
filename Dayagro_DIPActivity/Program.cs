using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dayagro_DIPActivity
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap backgroundImage;
        private Bitmap resultImage;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Form settings
            this.Text = "Digital Image Processing";
            this.ClientSize = new Size(800, 450);

            // Load Image button
            Button btnLoadImage = new Button
            {
                Text = "Load Image",
                Location = new Point(50, 400),
                Size = new Size(100, 30)
            };
            btnLoadImage.Click += new EventHandler(btnLoadImage_Click);
            this.Controls.Add(btnLoadImage);

            // Load Background button
            Button btnLoadBackground = new Button
            {
                Text = "Load Background",
                Location = new Point(200, 400),
                Size = new Size(120, 30)
            };
            btnLoadBackground.Click += new EventHandler(btnLoadBackground_Click);
            this.Controls.Add(btnLoadBackground);

            // Subtract button
            Button btnSubtract = new Button
            {
                Text = "Subtract",
                Location = new Point(380, 400),
                Size = new Size(100, 30)
            };
            btnSubtract.Click += new EventHandler(btnSubtractImages_Click);
            this.Controls.Add(btnSubtract);

            // Picture boxes for displaying images
            pictureBoxOriginal = new PictureBox
            {
                Location = new Point(50, 20),
                Size = new Size(200, 300),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            this.Controls.Add(pictureBoxOriginal);

            pictureBoxBackground = new PictureBox
            {
                Location = new Point(300, 20),
                Size = new Size(200, 300),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            this.Controls.Add(pictureBoxBackground);

            pictureBoxResult = new PictureBox
            {
                Location = new Point(550, 20),
                Size = new Size(200, 300),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            this.Controls.Add(pictureBoxResult);
        }

        private PictureBox pictureBoxOriginal;
        private PictureBox pictureBoxBackground;
        private PictureBox pictureBoxResult;

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                pictureBoxOriginal.Image = originalImage;
            }
        }

        private void btnLoadBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundImage = new Bitmap(openFileDialog.FileName);
                pictureBoxBackground.Image = backgroundImage;
            }
        }

        private void btnSubtractImages_Click(object sender, EventArgs e)
        {
            if (originalImage == null || backgroundImage == null)
            {
                MessageBox.Show("Please load both images first.");
                return;
            }

            if (originalImage.Size != backgroundImage.Size)
            {
                MessageBox.Show("Images must be of the same size.");
                return;
            }

            resultImage = SubtractImages(originalImage, backgroundImage);
            pictureBoxResult.Image = resultImage;
        }

        private Bitmap SubtractImages(Bitmap imageA, Bitmap imageB)
        {
            Bitmap resultImage = new Bitmap(imageA.Width, imageA.Height);
            Color greenColor = Color.FromArgb(0, 255, 0);
            int greyGreen = (greenColor.R + greenColor.G + greenColor.B) / 3;
            int threshold = 5;

            for (int x = 0; x < imageA.Width; x++)
            {
                for (int y = 0; y < imageA.Height; y++)
                {
                    Color pixelA = imageA.GetPixel(x, y);
                    Color pixelB = imageB.GetPixel(x, y);

                    int greyA = (pixelA.R + pixelA.G + pixelA.B) / 3;
                    int greyB = (pixelB.R + pixelB.G + pixelB.B) / 3;

                    int subtractValue = Math.Abs(greyA - greyGreen);
                    if (subtractValue > threshold)
                        resultImage.SetPixel(x, y, pixelA);
                    else
                        resultImage.SetPixel(x, y, pixelB);
                }
            }

            return resultImage;
        }
    }
}
