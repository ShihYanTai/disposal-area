using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 台大開放課程5
{
    internal class Rectangle
    {
        private int width;
        private int height;

        public int Width
        {
            set { width = value; }
            get { return width; }

        }

        public int Height
        {
            set { height = value; }
            get { return height; }
        }

        public void Rotate()
        {
            int temp = width;
            width = height;
            height = temp;
        }

        static void Main(string[] args)
        {
            Rectangle a = new Rectangle();
            a.Width = 3;
            a.Height = 5;

            Rectangle b = new Rectangle();
            b = new Rectangle();
            b.Width = 2;
            b.Height = 2;

            Rectangle c = new Rectangle();
            c.Width = 4;
            c.Height = 1;

            a.Rotate();
            b.Rotate();
            c.Rotate();
        }
    }
}
