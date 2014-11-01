namespace WindowsFormsApplication1
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
            this.selectButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.puppyPic = new System.Windows.Forms.PictureBox();
            this.plusPic = new System.Windows.Forms.PictureBox();
            this.sameTextBox = new System.Windows.Forms.TextBox();
            this.grade3TextBox = new System.Windows.Forms.TextBox();
            this.createNewProfileTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.puppyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPic)).BeginInit();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(12, 617);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(150, 51);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(787, 617);
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
            // sameTextBox
            // 
            this.sameTextBox.Location = new System.Drawing.Point(325, 407);
            this.sameTextBox.Name = "sameTextBox";
            this.sameTextBox.Size = new System.Drawing.Size(100, 20);
            this.sameTextBox.TabIndex = 9;
            this.sameTextBox.Text = "Sam";
            this.sameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grade3TextBox
            // 
            this.grade3TextBox.Location = new System.Drawing.Point(325, 433);
            this.grade3TextBox.Name = "grade3TextBox";
            this.grade3TextBox.Size = new System.Drawing.Size(100, 20);
            this.grade3TextBox.TabIndex = 10;
            this.grade3TextBox.Text = "Grade 3";
            this.grade3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createNewProfileTextBox
            // 
            this.createNewProfileTextBox.Location = new System.Drawing.Point(556, 407);
            this.createNewProfileTextBox.Name = "createNewProfileTextBox";
            this.createNewProfileTextBox.Size = new System.Drawing.Size(100, 20);
            this.createNewProfileTextBox.TabIndex = 11;
            this.createNewProfileTextBox.Text = "Create New Profile";
            this.createNewProfileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.createNewProfileTextBox.TextChanged += new System.EventHandler(this.createNewProfileTextBox_TextChanged);
            // 
            // FormSelectProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 680);
            this.Controls.Add(this.createNewProfileTextBox);
            this.Controls.Add(this.grade3TextBox);
            this.Controls.Add(this.sameTextBox);
            this.Controls.Add(this.plusPic);
            this.Controls.Add(this.puppyPic);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectButton);
            this.Name = "FormSelectProfile";
            this.Text = "Select Profile";
            ((System.ComponentModel.ISupportInitialize)(this.puppyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox puppyPic;
        private System.Windows.Forms.PictureBox plusPic;
        private System.Windows.Forms.TextBox sameTextBox;
        private System.Windows.Forms.TextBox grade3TextBox;
        private System.Windows.Forms.TextBox createNewProfileTextBox;
    }
}

