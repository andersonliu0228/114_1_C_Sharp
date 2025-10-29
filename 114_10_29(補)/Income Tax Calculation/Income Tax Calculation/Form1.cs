using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income_Tax_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal annual_income;
            decimal tax_discount;
            decimal net_income;
            decimal other_discount;
            label5.Text = textBox1.Text.ToString();
            annual_income = decimal.Parse(textBox1.Text);
            tax_discount = decimal.Parse(textBox2.Text);
            other_discount = decimal.Parse(textBox3.Text);
            net_income = annual_income - tax_discount - other_discount;
            label6.Text = decimal.Parse(net_income.ToString()).ToString();
            label8.Text = decimal.Parse((net_income * 0.15M).ToString()).ToString("N2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
