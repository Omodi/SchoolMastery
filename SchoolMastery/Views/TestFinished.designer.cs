namespace WindowsFormsApplication1
{
    partial class FormTestFinished
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestFinished));
            this.returnButton = new System.Windows.Forms.Button();
            this.congratsLabel = new System.Windows.Forms.Label();
            this.fireWorksPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fireWorksPic)).BeginInit();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(20, 617);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(150, 51);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // congratsLabel
            // 
            this.congratsLabel.AutoSize = true;
            this.congratsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.congratsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel.Location = new System.Drawing.Point(353, 235);
            this.congratsLabel.Name = "congratsLabel";
            this.congratsLabel.Size = new System.Drawing.Size(265, 156);
            this.congratsLabel.TabIndex = 7;
            this.congratsLabel.Text = "Congratulations!\r\nYou passed!\r\n\r\nScore: 75";
            this.congratsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fireWorksPic
            // 
            this.fireWorksPic.Image = ((System.Drawing.Image)(resources.GetObject("fireWorksPic.Image")));
            this.fireWorksPic.Location = new System.Drawing.Point(146, 86);
            this.fireWorksPic.Name = "fireWorksPic";
            this.fireWorksPic.Size = new System.Drawing.Size(749, 542);
            this.fireWorksPic.TabIndex = 8;
            this.fireWorksPic.TabStop = false;
            // 
            // FormTestFinished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 680);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.congratsLabel);
            this.Controls.Add(this.fireWorksPic);
            this.Name = "FormTestFinished";
            this.Text = "Test Finished";
            ((System.ComponentModel.ISupportInitialize)(this.fireWorksPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label congratsLabel;
        private System.Windows.Forms.PictureBox fireWorksPic;
    }
}

