using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            String message = "點餐內容:";
            String drink = "";
            String sandwich = "";
            if (CoffeeRadioButton.Checked == true)
            {
                drink = "咖啡";
            }
            else if (MilkTeaRadioButton.Checked == true)
            {
                drink = "奶茶";
            }
            else if (BlackTeaRadioButton.Checked == true)
            {
                drink = "紅茶";
            }
            else if (JuiceRadioButton.Checked == true)
            {
                drink = "果汁";
            }
            else
            {
                drink = "未選擇飲料";
            }

            if (TunaRadioButton.Checked == true)
            {
                sandwich = "鮪魚三明治";
            }
            else if (HamRadioButton.Checked == true)
            {
                sandwich = "火腿三明治";
            }
            else if (JamRadioButton.Checked == true)
            {
                sandwich = "果醬三明治";
            }
            else
            {
                sandwich = "未選擇三明治";
            }
            message = message + drink + "," + sandwich;
            MessageBox.Show(message);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
