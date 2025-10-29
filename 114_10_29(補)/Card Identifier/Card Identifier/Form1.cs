using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "菱形8";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "梅花2";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "黑桃K";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "黑桃A";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "Joker";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
