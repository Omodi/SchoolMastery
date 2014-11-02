using System;
namespace WindowsFormsApplication1
{
    partial class FormCreateProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateProfile));
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.kittyPic = new System.Windows.Forms.PictureBox();
            this.puppyPic = new System.Windows.Forms.PictureBox();
            this.cowPic = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.animalLabel = new System.Windows.Forms.Label();
            this.gradeDropDown = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.blueBackground = new System.Windows.Forms.TextBox();
            this.selectionIndicator = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kittyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 617);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(150, 51);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(787, 617);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 51);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // kittyPic
            // 
            this.kittyPic.Image = ((System.Drawing.Image)(resources.GetObject("kittyPic.Image")));
            this.kittyPic.Location = new System.Drawing.Point(384, 297);
            this.kittyPic.Name = "kittyPic";
            this.kittyPic.Size = new System.Drawing.Size(200, 200);
            this.kittyPic.TabIndex = 7;
            this.kittyPic.TabStop = false;
            this.kittyPic.Click += new System.EventHandler(this.kittyPic_Click);
            // 
            // puppyPic
            // 
            this.puppyPic.Image = ((System.Drawing.Image)(resources.GetObject("puppyPic.Image")));
            this.puppyPic.Location = new System.Drawing.Point(162, 297);
            this.puppyPic.Name = "puppyPic";
            this.puppyPic.Size = new System.Drawing.Size(200, 200);
            this.puppyPic.TabIndex = 8;
            this.puppyPic.TabStop = false;
            this.puppyPic.Click += new System.EventHandler(this.puppyPic_Click);
            // 
            // cowPic
            // 
            this.cowPic.Image = ((System.Drawing.Image)(resources.GetObject("cowPic.Image")));
            this.cowPic.Location = new System.Drawing.Point(611, 297);
            this.cowPic.Name = "cowPic";
            this.cowPic.Size = new System.Drawing.Size(200, 200);
            this.cowPic.TabIndex = 9;
            this.cowPic.TabStop = false;
            this.cowPic.Click += new System.EventHandler(this.cowPic_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(238, 111);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 25);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(238, 155);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(72, 25);
            this.gradeLabel.TabIndex = 11;
            this.gradeLabel.Text = "Grade:";
            this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // animalLabel
            // 
            this.animalLabel.AutoSize = true;
            this.animalLabel.BackColor = System.Drawing.SystemColors.Window;
            this.animalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalLabel.Location = new System.Drawing.Point(238, 229);
            this.animalLabel.Name = "animalLabel";
            this.animalLabel.Size = new System.Drawing.Size(78, 25);
            this.animalLabel.TabIndex = 12;
            this.animalLabel.Text = "Animal:";
            this.animalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradeDropDown
            // 
            this.gradeDropDown.AutoCompleteCustomSource.AddRange(new string[] {
            "Kindergarten",
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6",
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10",
            "Grade 11",
            "Grade 12"});
            this.gradeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeDropDown.FormattingEnabled = true;
            this.gradeDropDown.Items.AddRange(new object[] {
            "Kindergarten",
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6",
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10",
            "Grade 11",
            "Grade 12"});
            this.gradeDropDown.Location = new System.Drawing.Point(332, 159);
            this.gradeDropDown.Name = "gradeDropDown";
            this.gradeDropDown.Size = new System.Drawing.Size(121, 21);
            this.gradeDropDown.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(332, 117);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // blueBackground
            // 
            this.blueBackground.AcceptsReturn = true;
            this.blueBackground.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.blueBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueBackground.Location = new System.Drawing.Point(12, 12);
            this.blueBackground.Multiline = true;
            this.blueBackground.Name = "blueBackground";
            this.blueBackground.ReadOnly = true;
            this.blueBackground.Size = new System.Drawing.Size(925, 588);
            this.blueBackground.TabIndex = 15;
            // 
            // selectionIndicator
            // 
            this.selectionIndicator.AcceptsReturn = true;
            this.selectionIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.selectionIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionIndicator.Location = new System.Drawing.Point(152, 287);
            this.selectionIndicator.Multiline = true;
            this.selectionIndicator.Name = "selectionIndicator";
            this.selectionIndicator.ReadOnly = true;
            this.selectionIndicator.Size = new System.Drawing.Size(220, 220);
            this.selectionIndicator.TabIndex = 16;
            // 
            // FormCreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 680);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.gradeDropDown);
            this.Controls.Add(this.animalLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cowPic);
            this.Controls.Add(this.puppyPic);
            this.Controls.Add(this.kittyPic);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.selectionIndicator);
            this.Name = "FormCreateProfile";
            this.Text = "Create Profile";
            ((System.ComponentModel.ISupportInitialize)(this.kittyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox kittyPic;
        private System.Windows.Forms.PictureBox puppyPic;
        private System.Windows.Forms.PictureBox cowPic;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label animalLabel;
        private System.Windows.Forms.ComboBox gradeDropDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox blueBackground;
        private System.Windows.Forms.TextBox selectionIndicator;
    }
}

