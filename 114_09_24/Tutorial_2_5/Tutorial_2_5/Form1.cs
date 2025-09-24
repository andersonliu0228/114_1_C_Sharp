using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = false;
            cardfacePictureBox.Visible = false;
        }

        private void showbackButton_Click(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = true;
            cardfacePictureBox.Visible = false;
        }

        private void cardfacePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void showfaceButton_Click(object sender, EventArgs e)
        {
            cardfacePictureBox.Visible = true;
            cardbackPictureBox.Visible = false;
        }
    }
}
