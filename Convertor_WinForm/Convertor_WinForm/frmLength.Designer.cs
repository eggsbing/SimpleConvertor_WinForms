
namespace Convertor_WinForm
{
    partial class frmLength
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInchToCm = new System.Windows.Forms.Button();
            this.btnCmToInch = new System.Windows.Forms.Button();
            this.btnYardToMeter = new System.Windows.Forms.Button();
            this.btnMeterToYard = new System.Windows.Forms.Button();
            this.btnMileToKm = new System.Windows.Forms.Button();
            this.btnKmToMile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "please enter your number :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Length";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInchToCm
            // 
            this.btnInchToCm.Location = new System.Drawing.Point(66, 155);
            this.btnInchToCm.Name = "btnInchToCm";
            this.btnInchToCm.Size = new System.Drawing.Size(185, 29);
            this.btnInchToCm.TabIndex = 3;
            this.btnInchToCm.Text = "Inch -> Cm";
            this.btnInchToCm.UseVisualStyleBackColor = true;
            this.btnInchToCm.Click += new System.EventHandler(this.btnInchToCm_Click);
            // 
            // btnCmToInch
            // 
            this.btnCmToInch.Location = new System.Drawing.Point(257, 155);
            this.btnCmToInch.Name = "btnCmToInch";
            this.btnCmToInch.Size = new System.Drawing.Size(185, 29);
            this.btnCmToInch.TabIndex = 4;
            this.btnCmToInch.Text = "Cm -> Inch";
            this.btnCmToInch.UseVisualStyleBackColor = true;
            this.btnCmToInch.Click += new System.EventHandler(this.btnCmToInch_Click);
            // 
            // btnYardToMeter
            // 
            this.btnYardToMeter.Location = new System.Drawing.Point(66, 190);
            this.btnYardToMeter.Name = "btnYardToMeter";
            this.btnYardToMeter.Size = new System.Drawing.Size(185, 29);
            this.btnYardToMeter.TabIndex = 5;
            this.btnYardToMeter.Text = "Yard -> Meter";
            this.btnYardToMeter.UseVisualStyleBackColor = true;
            this.btnYardToMeter.Click += new System.EventHandler(this.btnYardToMeter_Click);
            // 
            // btnMeterToYard
            // 
            this.btnMeterToYard.Location = new System.Drawing.Point(257, 190);
            this.btnMeterToYard.Name = "btnMeterToYard";
            this.btnMeterToYard.Size = new System.Drawing.Size(185, 29);
            this.btnMeterToYard.TabIndex = 6;
            this.btnMeterToYard.Text = "Meter -> Yard";
            this.btnMeterToYard.UseVisualStyleBackColor = true;
            this.btnMeterToYard.Click += new System.EventHandler(this.btnMeterToYard_Click);
            // 
            // btnMileToKm
            // 
            this.btnMileToKm.Location = new System.Drawing.Point(66, 225);
            this.btnMileToKm.Name = "btnMileToKm";
            this.btnMileToKm.Size = new System.Drawing.Size(185, 29);
            this.btnMileToKm.TabIndex = 7;
            this.btnMileToKm.Text = "Mile -> Km";
            this.btnMileToKm.UseVisualStyleBackColor = true;
            this.btnMileToKm.Click += new System.EventHandler(this.btnMileToKm_Click);
            // 
            // btnKmToMile
            // 
            this.btnKmToMile.Location = new System.Drawing.Point(257, 225);
            this.btnKmToMile.Name = "btnKmToMile";
            this.btnKmToMile.Size = new System.Drawing.Size(185, 29);
            this.btnKmToMile.TabIndex = 8;
            this.btnKmToMile.Text = "Km -> Mile";
            this.btnKmToMile.UseVisualStyleBackColor = true;
            this.btnKmToMile.Click += new System.EventHandler(this.btnKmToMile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Your result is :";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(136, 336);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(247, 27);
            this.txtResult.TabIndex = 10;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(231, 99);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(237, 27);
            this.txtLength.TabIndex = 11;
            // 
            // frmLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKmToMile);
            this.Controls.Add(this.btnMileToKm);
            this.Controls.Add(this.btnMeterToYard);
            this.Controls.Add(this.btnYardToMeter);
            this.Controls.Add(this.btnCmToInch);
            this.Controls.Add(this.btnInchToCm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLength";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Length";
            this.Load += new System.EventHandler(this.frmLength_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInchToCm;
        private System.Windows.Forms.Button btnCmToInch;
        private System.Windows.Forms.Button btnYardToMeter;
        private System.Windows.Forms.Button btnMeterToYard;
        private System.Windows.Forms.Button btnMileToKm;
        private System.Windows.Forms.Button btnKmToMile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.NumericUpDown txtLength;
    }
}