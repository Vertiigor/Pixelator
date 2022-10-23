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

            Pixelizer pixelizer = new Pixelizer(new Bitmap(OriginCanvas.Image), (int)PixelateTrackBar.Value);

            PixelateCanvas.Image = pixelizer.PixelateSameSize();
        }
    }
}
