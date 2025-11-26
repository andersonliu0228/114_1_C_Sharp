using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int count = 1;

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\m303\Desktop\114_1_C_Sharp\114_11_26\Tutorial 5-4-1";
            saveFileDialog1.Title = "選擇儲存朋友名字的檔案";
            StreamWriter outputFile;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.AppendText(saveFileDialog1.FileName);
                outputFile.WriteLine(count + ": " + nameTextBox.Text);
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("未選擇檔案");
            }
            nameTextBox.Text = "";
            nameTextBox.Focus();
            count++;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
