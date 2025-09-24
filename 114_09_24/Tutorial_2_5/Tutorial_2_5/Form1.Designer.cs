namespace Tutorial_2_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cardbackPictureBox = new System.Windows.Forms.PictureBox();
            this.cardfacePictureBox = new System.Windows.Forms.PictureBox();
            this.showbackButton = new System.Windows.Forms.Button();
            this.showfaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardbackPictureBox
            // 
            this.cardbackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cardbackPictureBox.Image")));
            this.cardbackPictureBox.Location = new System.Drawing.Point(280, 30);
            this.cardbackPictureBox.Name = "cardbackPictureBox";
            this.cardbackPictureBox.Size = new System.Drawing.Size(252, 331);
            this.cardbackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbackPictureBox.TabIndex = 0;
            this.cardbackPictureBox.TabStop = false;
            // 
            // cardfacePictureBox
            // 
            this.cardfacePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cardfacePictureBox.Image")));
            this.cardfacePictureBox.Location = new System.Drawing.Point(280, 30);
            this.cardfacePictureBox.Name = "cardfacePictureBox";
            this.cardfacePictureBox.Size = new System.Drawing.Size(252, 331);
            this.cardfacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardfacePictureBox.TabIndex = 1;
            this.cardfacePictureBox.TabStop = false;
            this.cardfacePictureBox.Click += new System.EventHandler(this.cardfacePictureBox_Click);
            // 
            // showbackButton
            // 
            this.showbackButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showbackButton.Location = new System.Drawing.Point(136, 467);
            this.showbackButton.Name = "showbackButton";
            this.showbackButton.Size = new System.Drawing.Size(171, 70);
            this.showbackButton.TabIndex = 2;
            this.showbackButton.Text = "顯示背面";
            this.showbackButton.UseVisualStyleBackColor = true;
            this.showbackButton.Click += new System.EventHandler(this.showbackButton_Click);
            // 
            // showfaceButton
            // 
            this.showfaceButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showfaceButton.Location = new System.Drawing.Point(494, 467);
            this.showfaceButton.Name = "showfaceButton";
            this.showfaceButton.Size = new System.Drawing.Size(171, 70);
            this.showfaceButton.TabIndex = 3;
            this.showfaceButton.Text = "顯示正面";
            this.showfaceButton.UseVisualStyleBackColor = true;
            this.showfaceButton.Click += new System.EventHandler(this.showfaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.showfaceButton);
            this.Controls.Add(this.showbackButton);
            this.Controls.Add(this.cardfacePictureBox);
            this.Controls.Add(this.cardbackPictureBox);
            this.Name = "Form1";
            this.Text = "翻轉撲克牌";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardbackPictureBox;
        private System.Windows.Forms.PictureBox cardfacePictureBox;
        private System.Windows.Forms.Button showbackButton;
        private System.Windows.Forms.Button showfaceButton;
    }
}

