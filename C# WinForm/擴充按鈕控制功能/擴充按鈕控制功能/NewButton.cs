using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 擴充按鈕控制功能
{
    public partial class NewButton : Button
    {
        bool fgDown = false;
        static int Count = 0;
        public NewButton()
        {
            InitializeComponent();
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            SolidBrush bsh;
            bsh = (!fgDown) ? new SolidBrush(Color.LightSeaGreen) : new SolidBrush(Color.Red);
            g.FillEllipse(bsh, new Rectangle(7, this.Height / 2 - 4, 7, 7));
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            fgDown = true;
            base.OnMouseDown(mevent);
            Count++;
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            fgDown = false;
            base.OnMouseUp(mevent);
        }
        public int ClickNum() => Count;
    }
}
