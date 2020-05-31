namespace Project_3_cours.src.GUI
{
    partial class EventForm
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
            this.descLabel = new System.Windows.Forms.Label();
            this.optionLabel1 = new System.Windows.Forms.LinkLabel();
            this.optionLabel2 = new System.Windows.Forms.LinkLabel();
            this.IndicatorProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_3_cours.Properties.Resources.NotFound;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.BackColor = System.Drawing.Color.Transparent;
            this.descLabel.Font = new System.Drawing.Font("Modern No. 20", 36F);
            this.descLabel.Location = new System.Drawing.Point(391, 133);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(138, 50);
            this.descLabel.TabIndex = 1;
            this.descLabel.Text = "label1";
            // 
            // optionLabel1
            // 
            this.optionLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.optionLabel1.AutoSize = true;
            this.optionLabel1.BackColor = System.Drawing.Color.Transparent;
            this.optionLabel1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel1.ForeColor = System.Drawing.Color.Black;
            this.optionLabel1.LinkColor = System.Drawing.Color.Black;
            this.optionLabel1.Location = new System.Drawing.Point(400, 339);
            this.optionLabel1.Name = "optionLabel1";
            this.optionLabel1.Size = new System.Drawing.Size(172, 36);
            this.optionLabel1.TabIndex = 2;
            this.optionLabel1.TabStop = true;
            this.optionLabel1.Text = "linkLabel1";
            this.optionLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.optionLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.optionLabel1_LinkClicked);
            this.optionLabel1.MouseLeave += new System.EventHandler(this.optionLabel1_MouseLeave);
            this.optionLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.optionLabel1_MouseMove);
            // 
            // optionLabel2
            // 
            this.optionLabel2.ActiveLinkColor = System.Drawing.Color.Black;
            this.optionLabel2.AutoSize = true;
            this.optionLabel2.BackColor = System.Drawing.Color.Transparent;
            this.optionLabel2.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel2.LinkColor = System.Drawing.Color.Black;
            this.optionLabel2.Location = new System.Drawing.Point(400, 447);
            this.optionLabel2.Name = "optionLabel2";
            this.optionLabel2.Size = new System.Drawing.Size(172, 36);
            this.optionLabel2.TabIndex = 3;
            this.optionLabel2.TabStop = true;
            this.optionLabel2.Text = "linkLabel2";
            this.optionLabel2.VisitedLinkColor = System.Drawing.Color.Black;
            this.optionLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.optionLabel2_LinkClicked);
            this.optionLabel2.MouseLeave += new System.EventHandler(this.optionLabel1_MouseLeave);
            this.optionLabel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.optionLabel1_MouseMove);
            // 
            // IndicatorProgress
            // 
            this.IndicatorProgress.Enabled = false;
            this.IndicatorProgress.Location = new System.Drawing.Point(684, 12);
            this.IndicatorProgress.MarqueeAnimationSpeed = 1;
            this.IndicatorProgress.Name = "IndicatorProgress";
            this.IndicatorProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IndicatorProgress.Size = new System.Drawing.Size(151, 23);
            this.IndicatorProgress.Step = -100;
            this.IndicatorProgress.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Indicator";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IndicatorProgress);
            this.Controls.Add(this.optionLabel2);
            this.Controls.Add(this.optionLabel1);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EventForm";
            this.Text = "EventForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.LinkLabel optionLabel1;
        private System.Windows.Forms.LinkLabel optionLabel2;
        private System.Windows.Forms.ProgressBar IndicatorProgress;
        private System.Windows.Forms.Label label1;
    }
}