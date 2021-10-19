using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Convertor_WinForm.Services;

namespace Convertor_WinForm
{
    public partial class frmVolume : Form
    {
        public frmVolume()
        {
            InitializeComponent();
        }

        private void btnLitreToPint_Click(object sender, EventArgs e)
        {
            double result = CalculateVolume.LitreToPint(txtVolume.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnPintToLitre_Click(object sender, EventArgs e)
        {
            double result = CalculateVolume.PintToLitre(txtVolume.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnLitreToGallon_Click(object sender, EventArgs e)
        {
            double result = CalculateVolume.LitreToGallon(txtVolume.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnGallonToLitre_Click(object sender, EventArgs e)
        {
            double result = CalculateVolume.GallonToLitre(txtVolume.Value.ToString());
            txtResult.Text = result.ToString();
        }
    }
}
