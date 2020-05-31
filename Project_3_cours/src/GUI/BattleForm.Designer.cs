namespace Project_3_cours.src.GUI
{
    partial class BattleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plMpLabel = new System.Windows.Forms.Label();
            this.plHpLabel = new System.Windows.Forms.Label();
            this.enHpLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_3_cours.Properties.Resources.NotFound;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(90, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 199);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // enNameLabel
            // 
            this.enNameLabel.AutoSize = true;
            this.enNameLabel.Font = new System.Drawing.Font("Modern No. 20", 36F);
            this.enNameLabel.Location = new System.Drawing.Point(81, 13);
            this.enNameLabel.Name = "enNameLabel";
            this.enNameLabel.Size = new System.Drawing.Size(138, 50);
            this.enNameLabel.TabIndex = 1;
            this.enNameLabel.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(90, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 197);
            this.panel1.TabIndex = 2;
            // 
            // plMpLabel
            // 
            this.plMpLabel.AutoSize = true;
            this.plMpLabel.Font = new System.Drawing.Font("Modern No. 20", 36F);
            this.plMpLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.plMpLabel.Location = new System.Drawing.Point(81, 306);
            this.plMpLabel.Name = "plMpLabel";
            this.plMpLabel.Size = new System.Drawing.Size(138, 50);
            this.plMpLabel.TabIndex = 3;
            this.plMpLabel.Text = "label1";
            // 
            // plHpLabel
            // 
            this.plHpLabel.AutoSize = true;
            this.plHpLabel.Font = new System.Drawing.Font("Modern No. 20", 36F);
            this.plHpLabel.ForeColor = System.Drawing.Color.Red;
            this.plHpLabel.Location = new System.Drawing.Point(629, 306);
            this.plHpLabel.Name = "plHpLabel";
            this.plHpLabel.Size = new System.Drawing.Size(138, 50);
            this.plHpLabel.TabIndex = 4;
            this.plHpLabel.Text = "label2";
            this.plHpLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // enHpLabel
            // 
            this.enHpLabel.AutoSize = true;
            this.enHpLabel.Font = new System.Drawing.Font("Modern No. 20", 36F);
            this.enHpLabel.ForeColor = System.Drawing.Color.Red;
            this.enHpLabel.Location = new System.Drawing.Point(629, 13);
            this.enHpLabel.Name = "enHpLabel";
            this.enHpLabel.Size = new System.Drawing.Size(138, 50);
            this.enHpLabel.TabIndex = 5;
            this.enHpLabel.Text = "label2";
            this.enHpLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 36F);
            this.button1.Location = new System.Drawing.Point(589, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 136);
            this.button1.TabIndex = 6;
            this.button1.Text = "End Turn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enHpLabel);
            this.Controls.Add(this.plHpLabel);
            this.Controls.Add(this.plMpLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.enNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BattleForm";
            this.Text = "BattleForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label enNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label plMpLabel;
        private System.Windows.Forms.Label plHpLabel;
        private System.Windows.Forms.Label enHpLabel;
        private System.Windows.Forms.Button button1;
    }
}