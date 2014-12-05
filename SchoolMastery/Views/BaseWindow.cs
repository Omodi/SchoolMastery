using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMastery.Views
{
    public partial class BaseWindow : Form
    {
        BaseWindow baseWindow;
        public BaseWindow()
        {
            InitializeComponent();
            baseWindow = this;
            FormSelectProfile selectProfile = new FormSelectProfile(this);
            changeUserControl(selectProfile, "SchoolMastery - Select Profile");
        }
        public void changeUserControl(UserControl us, string name){
            us.BackColor = System.Drawing.SystemColors.Window;
            us.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            us.Location = new System.Drawing.Point(-1, 0);
            this.Name = name;
            us.Size = new System.Drawing.Size(964, 680);
            us.Dock = DockStyle.Fill;
            Controls.Add(us);
        }
    }
}
