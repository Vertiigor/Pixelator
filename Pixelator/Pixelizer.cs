using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixelator
{
    internal class Pixelizer
    {
        private Pixel[,] pixels;

        private int width, height, degree;

        public int Degree { get; }
        public Pixelizer(Bitmap bitmap, int degree)
        {
            this.width = bitmap.Width;
            this.height = bitmap.Height;

            this.degree = degree;

            this.pixels = new Pixel[bitmap.Width, bitmap.Height];

            LoadFromBitmap(bitmap);
        }

        public void LoadFromBitmap(Bitmap bitmap)
        {
            for(int x = 0; x < bitmap.Width; x++)
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

                    pixelized.SetPixel(pxlzX, pxlzY, Color.FromArgb(pixel.A, pixel.R, pixel.G, pixel.B));

                    pxlzY++;
                }

                pxlzY = 0;
                pxlzX++;

            }

            return pixelized;
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

            return pixel;
        }
    }
}
