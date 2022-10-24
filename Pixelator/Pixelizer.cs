using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixelator
{
    internal class Pixelizer
    {
        private Pixel[,] pixels; //pixels from input image

        private int width, height, degree;

        public int Degree { get; } //pixelate factor

        /// <summary>
        /// Initializing a New Pixelizer Object
        /// </summary>
        /// <param name="bitmap">input bitmap</param>
        /// <param name="degree">pixelate factor</param>
        public Pixelizer(Bitmap bitmap, int degree)
        {
            this.width = bitmap.Width;
            this.height = bitmap.Height;

            this.degree = degree;

            LoadFromBitmap(bitmap);
        }

        /// <summary>
        /// Loads pixels from an input image
        /// </summary>
        /// <param name="bitmap">input bitmap</param>
        public void LoadFromBitmap(Bitmap bitmap)
        {
            this.pixels = new Pixel[bitmap.Width, bitmap.Height];

            for (int x = 0; x < bitmap.Width; x++)
            {
                for( int y = 0; y < bitmap.Height; y++)
                {
                    int a = bitmap.GetPixel(x, y).A;
                    int r = bitmap.GetPixel(x, y).R;
                    int g = bitmap.GetPixel(x, y).G;
                    int b = bitmap.GetPixel(x, y).B;

                    pixels[x, y] = new Pixel(a, r, g, b);
                }
            }
        }


        /// <summary>
        /// Pixelizes the image with the new size
        /// </summary>
        /// <returns></returns>
        public Bitmap Pixelate()
        {
            Bitmap pixelized = new Bitmap(width / degree, height / degree);

            int pxlzX = 0;
            int pxlzY = 0;

            for(int x = 0; x + degree < width; x += degree)
            {
                for(int y = 0; y + degree < height; y += degree)
                {
                    Pixel pixel = GetAvargePixel(x, y);

                    pixelized.SetPixel(pxlzX, pxlzY, pixel.Color);

                    pxlzY++;
                }

                pxlzY = 0;
                pxlzX++;

            }

            return pixelized;
        }

        /// <summary>
        /// Pixelizes the image with the same size of input image
        /// </summary>
        /// <returns></returns>
        public Bitmap PixelateSameSize()
        {
            Bitmap pixelizedImage = new Bitmap(width, height);

            Graphics graphics = Graphics.FromImage(pixelizedImage);

            Bitmap pxlzBitmap = Pixelate();

            int pixelX = 0; //the position by X where the square of the desired color will be drawn
            int pixelY = 0; //the position by Y where the square of the desired color will be drawn

            for (int x = 0; x < pxlzBitmap.Width; x++)
            {
                for (int y = 0; y < pxlzBitmap.Height; y++)
                {
                    Brush brush = new SolidBrush(pxlzBitmap.GetPixel(x, y));

                    graphics.FillRectangle(brush, pixelX, pixelY, degree, degree);

                    pixelY += degree;
                }

                pixelY = 0;
                pixelX += degree;
            }

            return pixelizedImage;
        }

        private Pixel GetAvargePixel(int x, int y)
        {
            Pixel pixel = new Pixel(0, 0, 0, 0);

            int a = 0, r = 0, g = 0, b = 0;

            for(int X = 0; X < degree; X++)
            {
                for(int Y = 0; Y < degree; Y++)
                {
                    a += pixels[x + X, y + Y].A;
                    r += pixels[x + X, y + Y].R;
                    g += pixels[x + X, y + Y].G;
                    b += pixels[x + X, y + Y].B;
                }
            }

            pixel.A = a / (degree * degree);
            pixel.R = r / (degree * degree);
            pixel.G = g / (degree * degree);
            pixel.B = b / (degree * degree);

            pixel.A = pixel.A < 255 && pixel.A > 0 ? 255 : pixel.A; //now all pixels are opaque

            return pixel;
        }
    }
}
