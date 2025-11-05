namespace CheckBoxDemo
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
            this.PizzaGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PizzaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PizzaGroupBox
            // 
            this.PizzaGroupBox.Controls.Add(this.checkBox4);
            this.PizzaGroupBox.Controls.Add(this.checkBox3);
            this.PizzaGroupBox.Controls.Add(this.checkBox2);
            this.PizzaGroupBox.Controls.Add(this.checkBox1);
            this.PizzaGroupBox.Location = new System.Drawing.Point(189, 32);
            this.PizzaGroupBox.Name = "PizzaGroupBox";
            this.PizzaGroupBox.Size = new System.Drawing.Size(305, 361);
            this.PizzaGroupBox.TabIndex = 0;
            this.PizzaGroupBox.TabStop = false;
            this.PizzaGroupBox.Text = "Pizza口味";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("新細明體", 18F);
            this.checkBox4.Location = new System.Drawing.Point(46, 246);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(185, 40);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "義式火腿";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("新細明體", 18F);
            this.checkBox3.Location = new System.Drawing.Point(46, 165);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(185, 40);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "綜合海鮮";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("新細明體", 18F);
            this.checkBox2.Location = new System.Drawing.Point(46, 96);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 40);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "章魚燒";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("新細明體", 18F);
            this.checkBox1.Location = new System.Drawing.Point(46, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 40);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "夏威夷";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 18F);
            this.button1.Location = new System.Drawing.Point(235, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PizzaGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PizzaGroupBox.ResumeLayout(false);
            this.PizzaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PizzaGroupBox;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}

