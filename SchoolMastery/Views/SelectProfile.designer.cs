namespace SchoolMastery.Views
{
    partial class FormSelectProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectProfile));
            this.exitButton = new System.Windows.Forms.Button();
            this.puppyPic = new System.Windows.Forms.PictureBox();
            this.plusPic = new System.Windows.Forms.PictureBox();
            this.puppySelected = new System.Windows.Forms.PictureBox();
            this.samLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newProfileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.puppyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppySelected)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 617);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 51);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // puppyPic
            // 
            this.puppyPic.Image = ((System.Drawing.Image)(resources.GetObject("puppyPic.Image")));
            this.puppyPic.Location = new System.Drawing.Point(271, 201);
            this.puppyPic.Name = "puppyPic";
            this.puppyPic.Size = new System.Drawing.Size(200, 200);
            this.puppyPic.TabIndex = 7;
            this.puppyPic.TabStop = false;
            this.puppyPic.Click += new System.EventHandler(this.puppyPic_Click);
            // 
            // plusPic
            // 
            this.plusPic.Image = ((System.Drawing.Image)(resources.GetObject("plusPic.Image")));
            this.plusPic.Location = new System.Drawing.Point(503, 201);
            this.plusPic.Name = "plusPic";
            this.plusPic.Size = new System.Drawing.Size(200, 200);
            this.plusPic.TabIndex = 8;
            this.plusPic.TabStop = false;
            this.plusPic.Click += new System.EventHandler(this.plusPic_Click);
            // 
            // puppySelected
            // 
            this.puppySelected.Image = ((System.Drawing.Image)(resources.GetObject("puppySelected.Image")));
            this.puppySelected.Location = new System.Drawing.Point(271, 201);
            this.puppySelected.Name = "puppySelected";
            this.puppySelected.Size = new System.Drawing.Size(200, 200);
            this.puppySelected.TabIndex = 12;
            this.puppySelected.TabStop = false;
            this.puppySelected.Click += new System.EventHandler(this.puppySelected_Click);
            // 
            // samLabel
            // 
            this.samLabel.AutoSize = true;
            this.samLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samLabel.Location = new System.Drawing.Point(356, 404);
            this.samLabel.Name = "samLabel";
            this.samLabel.Size = new System.Drawing.Size(42, 20);
            this.samLabel.TabIndex = 13;
            this.samLabel.Text = "Sam";
            this.samLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Grade 3";
            // 
            // newProfileLabel
            // 
            this.newProfileLabel.AutoSize = true;
            this.newProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProfileLabel.Location = new System.Drawing.Point(561, 404);
            this.newProfileLabel.Name = "newProfileLabel";
            this.newProfileLabel.Size = new System.Drawing.Size(88, 20);
            this.newProfileLabel.TabIndex = 15;
            this.newProfileLabel.Text = "New Profile";
            // 
            // FormSelectProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 680);
            this.Controls.Add(this.newProfileLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.samLabel);
            this.Controls.Add(this.puppySelected);
            this.Controls.Add(this.plusPic);
            this.Controls.Add(this.puppyPic);
            this.Controls.Add(this.exitButton);
            this.Name = "FormSelectProfile";
            this.Text = "Select Profile";
            ((System.ComponentModel.ISupportInitialize)(this.puppyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppySelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox puppyPic;
        private System.Windows.Forms.PictureBox plusPic;
        private System.Windows.Forms.PictureBox puppySelected;
        private System.Windows.Forms.Label samLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newProfileLabel;
    }
}

