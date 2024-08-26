using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_PayRoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int CA, MA, HR,groosPay,IT,netSalary;
            int basicpay = Convert.ToInt32(BasictextBox.Text);
            if(basicpay >= 40000)
            {
                CA = (int)(basicpay * 0.40);
                ContextBox.Text = CA.ToString();
                MA = (int)(basicpay * 0.30);
                MedtextBox.Text = MA.ToString();
                HR = (int)(basicpay * 0.20);
                HousetextBox.Text = HR.ToString();
                groosPay = basicpay + CA + MA +HR;
                GrosstextBox.Text = groosPay.ToString();
                if(groosPay >= 60000)
                {
                    IT = (int)(groosPay * 0.03);
                    IncometextBox.Text = IT.ToString();
                    netSalary = groosPay -IT;
                    NettextBox.Text = netSalary.ToString(); 
                }
            }
            else if(basicpay >=
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdtextBox.Text))
            {
                IdtextBox.Focus();
                errorProvider1.SetError(this.IdtextBox, " Please Enter the Id");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void NametextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NametextBox.Text))
            {
                NametextBox.Focus();
                errorProvider2.SetError(this.NametextBox, " Please Enter the Name");
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void DestextBox_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void DestextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DestextBox.Text))
            {
                DestextBox.Focus();
                errorProvider3.SetError(this.DestextBox, " Please Enter the designation");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void BasictextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BasictextBox.Text))
            {
                BasictextBox.Focus();
                errorProvider4.SetError(this.BasictextBox, " Please Enter the basic Pay");
            }
            else
            {
                errorProvider4.Clear();
            }
        }
    }
}
