using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal totalCalories = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            totalCalories += 115;
            label2.Text = totalCalories.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            totalCalories += 80;
            label2.Text = totalCalories.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            totalCalories += 90;
            label2.Text = totalCalories.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            totalCalories += 120;
            label2.Text = totalCalories.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            totalCalories = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
