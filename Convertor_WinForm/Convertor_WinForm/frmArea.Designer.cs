
namespace Convertor_WinForm
{
    partial class frmArea
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
            this.txtArea = new System.Windows.Forms.NumericUpDown();
            this.btnInchToCm2 = new System.Windows.Forms.Button();
            this.btnMeterToYard2 = new System.Windows.Forms.Button();
            this.btnCmToInch2 = new System.Windows.Forms.Button();
            this.btnMileToKm2 = new System.Windows.Forms.Button();
            this.btnYardToMeter2 = new System.Windows.Forms.Button();
            this.btnKmToMile2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your number :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(202, 85);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(234, 27);
            this.txtArea.TabIndex = 2;
            // 
            // btnInchToCm2
            // 
            this.btnInchToCm2.Location = new System.Drawing.Point(112, 144);
            this.btnInchToCm2.Name = "btnInchToCm2";
            this.btnInchToCm2.Size = new System.Drawing.Size(159, 29);
            this.btnInchToCm2.TabIndex = 3;
            this.btnInchToCm2.Text = "Inch^2 -> Cm^2";
            this.btnInchToCm2.UseVisualStyleBackColor = true;
            this.btnInchToCm2.Click += new System.EventHandler(this.btnInchToCm2_Click);
            // 
            // btnMeterToYard2
            // 
            this.btnMeterToYard2.Location = new System.Drawing.Point(277, 179);
            this.btnMeterToYard2.Name = "btnMeterToYard2";
            this.btnMeterToYard2.Size = new System.Drawing.Size(159, 29);
            this.btnMeterToYard2.TabIndex = 4;
            this.btnMeterToYard2.Text = "Meter^2 -> Yard^2";
            this.btnMeterToYard2.UseVisualStyleBackColor = true;
            this.btnMeterToYard2.Click += new System.EventHandler(this.btnMeterToYard2_Click);
            // 
            // btnCmToInch2
            // 
            this.btnCmToInch2.Location = new System.Drawing.Point(277, 144);
            this.btnCmToInch2.Name = "btnCmToInch2";
            this.btnCmToInch2.Size = new System.Drawing.Size(159, 29);
            this.btnCmToInch2.TabIndex = 5;
            this.btnCmToInch2.Text = "Cm^2 -> Inch^2";
            this.btnCmToInch2.UseVisualStyleBackColor = true;
            this.btnCmToInch2.Click += new System.EventHandler(this.btnCmToInch2_Click);
            // 
            // btnMileToKm2
            // 
            this.btnMileToKm2.Location = new System.Drawing.Point(112, 214);
            this.btnMileToKm2.Name = "btnMileToKm2";
            this.btnMileToKm2.Size = new System.Drawing.Size(159, 29);
            this.btnMileToKm2.TabIndex = 6;
            this.btnMileToKm2.Text = "Mile^2 -> Km^2";
            this.btnMileToKm2.UseVisualStyleBackColor = true;
            this.btnMileToKm2.Click += new System.EventHandler(this.btnMileToKm2_Click);
            // 
            // btnYardToMeter2
            // 
            this.btnYardToMeter2.Location = new System.Drawing.Point(112, 179);
            this.btnYardToMeter2.Name = "btnYardToMeter2";
            this.btnYardToMeter2.Size = new System.Drawing.Size(159, 29);
            this.btnYardToMeter2.TabIndex = 7;
            this.btnYardToMeter2.Text = "Yard^2 -> Meter^2";
            this.btnYardToMeter2.UseVisualStyleBackColor = true;
            this.btnYardToMeter2.Click += new System.EventHandler(this.btnYardToMeter2_Click);
            // 
            // btnKmToMile2
            // 
            this.btnKmToMile2.Location = new System.Drawing.Point(277, 214);
            this.btnKmToMile2.Name = "btnKmToMile2";
            this.btnKmToMile2.Size = new System.Drawing.Size(159, 29);
            this.btnKmToMile2.TabIndex = 8;
            this.btnKmToMile2.Text = "Km^2 -> Mile^2";
            this.btnKmToMile2.UseVisualStyleBackColor = true;
            this.btnKmToMile2.Click += new System.EventHandler(this.btnKmToMile2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Your result is :";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(166, 325);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(216, 27);
            this.txtResult.TabIndex = 10;
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKmToMile2);
            this.Controls.Add(this.btnYardToMeter2);
            this.Controls.Add(this.btnMileToKm2);
            this.Controls.Add(this.btnCmToInch2);
            this.Controls.Add(this.btnMeterToYard2);
            this.Controls.Add(this.btnInchToCm2);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Area";
            ((System.ComponentModel.ISupportInitialize)(this.txtArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtArea;
        private System.Windows.Forms.Button btnInchToCm2;
        private System.Windows.Forms.Button btnMeterToYard2;
        private System.Windows.Forms.Button btnCmToInch2;
        private System.Windows.Forms.Button btnMileToKm2;
        private System.Windows.Forms.Button btnYardToMeter2;
        private System.Windows.Forms.Button btnKmToMile2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
    }
}