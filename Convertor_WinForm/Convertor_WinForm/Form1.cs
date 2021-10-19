using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCopyRight.Text = "© 2021 Convertor, Inc. All rights reserved";
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            frmLength frmLength = new frmLength();
            frmLength.ShowDialog();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            frmArea frmArea = new frmArea();
            frmArea.ShowDialog();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            frmVolume frmVolume = new frmVolume();
            frmVolume.ShowDialog();
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            frmWeight frmWeight = new frmWeight();
            frmWeight.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }
    }
}
