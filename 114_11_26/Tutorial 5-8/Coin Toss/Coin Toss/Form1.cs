using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int headsCount = 0;
        private int tailsCount = 0;
        private void tossButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int coinToss = rand.Next(2); // Generates a number, either 0 or 1.
            if (coinToss == 0)
            {
                // Show heads.
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
                headsCount++;
            }
            else
            {
                // Show tails.
                headsPictureBox.Visible = false;
                tailsPictureBox.Visible = true;
                tailsCount++;
            }
            // Update the text boxes with the counts.
            textBox1.Text = headsCount.ToString();
            textBox2.Text = tailsCount.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
