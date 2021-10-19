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
    public partial class frmWeight : Form
    {
        public frmWeight()
        {
            InitializeComponent();
        }

        private void btnGrToKg_Click(object sender, EventArgs e)
        {
            double result = CalculateWeight.GrToKg(txtWeight.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnKgToGr_Click(object sender, EventArgs e)
        {
            double result = CalculateWeight.KgToGr(txtWeight.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnOunceToGr_Click(object sender, EventArgs e)
        {
            double result = CalculateWeight.OunceToGr(txtWeight.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnGrToOunce_Click(object sender, EventArgs e)
        {
            double result = CalculateWeight.GrToOunce(txtWeight.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnPoundToKg_Click(object sender, EventArgs e)
        {
            double result = CalculateWeight.PoundToKg(txtWeight.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnKgToPound_Click(object sender, EventArgs e)
        {
            double result = CalculateWeight.KgToPound(txtWeight.Value.ToString());
            txtResult.Text = result.ToString();
        }
    }
}
