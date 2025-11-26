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

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;// 宣告輸入檔案物件
            decimal totalSales = 0;// 儲存銷售總額
            decimal currentSales = 0;// 儲存目前銷售額
            string line;
            try
            {
                inputFile = File.OpenText("Sales1.txt");// 開啟Sales.txt檔案
                while (!inputFile.EndOfStream)// 迴圈讀取檔案直到結尾
                {
                    if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                    {
                        totalSales += currentSales;// 加到銷售總額
                    }
                    else
                    {
                        MessageBox.Show("無法解析銷售額: " + line);
                        //break;
                    }
                }
                inputFile.Close();// 關閉檔案
                totalLabel.Text = totalSales.ToString("c");// 顯示銷售總額
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤" + ex.Message); 
                return;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inputFile;// 宣告輸入檔案物件
            decimal currentSales = 0;// 儲存目前銷售額
            string line;// 儲存讀取的每一行資料
            try
            {
                inputFile = File.OpenText("Sales1.txt");// 開啟Sales.txt檔案
                listBox1.Items.Clear();// 清除清單方塊中的項目
                while (!inputFile.EndOfStream)// 迴圈讀取檔案直到結尾
                {
                    if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                    {
                        listBox1.Items.Add(line);// 將目前銷售額加入清單方塊
                    }
                    else
                    {
                        MessageBox.Show("無法解析銷售額: " + line);
                        //break;
                    }
                }
                inputFile.Close();// 關閉檔案
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤" + ex.Message);
                return;
            }
            calculateButton.Text = "讀取銷售數據並計算總額";
        }
    }
}
