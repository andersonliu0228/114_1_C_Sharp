using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m; // 每月利率為 0.5%
            decimal startingBalance; // 起始餘額
            int months; // 月份數量
            int count = 1; // 迴圈計數器
            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance))
            {
                if (int.TryParse(monthsTextBox.Text, out months) && months > 0)
                {
                    while (count <= months)
                    {
                        // 計算當月結餘
                        startingBalance *= (1 + INTEREST_RATE);
                        // 在 ListBox 中顯示每個月的餘額
                        detailListBox.Items.Add($"第" + count + "個月結餘:" + startingBalance.ToString("c"));
                        count++;
                    }
                    // 顯示最終結餘
                    endingBalanceLabel.Text = startingBalance.ToString("c");
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數量。", "輸入錯誤");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的起始餘額。", "輸入錯誤");
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBox 的內容、結束餘額顯示，以及 ListBox 的所有項目。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 重設焦點到起始金額文字欄位，方便使用者立即輸入新值。
            startingBalTextBox.Focus();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
