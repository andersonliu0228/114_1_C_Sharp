using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        // 遊戲變數
        private int computerWins = 0;  // 電腦勝場數
        private int playerWins = 0;    // 玩家勝場數
        private string computerChoice; // 電腦的選擇
        private string playerChoice;   // 玩家的選擇
        private Random random = new Random(); // 隨機數產生器

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 表單載入事件，初始化遊戲
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 清空圖片和結果顯示
            computerPictureBox.Image = null;
            playerPictureBox.Image = null;
            resultLabel.Text = "";
        }

        /// <summary>
        /// 產生電腦的隨機選擇（石頭/布/剪刀）
        /// </summary>
        private void getCompChoice()
        {
            int choice = random.Next(1, 4); // 產生 1-3 的隨機數
            
            switch (choice)
            {
                case 1:
                    computerChoice = "石頭";
                    break;
                case 2:
                    computerChoice = "布";
                    break;
                case 3:
                    computerChoice = "剪刀";
                    break;
            }
        }

        /// <summary>
        /// 根據電腦的選擇顯示對應的圖片
        /// </summary>
        private void showComputerImage()
        {
            switch (computerChoice)
            {
                case "石頭":
                    computerPictureBox.Image = Properties.Resources.stone_computer;
                    break;
                case "布":
                    computerPictureBox.Image = Properties.Resources.paper_computer;
                    break;
                case "剪刀":
                    computerPictureBox.Image = Properties.Resources.scissor_computer;
                    break;
            }
        }

        /// <summary>
        /// 根據玩家的選擇顯示對應的圖片
        /// </summary>
        private void showPlayerImage()
        {
            switch (playerChoice)
            {
                case "石頭":
                    playerPictureBox.Image = Properties.Resources.stone_player;
                    break;
                case "布":
                    playerPictureBox.Image = Properties.Resources.paper_player;
                    break;
                case "剪刀":
                    playerPictureBox.Image = Properties.Resources.scissor_player;
                    break;
            }
        }

        /// <summary>
        /// 判斷輸贏並更新計分
        /// </summary>
        private void showWinner()
        {
            string result = "";

            // 判斷輸贏
            if (playerChoice == computerChoice)
            {
                result = "平手";
            }
            else if ((playerChoice == "石頭" && computerChoice == "剪刀") ||
                     (playerChoice == "布" && computerChoice == "石頭") ||
                     (playerChoice == "剪刀" && computerChoice == "布"))
            {
                result = "玩家贏";
                playerWins++;
            }
            else
            {
                result = "電腦贏";
                computerWins++;
            }

            // 顯示結果
            resultLabel.Text = result;
        }

        /// <summary>
        /// 玩家選擇石頭
        /// </summary>
        private void stoneButton_Click(object sender, EventArgs e)
        {
            playerChoice = "石頭";
            playRound();
        }

        /// <summary>
        /// 玩家選擇布
        /// </summary>
        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = "布";
            playRound();
        }

        /// <summary>
        /// 玩家選擇剪刀
        /// </summary>
        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = "剪刀";
            playRound();
        }

        /// <summary>
        /// 執行一回合遊戲
        /// </summary>
        private void playRound()
        {
            getCompChoice();        // 電腦隨機選擇
            showComputerImage();    // 顯示電腦圖片
            showPlayerImage();      // 顯示玩家圖片
            showWinner();           // 判斷輸贏並顯示結果
        }

        /// <summary>
        /// 結束遊戲，顯示統計資訊
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 顯示統計資訊
            string message = string.Format("遊戲結束！\n\n玩家贏了 {0} 次\n電腦贏了 {1} 次", playerWins, computerWins);
            MessageBox.Show(message, "遊戲統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // 關閉程式
            this.Close();
        }
    }
}
