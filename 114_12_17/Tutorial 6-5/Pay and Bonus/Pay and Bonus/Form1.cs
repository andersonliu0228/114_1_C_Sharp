using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // 常數欄位：退休金提撥比例（5%）
        private const decimal CONTRIB_RATE = 0.05m;

        // 建構函式：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // InputIsValid 方法：驗證並轉換使用者輸入的資料
        // 此方法會將使用者輸入的內容轉換並儲存到傳入的參數中（使用傳址方式）
        // 如果轉換成功，方法會回傳 true，否則回傳 false


        // 計算按鈕點擊事件處理常式
        // 當使用者點擊「計算提撥」按鈕時，此方法會被呼叫
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告變數以儲存總薪資、獎金及提撥金額
            decimal grossPay;
            decimal bonus;
            decimal contribution;
            // 驗證並轉換使用者輸入的總薪資和獎金
            if (InputIsValid(out grossPay, out bonus))
            {
                contribution = CONTRIB_RATE * (grossPay + bonus);
                // 顯示計算結果，格式化為貨幣形式
                contributionLabel.Text = contribution.ToString("C");
            }
            else
            {
                // 顯示錯誤訊息，提示使用者輸入有效的數字
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");
            }
        }

        private bool InputIsValid(out decimal grossPay, out decimal bonus)
        {
            bool inputIsValid = false;
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {
                if(decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    inputIsValid = true;
                }
                else
                {
                    MessageBox.Show("獎金金額輸入無效，請輸入有效的數字。", "輸入錯誤");
                    //inputIsValid = false;
                }
            }
            else
            {
                MessageBox.Show("總薪資金額輸入無效，請輸入有效的數字。", "輸入錯誤");
                //inputIsValid = false;
                bonus = 0; // 初始化 bonus 以避免編譯錯誤
            }
            return inputIsValid;
        }

        // 離開按鈕點擊事件處理常式
        // 當使用者點擊「離開」按鈕時，此方法會關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
