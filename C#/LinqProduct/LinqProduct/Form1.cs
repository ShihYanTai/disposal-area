using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product[] p = new Product[]
        {
            new Product{id="A01",Name="火影忍者",Price="1000"},
            new Product{id="A02",Name="獵人",Price="800"},
            new Product{id="A03",Name="墨世佛劫",Price="1100"},
            new Product{id="A04",Name="甲賀忍法帖",Price="600"},
            new Product{id="A05",Name="航海王",Price="450"},
            new Product{id="A06",Name="墨武俠蜂",Price="1060"}
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            DgvProduct.DataSource = p;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var result = p.Where(r => r.Name.Contains(TxtSearch.Text));
            DgvProduct.DataSource = result.ToList();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            var result = p.OrderBy(r => r.id);
            DgvProduct.DataSource = result.ToList();
        }

        private void BtnASC_Click(object sender, EventArgs e)
        {
            var result = p.OrderBy(r => r.Price).ToList();
            DgvProduct.DataSource = result;
        }

        private void BtnDESC_Click(object sender, EventArgs e)
        {
            var result = p.OrderByDescending(r => r.Price).ToList();
            DgvProduct.DataSource = result;
        }
    }
}
