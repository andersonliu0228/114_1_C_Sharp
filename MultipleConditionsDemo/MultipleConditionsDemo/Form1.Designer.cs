namespace MultipleConditionsDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // 宣告三個原先的 Windows Form 控制項：Label、TextBox、Button
        private System.Windows.Forms.Label gradelabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button judgebutton;

        // 新增一個 Label 用來顯示成績等級，需有 3D 外框（BorderStyle.Fixed3D）
        private System.Windows.Forms.Label label2;

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
        /// 這個方法的內容。此處會初始化所有表單控制項屬性 (位置、大小、字型、文字等)。
        /// 要點：
        /// - 將所有文字相關控制項的字型統一設為 22pt（題目要求）。
        /// - 新增 label2 用來顯示等級結果，使用 Fixed3D 外框，並以固定大小顯示等級文字。
        /// </summary>
        private void InitializeComponent()
        {
            this.gradelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.judgebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gradelabel
            // 
            this.gradelabel.AutoSize = true;
            this.gradelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gradelabel.Location = new System.Drawing.Point(12, 12);
            this.gradelabel.Name = "gradelabel";
            this.gradelabel.Size = new System.Drawing.Size(122, 52);
            this.gradelabel.TabIndex = 0;
            this.gradelabel.Text = "成績:";
            this.gradelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(130, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 57);
            this.textBox1.TabIndex = 1;
            // 
            // judgebutton
            // 
            this.judgebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.judgebutton.Location = new System.Drawing.Point(21, 238);
            this.judgebutton.Name = "judgebutton";
            this.judgebutton.Size = new System.Drawing.Size(220, 66);
            this.judgebutton.TabIndex = 2;
            this.judgebutton.Text = "等級判斷";
            this.judgebutton.UseVisualStyleBackColor = true;
            this.judgebutton.Click += new System.EventHandler(this.judgebutton_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(130, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 46);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "等級:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.judgebutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gradelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
    }
}

