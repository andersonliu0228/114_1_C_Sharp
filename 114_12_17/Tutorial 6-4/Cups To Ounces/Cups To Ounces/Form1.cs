using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CupsToOunces 方法接受杯數作為參數
        // 並返回相對應的液體盎司數量
        // 1 杯 = 8 液體盎司
     

        /// <summary>
        /// 轉換按鈕點擊事件處理程序
        /// 將使用者輸入的杯數轉換為液體盎司並顯示結果
        /// </summary>
        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups; // 用於存儲使用者輸入的杯數
            double ounces; // 用於存儲轉換後的液體盎司
            // 從文本框讀取使用者輸入並將其轉換為 double
            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                // 調用 CupsToOunces 方法進行轉換
                ounces = CupsToOunces(cups);
                // 將結果顯示在標籤上，格式化為兩位小數
                ouncesLabel.Text = ounces.ToString("F2");
            }
            else
            {
                // 如果輸入無效，顯示錯誤訊息
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");
            }
        }

        private double CupsToOunces(double cups)
        {
            return cups * 8;
        }
        /// <summary>
        /// 離開按鈕點擊事件處理程序
        /// 關閉應用程式視窗
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
