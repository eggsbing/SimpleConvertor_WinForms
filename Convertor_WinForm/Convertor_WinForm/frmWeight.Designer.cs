
namespace Convertor_WinForm
{
    partial class frmWeight
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
            this.LblWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.NumericUpDown();
            this.btnGrToKg = new System.Windows.Forms.Button();
            this.btnKgToGr = new System.Windows.Forms.Button();
            this.btnOunceToGr = new System.Windows.Forms.Button();
            this.btnPoundToKg = new System.Windows.Forms.Button();
            this.btnGrToOunce = new System.Windows.Forms.Button();
            this.btnKgToPound = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWeight
            // 
            this.LblWeight.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LblWeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblWeight.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblWeight.Location = new System.Drawing.Point(0, 0);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(534, 46);
            this.LblWeight.TabIndex = 0;
            this.LblWeight.Text = "Weight";
            this.LblWeight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter your number :";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(202, 100);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(230, 27);
            this.txtWeight.TabIndex = 2;
            // 
            // btnGrToKg
            // 
            this.btnGrToKg.Location = new System.Drawing.Point(110, 174);
            this.btnGrToKg.Name = "btnGrToKg";
            this.btnGrToKg.Size = new System.Drawing.Size(151, 29);
            this.btnGrToKg.TabIndex = 3;
            this.btnGrToKg.Text = "Gr -> Kg";
            this.btnGrToKg.UseVisualStyleBackColor = true;
            this.btnGrToKg.Click += new System.EventHandler(this.btnGrToKg_Click);
            // 
            // btnKgToGr
            // 
            this.btnKgToGr.Location = new System.Drawing.Point(267, 174);
            this.btnKgToGr.Name = "btnKgToGr";
            this.btnKgToGr.Size = new System.Drawing.Size(151, 29);
            this.btnKgToGr.TabIndex = 4;
            this.btnKgToGr.Text = "Kg -> Gr";
            this.btnKgToGr.UseVisualStyleBackColor = true;
            this.btnKgToGr.Click += new System.EventHandler(this.btnKgToGr_Click);
            // 
            // btnOunceToGr
            // 
            this.btnOunceToGr.Location = new System.Drawing.Point(110, 209);
            this.btnOunceToGr.Name = "btnOunceToGr";
            this.btnOunceToGr.Size = new System.Drawing.Size(151, 29);
            this.btnOunceToGr.TabIndex = 5;
            this.btnOunceToGr.Text = "Ounce -> Gr";
            this.btnOunceToGr.UseVisualStyleBackColor = true;
            this.btnOunceToGr.Click += new System.EventHandler(this.btnOunceToGr_Click);
            // 
            // btnPoundToKg
            // 
            this.btnPoundToKg.Location = new System.Drawing.Point(110, 244);
            this.btnPoundToKg.Name = "btnPoundToKg";
            this.btnPoundToKg.Size = new System.Drawing.Size(151, 29);
            this.btnPoundToKg.TabIndex = 6;
            this.btnPoundToKg.Text = "Pound -> Kg";
            this.btnPoundToKg.UseVisualStyleBackColor = true;
            this.btnPoundToKg.Click += new System.EventHandler(this.btnPoundToKg_Click);
            // 
            // btnGrToOunce
            // 
            this.btnGrToOunce.Location = new System.Drawing.Point(267, 209);
            this.btnGrToOunce.Name = "btnGrToOunce";
            this.btnGrToOunce.Size = new System.Drawing.Size(151, 29);
            this.btnGrToOunce.TabIndex = 7;
            this.btnGrToOunce.Text = "Gr -> Ounce";
            this.btnGrToOunce.UseVisualStyleBackColor = true;
            this.btnGrToOunce.Click += new System.EventHandler(this.btnGrToOunce_Click);
            // 
            // btnKgToPound
            // 
            this.btnKgToPound.Location = new System.Drawing.Point(267, 244);
            this.btnKgToPound.Name = "btnKgToPound";
            this.btnKgToPound.Size = new System.Drawing.Size(151, 29);
            this.btnKgToPound.TabIndex = 8;
            this.btnKgToPound.Text = "Kg -> Pound";
            this.btnKgToPound.UseVisualStyleBackColor = true;
            this.btnKgToPound.Click += new System.EventHandler(this.btnKgToPound_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your result is :";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(165, 336);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(190, 27);
            this.txtResult.TabIndex = 10;
            // 
            // frmWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKgToPound);
            this.Controls.Add(this.btnGrToOunce);
            this.Controls.Add(this.btnPoundToKg);
            this.Controls.Add(this.btnOunceToGr);
            this.Controls.Add(this.btnKgToGr);
            this.Controls.Add(this.btnGrToKg);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmWeight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Weight";
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtWeight;
        private System.Windows.Forms.Button btnGrToKg;
        private System.Windows.Forms.Button btnKgToGr;
        private System.Windows.Forms.Button btnOunceToGr;
        private System.Windows.Forms.Button btnPoundToKg;
        private System.Windows.Forms.Button btnGrToOunce;
        private System.Windows.Forms.Button btnKgToPound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
    }
}