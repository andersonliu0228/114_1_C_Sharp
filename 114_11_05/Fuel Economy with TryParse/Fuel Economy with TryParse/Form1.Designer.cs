namespace Fuel_Economy_with_TryParse
{
    partial class Form1
    {
        /// <summary>
        /// 必需的設計工具變數（由設計器管理）
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 釋放所使用的資源。 disposing 為 true 時釋放託管資源。
        /// </summary>
        /// <param name="disposing">如果為 true，則釋放託管與非託管資源；否則只釋放非託管資源。</param>
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
        /// 設計器所需的方法：初始化表單上的所有元件與屬性。
        /// 注意：此方法由設計器自動產生，勿手動修改名稱或結構以免與設計器同步失敗。
        /// 在此處我們已將所有顯示文字改為繁體中文，並將字型大小統一設為 18。
        /// 同時將所有單位由英制（英里、加侖）改為公制（公里、公升）。
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(508, 412);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(262, 108);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(224, 412);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(262, 108);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "計算 km/L";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpgLabel.Location = new System.Drawing.Point(542, 243);
            this.mpgLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(340, 67);
            this.mpgLabel.TabIndex = 13;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(1, 256);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(485, 40);
            this.outputDescriptionLabel.TabIndex = 12;
            this.outputDescriptionLabel.Text = "您車輛每公升可行駛公里數：";
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsTextBox.Location = new System.Drawing.Point(542, 129);
            this.gallonsTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(340, 48);
            this.gallonsTextBox.TabIndex = 11;
            // 
            // milesTextBox
            // 
            this.milesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesTextBox.Location = new System.Drawing.Point(542, 51);
            this.milesTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(340, 48);
            this.milesTextBox.TabIndex = 10;
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.AutoSize = true;
            this.gallonsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsPromptLabel.Location = new System.Drawing.Point(74, 132);
            this.gallonsPromptLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(413, 40);
            this.gallonsPromptLabel.TabIndex = 9;
            this.gallonsPromptLabel.Text = "輸入使用的汽油公升數：";
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.AutoSize = true;
            this.milesPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesPromptLabel.Location = new System.Drawing.Point(145, 54);
            this.milesPromptLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(341, 40);
            this.milesPromptLabel.TabIndex = 8;
            this.milesPromptLabel.Text = "輸入行駛的公里數：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 557);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "油耗（公制）計算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.Label milesPromptLabel;
    }
}

