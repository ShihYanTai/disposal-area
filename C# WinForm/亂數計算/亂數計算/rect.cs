using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 亂數計算
{
    internal class rect
    {
        public int Width = 0;
        private int _height = 0;
        ~rect() { }
        public int Height
        {
            get => _height;
            set => _height = value;
        }
        int GetSize() => Width * _height;
        public void Show(TextBox tb)
        {
            tb.Text = " 矩陣面積 =" + GetSize().ToString() + "\r\n";
        }
        
    }
}
