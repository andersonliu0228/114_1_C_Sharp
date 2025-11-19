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

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            string country;
            try
            {
                inputFile = File.OpenText(@"C:\Users\m303\Desktop\114_1_C_Sharp\114_11_19\Countries.txt");
                countriesListBox.Items.Clear();
                // 讀取檔案中的每一行，直到檔案結尾。
                while (!inputFile.EndOfStream)
                {
                    country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
