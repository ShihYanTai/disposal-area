using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace 台大開放課程6
{

    public class Rectangle
    {
        private int width;
        private int height;

        public int Width
        {
            get { return Width; }
        }
        public int Height
        {
            get { return height; }
        }

        public Rectangle(int width, int height)
        {
            this.width = 1;
            this.height = 1;
        }
        public Rectangle(int w,int h)
        {
            width = w;
            height = h;
        }
        public Rectangle(int w)
        {
            width = w;
            height = w;
        }
        static void Rotate(ref int width,ref int height)
        {
            int temp = width;
            width = height;
            height = temp;
        }
    }
    static void Main(string[] args)
    {
        Rectangle a = new Rectangle(3,5);
        // 矩形a

        Rectangle b = new Rectangle(2);
        // 矩形b

        Rectangle c = new Rectangle(4,1);
        // 矩形c

        //旋轉90度
        a.Rotate();
        b.Rotate();
        c.Rotate();

        Debug.Assert(a.Width == 5 && a.Height == 3);
        Debug.Assert(b.Width == 2 && b.Height == 2);
        Debug.Assert(c.Width == 1 && c.Height == 4);
    }

}
