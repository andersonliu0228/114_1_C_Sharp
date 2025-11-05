using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算按鈕事件：將使用者輸入的公里數與公升數轉為數值，計算每公升可行駛的公里數 (km/L)
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告變數以儲存解析後的數值
            double kms; // 使用者輸入的公里數
            double liters;
            double fuelEconomy;// 使用者輸入的公升數

            if (double.TryParse(milesTextBox.Text, out kms))
            {
                if (double.TryParse(gallonsTextBox.Text, out liters))
                {
                    // 計算每公升可行駛的公里數
                    fuelEconomy = kms / liters;
                    // 顯示結果，格式化為小數點後兩位
                    mpgLabel.Text = fuelEconomy.ToString("F2");
                }
                else
                {
                    MessageBox.Show("請輸入有效的公升數。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的公里數。");
            }
                
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單（結束程式）
            this.Close();
        }
    }
}
