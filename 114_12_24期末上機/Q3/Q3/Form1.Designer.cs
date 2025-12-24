namespace Q3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.lblNumber4 = new System.Windows.Forms.Label();
            this.lblNumber5 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBoxDrawNumbers = new System.Windows.Forms.ListBox();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblMatchCount = new System.Windows.Forms.Label();
            this.lblMatchedNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber1
            // 
            this.lblNumber1.BackColor = System.Drawing.Color.White;
            this.lblNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumber1.Location = new System.Drawing.Point(89, 121);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(96, 72);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber2
            // 
            this.lblNumber2.BackColor = System.Drawing.Color.White;
            this.lblNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumber2.Location = new System.Drawing.Point(206, 121);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(97, 72);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber3
            // 
            this.lblNumber3.BackColor = System.Drawing.Color.White;
            this.lblNumber3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumber3.Location = new System.Drawing.Point(331, 121);
            this.lblNumber3.Name = "lblNumber3";
            this.lblNumber3.Size = new System.Drawing.Size(91, 72);
            this.lblNumber3.TabIndex = 2;
            this.lblNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber4
            // 
            this.lblNumber4.BackColor = System.Drawing.Color.White;
            this.lblNumber4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumber4.Location = new System.Drawing.Point(453, 121);
            this.lblNumber4.Name = "lblNumber4";
            this.lblNumber4.Size = new System.Drawing.Size(98, 72);
            this.lblNumber4.TabIndex = 3;
            this.lblNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber5
            // 
            this.lblNumber5.BackColor = System.Drawing.Color.White;
            this.lblNumber5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumber5.Location = new System.Drawing.Point(581, 121);
            this.lblNumber5.Name = "lblNumber5";
            this.lblNumber5.Size = new System.Drawing.Size(100, 72);
            this.lblNumber5.TabIndex = 4;
            this.lblNumber5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btnGenerate.Location = new System.Drawing.Point(98, 200);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(173, 62);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "產生號碼";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btnDraw.Location = new System.Drawing.Point(331, 200);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(173, 62);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "開獎號碼";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btnExit.Location = new System.Drawing.Point(552, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(218, 62);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBoxDrawNumbers
            // 
            this.listBoxDrawNumbers.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.listBoxDrawNumbers.FormattingEnabled = true;
            this.listBoxDrawNumbers.ItemHeight = 30;
            this.listBoxDrawNumbers.Location = new System.Drawing.Point(43, 268);
            this.listBoxDrawNumbers.Name = "listBoxDrawNumbers";
            this.listBoxDrawNumbers.Size = new System.Drawing.Size(334, 274);
            this.listBoxDrawNumbers.TabIndex = 8;
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblResultTitle.ForeColor = System.Drawing.Color.Red;
            this.lblResultTitle.Location = new System.Drawing.Point(398, 268);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(300, 40);
            this.lblResultTitle.TabIndex = 9;
            this.lblResultTitle.Text = "";
            this.lblResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResultTitle.Visible = false;
            // 
            // lblMatchCount
            // 
            this.lblMatchCount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblMatchCount.ForeColor = System.Drawing.Color.Red;
            this.lblMatchCount.Location = new System.Drawing.Point(398, 318);
            this.lblMatchCount.Name = "lblMatchCount";
            this.lblMatchCount.Size = new System.Drawing.Size(300, 40);
            this.lblMatchCount.TabIndex = 10;
            this.lblMatchCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMatchCount.Visible = false;
            // 
            // lblMatchedNumbers
            // 
            this.lblMatchedNumbers.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblMatchedNumbers.ForeColor = System.Drawing.Color.Red;
            this.lblMatchedNumbers.Location = new System.Drawing.Point(398, 368);
            this.lblMatchedNumbers.Name = "lblMatchedNumbers";
            this.lblMatchedNumbers.Size = new System.Drawing.Size(450, 40);
            this.lblMatchedNumbers.TabIndex = 11;
            this.lblMatchedNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMatchedNumbers.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 606);
            this.Controls.Add(this.lblMatchedNumbers);
            this.Controls.Add(this.lblMatchCount);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.listBoxDrawNumbers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblNumber5);
            this.Controls.Add(this.lblNumber4);
            this.Controls.Add(this.lblNumber3);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Name = "Form1";
            this.Text = "樂透號碼產生器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Label lblNumber4;
        private System.Windows.Forms.Label lblNumber5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxDrawNumbers;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblMatchCount;
        private System.Windows.Forms.Label lblMatchedNumbers;
    }
}

