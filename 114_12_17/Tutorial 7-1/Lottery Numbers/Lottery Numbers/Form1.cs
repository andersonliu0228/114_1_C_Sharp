using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構函式：初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 產生號碼按鈕的點擊事件處理程序
        /// 當使用者點擊「產生號碼」按鈕時，此方法會被呼叫
        /// </summary>
        /// <param name="sender">事件的來源物件</param>
        /// <param name="e">事件引數</param>
        private void generateButton_Click(object sender, EventArgs e)
        {
            // 此處將實作產生樂透號碼的邏輯
            const int Size = 5; // 標籤數量
            int[] lotteryNumbers = new int[Size]; // 用於存放產生的樂透號碼
            Label[] labels = { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel }; // 標籤陣列
            Random rand = new Random(); // 建立隨機數產生器
            for (int i = 0; i < Size; i++)
            {
                lotteryNumbers[i] = rand.Next(1, 50); // 產生1到49之間的隨機號碼
            }

            for (int i = 0; i < Size; i++)
            {
                labels[i].Text = lotteryNumbers[i].ToString(); // 將號碼顯示在對應的標籤上
            }
            //firstLabel.Text = lotteryNumbers[0].ToString(); // 顯示第一個號碼
            //secondLabel.Text = lotteryNumbers[1].ToString(); // 顯示第二個號碼
            //thirdLabel.Text = lotteryNumbers[2].ToString(); // 顯示第三個
            //fourthLabel.Text = lotteryNumbers[3].ToString(); // 顯示第四個號碼
            //fifthLabel.Text = lotteryNumbers[4].ToString(); // 顯示第五個號碼
        }

        /// <summary>
        /// 離開按鈕的點擊事件處理程序
        /// 當使用者點擊「離開」按鈕時，關閉應用程式視窗
        /// </summary>
        /// <param name="sender">事件的來源物件</param>
        /// <param name="e">事件引數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束應用程式
            this.Close();
        }
    }
}
