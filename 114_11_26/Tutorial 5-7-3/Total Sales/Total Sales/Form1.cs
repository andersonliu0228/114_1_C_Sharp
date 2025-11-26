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
using System.Globalization; // 用於解析小數點格式的數字

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算按鈕點擊事件處理程式
        /// 功能：透過 OpenFileDialog 選擇檔案，讀取「月份 銷售額」格式的資料，計算總銷售額
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;     // 宣告輸入檔案物件
            decimal totalSales = 0;     // 儲存銷售總額
            decimal currentSales = 0;   // 儲存目前銷售額
            string line;                // 儲存讀取的每一行資料

            // 【OpenFileDialog 使用說明】
            // ShowDialog() 方法會顯示檔案選擇對話框
            // 返回值：
            //   - DialogResult.OK ：使用者按下「開啟」按鈕並選擇了檔案
            //   - DialogResult.Cancel ：使用者按下「取消」按鈕，未選擇檔案

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 【獲得選中的檔案路徑】
                    // openFileDialog1.FileName 屬性包含使用者選擇的完整檔案路徑
                    // 例如："C:\\Users\\m303\\Desktop\\Sales_monthname.txt"
                    inputFile = File.OpenText(openFileDialog1.FileName);

                    // 清空清單方塊中的舊資料，為新資料做準備
                    listBox1.Items.Clear();

                    // 迴圈讀取檔案中的每一行資料，直到檔案結尾
                    while (!inputFile.EndOfStream)
                    {
                        // 讀取一行資料
                        line = inputFile.ReadLine();

                        // 檢查是否為空行，若是則略過
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            continue;
                        }

                        // 以空白字元作為分隔符，將行資料分割成欄位陣列
                        // RemoveEmptyEntries 會移除空白欄位，避免多個連續空白造成的問題
                        string[] parts = line.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        // 檢查欄位數是否足夠（至少需要月份和銷售額兩個欄位）
                        if (parts.Length < 2)
                        {
                            // 若欄位不足，顯示錯誤訊息
                            MessageBox.Show("資料格式錯誤（預期格式：月份 銷售額）: " + line);
                            break;
                        }

                        // 取第一個欄位為月份名稱
                        string monthName = parts[0];

                        // 取最後一個欄位為銷售額字串
                        string amountString = parts[parts.Length - 1];

                        // 嘗試將銷售額字串轉換為十進位數值
                        // 使用 InvariantCulture 以支援小數點(.) 格式
                        if (decimal.TryParse(amountString, NumberStyles.Number, CultureInfo.InvariantCulture, out currentSales))
                        {
                            // 將月份和銷售額以貨幣格式加入清單方塊顯示
                            // ToString("C") 會依據系統文化設定格式化為貨幣格式
                            // 例如：$1,000.00（英文）或 NT$1,000（繁體中文）
                            listBox1.Items.Add(string.Format("{0}  {1}", monthName, currentSales.ToString("C")));

                            // 將目前銷售額累加到銷售總額
                            totalSales += currentSales;
                        }
                        else
                        {
                            // 若無法解析銷售額，顯示錯誤訊息
                            MessageBox.Show("無法解析銷售額: " + amountString);
                            break;
                        }
                    }

                    // 關閉檔案並釋放相關資源
                    inputFile.Close();

                    // 將銷售總額以貨幣格式顯示在總標籤上
                    totalLabel.Text = totalSales.ToString("C");
                }
                catch (FileNotFoundException)
                {
                    // 捕捉檔案不存在的例外
                    MessageBox.Show("找不到選中的檔案，請確認檔案是否已被刪除或移動。");
                }
                catch (Exception ex)
                {
                    // 捕捉其他例外並顯示錯誤訊息
                    MessageBox.Show("發生錯誤: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("未選擇任何檔案。");
            }
            // 若使用者按下取消按鈕，ShowDialog() 返回 DialogResult.Cancel，則不執行任何操作
        }

        /// <summary>
        /// 退出按鈕點擊事件處理程式
        /// 功能：關閉表單並結束應用程式
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
