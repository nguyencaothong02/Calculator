using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumberA.Text);
            double b = double.Parse(txtNumberB.Text);
            double c = a + b;
            txtResult.Text = c.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumberA.Text);
            double b = double.Parse(txtNumberB.Text);
            double c = a - b;
            txtResult.Text = c.ToString();
        }
    }
}
