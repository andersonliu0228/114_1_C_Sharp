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
            try
            {
                inputFile = File.OpenText(@"C:\\Users\\m303\\Desktop\\114_1_C_Sharp\\114_11_26\\Tutorial 5-7-2\\Total Sales\\Total Sales\\bin\\Debug\\Sales_monthname.txt");// 開啟Sales_monthname.txt檔案
                while (!inputFile.EndOfStream)// 迴圈讀取檔案直到結尾
                {
                    string line = inputFile.ReadLine();// 讀取一行數據
                    
                    // 分割字串以取得月份名稱和銷售額
                    string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    if (parts.Length >= 2)// 確保至少有月份和銷售額兩個元素
                    {
                        string monthName = parts[0];// 取得月份名稱
                        string salesValue = parts[1];// 取得銷售額字串
                        
                        // 顯示月份和銷售額到清單方塊
                        listBox1.Items.Add(monthName + ": " + salesValue);
                        
                        // 將銷售額字串轉換為十進位數字
                        currentSales = decimal.Parse(salesValue);
                        
                        // 累加到銷售總額
                        totalSales += currentSales;
                    }
                }
                inputFile.Close();// 關閉檔案
                totalLabel.Text = totalSales.ToString("c");// 顯示銷售總額（貨幣格式）
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);// 顯示錯誤訊息
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
