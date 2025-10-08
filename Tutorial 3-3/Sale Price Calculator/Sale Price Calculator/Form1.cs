using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        // 建構函式，初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算折後價格」按鈕時觸發
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 此處可加入計算邏輯
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            // 嘗試將使用者輸入的原價和折扣百分比轉換為decimal
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);
            // 計算折後價格
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);
            // 顯示折後價格，格式化為貨幣形式
            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 當使用者按下「離開」按鈕時觸發
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
