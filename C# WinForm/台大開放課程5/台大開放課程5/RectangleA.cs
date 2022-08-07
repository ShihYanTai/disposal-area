using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 台大開放課程5
{
    internal class RectangleA
    {
        class Rectangle
        {
            private int width;
            private int height;

            public void SetWidth(int w)
            {
                width = w;
            }
            public int GetWidth()
            {
                return width;
            }

            public void SetHeight(int h)
            {
                height = h;
            }

            public int GetHeight()
            {
                return height;
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
                a.SetWidth(3);
                a.SetHeight(5);

                Rectangle b = new Rectangle();
                b = new Rectangle();
                b.SetWidth(2);
                b.SetHeight(2);

                Rectangle c = new Rectangle();
                c.SetWidth(4);
                c.SetHeight(1);

                a.Rotate();
                b.Rotate();
                c.Rotate();
            }
        }
    }
}
