namespace SchoolMastery.Views
{
    partial class FormStatistics
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
            this.returnButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.averageTestLabel = new System.Windows.Forms.Label();
            this.graphPic = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.OverallTab = new System.Windows.Forms.TabPage();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphPic)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 617);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(150, 51);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.highScoreLabel);
            this.tabPage1.Controls.Add(this.averageTestLabel);
            this.tabPage1.Controls.Add(this.graphPic);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Math";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Further study: Addition";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.Location = new System.Drawing.Point(139, 446);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(156, 26);
            this.highScoreLabel.TabIndex = 9;
            this.highScoreLabel.Text = "High Score: 92";
            // 
            // averageTestLabel
            // 
            this.averageTestLabel.AutoSize = true;
            this.averageTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTestLabel.Location = new System.Drawing.Point(139, 403);
            this.averageTestLabel.Name = "averageTestLabel";
            this.averageTestLabel.Size = new System.Drawing.Size(239, 26);
            this.averageTestLabel.TabIndex = 8;
            this.averageTestLabel.Text = "Average Test Score: 72";
            // 
            // graphPic
            // 
            this.graphPic.BackColor = System.Drawing.Color.White;
            this.graphPic.Image = global::SchoolMastery.Properties.Resources.graphPic_Image;
            this.graphPic.Location = new System.Drawing.Point(205, 66);
            this.graphPic.Name = "graphPic";
            this.graphPic.Size = new System.Drawing.Size(484, 316);
            this.graphPic.TabIndex = 7;
            this.graphPic.TabStop = false;
            this.graphPic.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.historyTab);
            this.tabControl1.Controls.Add(this.OverallTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 601);
            this.tabControl1.TabIndex = 17;
            // 
            // historyTab
            // 
            this.historyTab.Location = new System.Drawing.Point(4, 22);
            this.historyTab.Name = "historyTab";
            this.historyTab.Size = new System.Drawing.Size(917, 575);
            this.historyTab.TabIndex = 1;
            this.historyTab.Text = "History";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // OverallTab
            // 
            this.OverallTab.Location = new System.Drawing.Point(4, 22);
            this.OverallTab.Name = "OverallTab";
            this.OverallTab.Size = new System.Drawing.Size(917, 575);
            this.OverallTab.TabIndex = 2;
            this.OverallTab.Text = "Overall";
            this.OverallTab.UseVisualStyleBackColor = true;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.returnButton);
            this.Name = "FormStatistics";
            this.Size = new System.Drawing.Size(964, 680);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphPic)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label averageTestLabel;
        private System.Windows.Forms.PictureBox graphPic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.TabPage OverallTab;
    }
}

