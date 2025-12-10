using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    // 牌卡顯示程式的主表單類別
    public partial class Form1 : Form
    {
        // 表單建構函式
        public Form1()
        {
            InitializeComponent();
        }

        // 顯示牌卡按鈕的點擊事件處理程序
        private void showCardButton_Click(object sender, EventArgs e)
        {
           if (cardListBox.SelectedIndex != -1)
            {
                showSelectCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("請先選擇一張卡片!");
            }
        }

        // 黑桃A牌卡的處理方法
        private void showSelectCard(string cardName)
        {
            switch(cardName)
            {
                case "黑桃A":
                    // 顯示黑桃A牌卡，隱藏其他牌卡
                    showAceSpade();
                    break;
                case "紅心10":
                    // 顯示紅心10牌卡，隱藏其他牌卡
                    showTenHeart();
                    break;
                case "梅花K":
                    // 顯示梅花K牌卡，隱藏其他牌卡
                    showKingClubs();
                    break;
            }
        }
        // 顯示黑桃A牌卡的方法
        private void showAceSpade()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        // 顯示紅心10牌卡的方法
        private void showTenHeart()
        {
             aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }
        // 顯示梅花K牌卡的方法
        private void showKingClubs()
        {
             aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }

        // 結束按鈕的點擊事件處理程序，關閉表單視窗
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單視窗。
            this.Close();
        }
    }
}
