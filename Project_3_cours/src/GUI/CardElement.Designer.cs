namespace Project_3_cours.src.GUI
{
    partial class CardElement
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardNameLabel = new System.Windows.Forms.Label();
            this.cardImgBox = new System.Windows.Forms.PictureBox();
            this.descCardBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardNameLabel
            // 
            this.cardNameLabel.AutoSize = true;
            this.cardNameLabel.Enabled = false;
            this.cardNameLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNameLabel.Location = new System.Drawing.Point(6, 0);
            this.cardNameLabel.Name = "cardNameLabel";
            this.cardNameLabel.Size = new System.Drawing.Size(46, 18);
            this.cardNameLabel.TabIndex = 0;
            this.cardNameLabel.Text = "label1";
            // 
            // cardImgBox
            // 
            this.cardImgBox.BackgroundImage = global::Project_3_cours.Properties.Resources.NotFound;
            this.cardImgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardImgBox.Enabled = false;
            this.cardImgBox.Location = new System.Drawing.Point(9, 21);
            this.cardImgBox.Name = "cardImgBox";
            this.cardImgBox.Size = new System.Drawing.Size(42, 30);
            this.cardImgBox.TabIndex = 1;
            this.cardImgBox.TabStop = false;
            // 
            // descCardBox
            // 
            this.descCardBox.Enabled = false;
            this.descCardBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descCardBox.Location = new System.Drawing.Point(9, 57);
            this.descCardBox.Multiline = true;
            this.descCardBox.Name = "descCardBox";
            this.descCardBox.Size = new System.Drawing.Size(42, 32);
            this.descCardBox.TabIndex = 2;
            // 
            // CardElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descCardBox);
            this.Controls.Add(this.cardImgBox);
            this.Controls.Add(this.cardNameLabel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CardElement";
            this.Size = new System.Drawing.Size(61, 98);
            this.Click += new System.EventHandler(this.CardElement_Click);
            ((System.ComponentModel.ISupportInitialize)(this.cardImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cardNameLabel;
        private System.Windows.Forms.PictureBox cardImgBox;
        private System.Windows.Forms.TextBox descCardBox;
    }
}
