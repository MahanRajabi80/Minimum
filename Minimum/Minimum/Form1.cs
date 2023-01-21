using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int d1, d2, d3, d4, d5, d6, min;
            d1 = Convert.ToInt32(txtNumber1.Text);
            d2 = Convert.ToInt32(txtNumber2.Text);
            d3 = Convert.ToInt32(txtNumber3.Text);
            d4 = Convert.ToInt32(txtNumber4.Text);
            d5 = Convert.ToInt32(txtNumber5.Text);
            d6 = Convert.ToInt32(txtNumber6.Text);
            min = d1;
            if (min > d2) min = d2;
            if (min > d3) min = d3;
            if (min > d4) min = d4;
            if (min > d5) min = d5;
            if (min > d6) min = d6;
            MessageBox.Show("Min=" + min.ToString(), "Min");
        }
    }
}
