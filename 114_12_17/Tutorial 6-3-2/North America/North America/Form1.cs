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

namespace North_America
{
    public partial class Form1 : Form
    {
        // 表單建構子 - 初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // GetFileName 方法從使用者取得檔案名稱
        // 並將其指派給作為參數傳遞的變數

        // GetCountries 方法接受檔案名稱作為參數
        // 它會開啟指定的檔案並在 countriesListBox 控制項中顯示其內容
        

        // 取得國家按鈕的點擊事件處理程序
        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;
            //取得檔案名稱
            fileName = GetFileName();
            //顯示國家清單
            GetCountries(fileName);
        }

        private string GetFileName()
        {
            string fileName;
            // 顯示開啟檔案對話方塊並檢查使用者是否選擇了檔案
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // 將選擇的檔案名稱指派給輸出參數
                fileName = openFile.FileName;
            }
            else
            {
                // 如果使用者取消，將輸出參數設為空字串
                fileName = string.Empty;
            }
            return fileName;
        }

        private void GetCountries(string fileName)
        {
            // 清除現有的國家列表
            string country;
            countriesListBox.Items.Clear();
            // 檢查檔案名稱是否為空
            if (fileName != string.Empty)
            {
                // 使用 StreamReader 開啟檔案並讀取內容
                using (StreamReader reader = new StreamReader(fileName))
                {
                    // 逐行讀取檔案直到結束
                    while (!reader.EndOfStream)
                    {
                        country = reader.ReadLine();
                        // 將讀取的國家名稱添加到列表框中
                        countriesListBox.Items.Add(country);
                    }
                }
            }
            else
            {
                // 如果檔案名稱為空，顯示錯誤訊息
                MessageBox.Show("未選擇檔案。");
            }
        }
        // 結束按鈕的點擊事件處理程序
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

    }
}
