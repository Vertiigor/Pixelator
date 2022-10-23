using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixelator
{
    internal class Pixel
    {
        private int a, r, g, b;

        public int A 
        { 
            get => a;
            set
            {
                if (value >= 0 && value <= 255) a = value;
                else throw new ArgumentException("Can't be less than zero or more than 255");
            }
        }

        public int R
        {
            get => r;
            set
            {
                if (value >= 0 && value <= 255) r = value;
                else throw new ArgumentException("Can't be less than zero or more than 255");
            }
        }

        public int G
        {
            get => g;
            set
            {
                if (value >= 0 && value <= 255) g = value;
                else throw new ArgumentException("Can't be less than zero or more than 255");
            }
        }

        public int B
        {
            get => b;
            set
            {
                if (value >= 0 && value <= 255) b = value;
                else throw new ArgumentException("Can't be less than zero or more than 255");
            }
        }

        public Pixel(int a, int r, int g, int b)
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }
    }
}
