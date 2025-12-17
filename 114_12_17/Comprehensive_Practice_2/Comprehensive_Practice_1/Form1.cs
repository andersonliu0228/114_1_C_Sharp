using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprehensive_Practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShowMax_Click(object sender, EventArgs e)
        {
            string surname = textBoxLastName.Text;
            string givenName = textBoxFirstName.Text;
            int quiz1 = 0, quiz2 = 0, quiz3 = 0;
            if (int.TryParse(textBoxQuiz1.Text, out quiz1) &&
                int.TryParse(textBoxQuiz2.Text, out quiz2) &&
                int.TryParse(textBoxQuiz3.Text, out quiz3))
            {
                showResult(surname, givenName, quiz1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("成績一律輸入整數", "資料錯誤");
                ClearTextBoxes();
            }
            //MessageBox.Show(string.Format("小考2 = {0}", quiz2));
        }
        private void showResult(string surname, string givenName, int quiz1, int quiz2, int quiz3)
        {
            int maxScore = 0;
            maxScore = findHighestScore(quiz1, quiz2, quiz3);
            quiz2 = 200;
            labelResult.Text = string.Format("{0}{1}的最高成績是{2}分", givenName, surname, maxScore);
            //MessageBox.Show(string.Format("Quiz2 = {0}", quiz2));
        }
        private void ClearTextBoxes()
        {
            textBoxQuiz1.Clear();
            textBoxQuiz2.Clear();
            textBoxQuiz3.Clear();
            textBoxFirstName.Focus();
        }
        private int findHighestScore(int quiz1, int quiz2, int quiz3)
        { 
            int maxScore;
            if (quiz1 >= quiz2 && quiz1 >= quiz3)
            {
                maxScore = quiz1;
            }
            else if (quiz2 >= quiz1 && quiz2 >= quiz3)
            {
                maxScore = quiz2;
            }
            else
            {
                maxScore = quiz3;
            }
            return maxScore;
        }
    }
}
