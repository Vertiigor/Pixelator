using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixelator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Pixelizer pixelizer;

        public Form()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (OpenImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(OpenImage.FileName, FileMode.Open))
                    {
                        OriginCanvas.Image = (Bitmap)System.Drawing.Image.FromStream(stream);
                        stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveImage.ShowDialog() == DialogResult.OK && PixelateCanvas.Image != null)
            {
                try
                {
                    PixelateCanvas.Image.Save(SaveImage.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void PixelateButton_Click(object sender, EventArgs e)
        {
            if((Bitmap)OriginCanvas.Image == null)
            {
                MessageBox.Show("Origin image is empty", "Error");

                return;
            }

            Bitmap pixelizedImage = new Bitmap(OriginCanvas.Image.Width, OriginCanvas.Image.Height);

            Graphics graphics = Graphics.FromImage(pixelizedImage);

            pixelizer = new Pixelizer(new Bitmap(OriginCanvas.Image), (int)PixelateTrackBar.Value);

            Bitmap pxlzBitmap = pixelizer.Pixelate();

            int pixelX = 0;
            int pixelY = 0;

            for(int x = 0; x < pxlzBitmap.Width; x++)
            {
                for(int y = 0; y < pxlzBitmap.Height; y++)
                {
                    Brush brush = new SolidBrush(pxlzBitmap.GetPixel(x, y));

                    graphics.FillRectangle(brush, pixelX, pixelY, (int)PixelateTrackBar.Value, (int)PixelateTrackBar.Value);

                    pixelY += (int)PixelateTrackBar.Value;
                }

                pixelY = 0;
                pixelX += (int)PixelateTrackBar.Value;
            }

            PixelateCanvas.Image = pixelizedImage;
        }
    }
}
