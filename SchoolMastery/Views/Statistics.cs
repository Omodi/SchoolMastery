﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolMastery.Model;

namespace WindowsFormsApplication1
{
    public partial class FormStatistics : Form
    {
        private Profile profile;
        public FormStatistics(Profile profile)
        {
            this.profile = profile;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormMainMenu newForm = new FormMainMenu(profile);
            this.Hide();
            newForm.ShowDialog();
        }
    }
}
