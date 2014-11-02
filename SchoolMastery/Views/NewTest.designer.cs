namespace WindowsFormsApplication1
{
    partial class FormNewTest
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.TextBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxTest = new System.Windows.Forms.ComboBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(787, 617);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 51);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Return";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Question
            // 
            this.Question.AcceptsReturn = true;
            this.Question.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Question.Enabled = false;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(20, 12);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Size = new System.Drawing.Size(925, 599);
            this.Question.TabIndex = 6;
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(20, 617);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(150, 51);
            this.startbutton.TabIndex = 10;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(59, 48);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(85, 26);
            this.subjectLabel.TabIndex = 11;
            this.subjectLabel.Text = "Subject";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(85, 77);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(192, 21);
            this.comboBoxSubject.TabIndex = 12;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // comboBoxTest
            // 
            this.comboBoxTest.FormattingEnabled = true;
            this.comboBoxTest.Location = new System.Drawing.Point(85, 202);
            this.comboBoxTest.Name = "comboBoxTest";
            this.comboBoxTest.Size = new System.Drawing.Size(192, 21);
            this.comboBoxTest.TabIndex = 13;
            this.comboBoxTest.SelectedIndexChanged += new System.EventHandler(this.comboBoxTest_SelectedIndexChanged);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTest.Location = new System.Drawing.Point(59, 164);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(53, 26);
            this.labelTest.TabIndex = 15;
            this.labelTest.Text = "Test";
            // 
            // FormNewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 680);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.comboBoxTest);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.cancelButton);
            this.Name = "FormNewTest";
            this.Text = "New Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxTest;
        private System.Windows.Forms.Label labelTest;
    }
}

