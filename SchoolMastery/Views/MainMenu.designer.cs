using SchoolMastery.Model;
namespace WindowsFormsApplication1
{
    partial class FormMainMenu
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
        private void InitializeComponent(Profile profile)
        {
            this.returnButton = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.startNewTestButton = new System.Windows.Forms.Button();
            this.loadTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(787, 617);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(150, 51);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Exit";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Question
            // 
            this.Question.AcceptsReturn = true;
            this.Question.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(20, 12);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Size = new System.Drawing.Size(925, 599);
            this.Question.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(189, 94);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 25);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = this.profile.getName();
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(189, 133);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(82, 25);
            this.gradeLabel.TabIndex = 8;
            this.gradeLabel.Text = "Grade: " + this.profile.getGradeLevel();
            // 
            // statisticsButton
            // 
            this.statisticsButton.Location = new System.Drawing.Point(774, 34);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(150, 51);
            this.statisticsButton.TabIndex = 9;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // startNewTestButton
            // 
            this.startNewTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNewTestButton.Location = new System.Drawing.Point(327, 225);
            this.startNewTestButton.Name = "startNewTestButton";
            this.startNewTestButton.Size = new System.Drawing.Size(323, 103);
            this.startNewTestButton.TabIndex = 10;
            this.startNewTestButton.Text = "Start New Test";
            this.startNewTestButton.UseVisualStyleBackColor = true;
            this.startNewTestButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadTestButton
            // 
            this.loadTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTestButton.Location = new System.Drawing.Point(327, 354);
            this.loadTestButton.Name = "loadTestButton";
            this.loadTestButton.Size = new System.Drawing.Size(323, 103);
            this.loadTestButton.TabIndex = 11;
            this.loadTestButton.Text = "Load Saved Test";
            this.loadTestButton.UseVisualStyleBackColor = true;
            this.loadTestButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 680);
            this.Controls.Add(this.loadTestButton);
            this.Controls.Add(this.startNewTestButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.returnButton);
            this.Name = "FormMainMenu";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button startNewTestButton;
        private System.Windows.Forms.Button loadTestButton;
    }
}

