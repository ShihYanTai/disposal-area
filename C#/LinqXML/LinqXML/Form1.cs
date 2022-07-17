using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace LinqXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XElement xf = XElement.Load("aqx.xml");
        private void Form1_Load(object sender, EventArgs e)
        {
            var result = from s in xf.Elements()
                         select new
                         {
                             縣市 = (string)s.Element("county"),
                             測站 = (string)s.Element("Site"),
                             濃度 = (int)s.Element("PM25")
                         };
            DgvShow.DataSource = result.ToList();
        }

        private void BtnCountry_Click(object sender, EventArgs e)
        {
            var reult = from s in xf.Elements()
                        orderby (string)s.Element("county")
                        select new
                        {
                            縣市 = (string)s.Element("county"),
                            測站 = (string)s.Element("Site"),
                            濃度 = (int)s.Element("PM25")
                        };
            DgvShow.DataSource = reult.ToList();
        }

        private void BtnPM25_Click(object sender, EventArgs e)
        {
            var reult = from s in xf.Elements()
                        orderby (string)s.Element("PM25") descending
                        select new
                        {
                            縣市 = (string)s.Element("county"),
                            測站 = (string)s.Element("Site"),
                            濃度 = (int)s.Element("PM25")
                        };
            DgvShow.DataSource = reult.ToList();
        }

        private void BtnSearch_Click(object sender, EventArgs ex)
        {
            try
            {
                var reult = from s in xf.Elements()
                            where (int)s.Element("Site") >= int.Parse(TxtSearch.Text)
                            select new
                            {
                                縣市 = (string)s.Element("county"),
                                測站 = (string)s.Element("Site"),
                                濃度 = (int)s.Element("PM25")
                            };
                DgvShow.DataSource = reult.ToList();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
