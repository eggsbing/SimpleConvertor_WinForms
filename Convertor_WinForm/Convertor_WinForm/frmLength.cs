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
using Convertor_WinForm.Utilities;

namespace Convertor_WinForm
{
    public partial class frmLength : Form
    {
        public frmLength()
        {
            InitializeComponent();
        }

        private void btnInchToCm_Click(object sender, EventArgs e)
        {
            double result = CalculateLength.InchToCm(txtLength.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnCmToInch_Click(object sender, EventArgs e)
        {
            double result = CalculateLength.CmToInch(txtLength.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnYardToMeter_Click(object sender, EventArgs e)
        {
            double result = CalculateLength.YardToMeter(txtLength.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnMeterToYard_Click(object sender, EventArgs e)
        {
            double result = CalculateLength.MeterToYard(txtLength.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnMileToKm_Click(object sender, EventArgs e)
        {
            double result = CalculateLength.MileToKm(txtLength.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnKmToMile_Click(object sender, EventArgs e)
        {
            double result = CalculateLength.KmToMile(txtLength.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void frmLength_Load(object sender, EventArgs e)
        {

        }
    }
}
