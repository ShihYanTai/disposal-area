using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EmployeeDBEntities db = new EmployeeDBEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            DgvData.DataSource = db.員工.ToList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                員工 emp = new 員工();
                emp.員工編號 = TxtId.Text;
                emp.姓名 = TxtName.Text;
                emp.職稱 = TxtTitle.Text;
                emp.薪資 = int.Parse(TxtId.Text);
                db.員工.Add(emp);
                db.SaveChanges();
                DgvData.DataSource = db.員工.ToList();
                
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnUpData_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = db.員工.Where(r => r.員工編號 == TxtId.Text).FirstOrDefault();
                if(emp == null)
                {
                    return;
                }
                emp.姓名 = TxtName.Text;
                emp.職稱 = TxtTitle.Text;
                emp.薪資 = int.Parse(TxtSalary.Text);
                db.SaveChanges();
                DgvData.DataSource = db.員工.ToList();
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = db.員工.Where(r => r.員工編號 == TxtId.Text).FirstOrDefault();
                if(emp == null)
                {
                    return;
                }
                db.員工.Remove(emp);
                db.SaveChanges();
                DgvData.DataSource = db.員工.ToList();
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
