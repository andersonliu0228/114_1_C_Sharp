namespace Friend_File
{
    partial class Form1
    {
        /// <summary>
        /// 必需的設計器變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">若為 true，表示要釋放受控資源；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計器支援所需的方法 — 請勿使用程式碼編輯器修改此方法的內容。
        /// 變更說明：
        /// - 所有元件的 Text 屬性已確保為繁體中文。
        /// - 所有元件與表單字型大小皆設定為 18，以利一致性顯示。
        /// 註：除註解與指定的 Text / Font 屬性外，其他程式碼未做更動。
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.writeNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.promptLabel.Location = new System.Drawing.Point(12, 19);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(280, 45);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "輸入朋友的名字:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameTextBox.Location = new System.Drawing.Point(336, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(341, 55);
            this.nameTextBox.TabIndex = 1;
            // 
            // writeNameButton
            // 
            this.writeNameButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.writeNameButton.Location = new System.Drawing.Point(107, 114);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(219, 50);
            this.writeNameButton.TabIndex = 2;
            this.writeNameButton.Text = "寫下名字";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(376, 114);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(153, 50);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 578);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.promptLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "朋友檔案";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

