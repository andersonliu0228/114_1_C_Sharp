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
            string line;// 儲存讀取的每一行資料
            decimal[] sales = new decimal[8];// 儲存銷售額陣列
            int index = 0;// 陣列索引
            try
            {
                inputFile = File.OpenText("Sales.txt");// 開啟Sales.txt檔案
                while (!inputFile.EndOfStream)// 迴圈讀取檔案直到結尾
                {
                    if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                    {
                        listBox1.Items.Add(line);// 將目前銷售額加入清單方塊
                        sales[index] = currentSales;// 將目前銷售額存入陣列
                        index++;
                    }
                    else
                    {
                        MessageBox.Show("無法解析銷售額: " + line);
                        break;
                    }
                }
                inputFile.Close();// 關閉檔案
                // 計算銷售總額
                for (int i = 0; i < index; i++)
                {
                    totalSales += sales[i];
                }
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
    }
}
