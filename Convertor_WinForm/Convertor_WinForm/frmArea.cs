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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnInchToCm2_Click(object sender, EventArgs e)
        {
            double result = CalculateArea.InchToCm2(txtArea.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnCmToInch2_Click(object sender, EventArgs e)
        {
            double result = CalculateArea.CmToInch2(txtArea.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnYardToMeter2_Click(object sender, EventArgs e)
        {
            double result = CalculateArea.YardToMeter2(txtArea.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnMeterToYard2_Click(object sender, EventArgs e)
        {
            double result = CalculateArea.MeterToYard2(txtArea.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnMileToKm2_Click(object sender, EventArgs e)
        {
            double result = CalculateArea.MileToKm2(txtArea.Value.ToString());
            txtResult.Text = result.ToString();
        }

        private void btnKmToMile2_Click(object sender, EventArgs e)
        {
            double result = CalculateArea.KmToMile2(txtArea.Value.ToString());
            txtResult.Text = result.ToString();
        }
    }
}
