
namespace Convertor_WinForm
{
    partial class frmVolume
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
            this.txtVolume = new System.Windows.Forms.NumericUpDown();
            this.btnLitreToPint = new System.Windows.Forms.Button();
            this.btnPintToLitre = new System.Windows.Forms.Button();
            this.btnGallonToLitre = new System.Windows.Forms.Button();
            this.btnLitreToGallon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please enter your number :";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(202, 95);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(244, 27);
            this.txtVolume.TabIndex = 2;
            // 
            // btnLitreToPint
            // 
            this.btnLitreToPint.Location = new System.Drawing.Point(146, 158);
            this.btnLitreToPint.Name = "btnLitreToPint";
            this.btnLitreToPint.Size = new System.Drawing.Size(238, 29);
            this.btnLitreToPint.TabIndex = 3;
            this.btnLitreToPint.Text = "Litre -> Pint";
            this.btnLitreToPint.UseVisualStyleBackColor = true;
            this.btnLitreToPint.Click += new System.EventHandler(this.btnLitreToPint_Click);
            // 
            // btnPintToLitre
            // 
            this.btnPintToLitre.Location = new System.Drawing.Point(146, 193);
            this.btnPintToLitre.Name = "btnPintToLitre";
            this.btnPintToLitre.Size = new System.Drawing.Size(238, 29);
            this.btnPintToLitre.TabIndex = 4;
            this.btnPintToLitre.Text = "Pint -> Litre";
            this.btnPintToLitre.UseVisualStyleBackColor = true;
            this.btnPintToLitre.Click += new System.EventHandler(this.btnPintToLitre_Click);
            // 
            // btnGallonToLitre
            // 
            this.btnGallonToLitre.Location = new System.Drawing.Point(146, 263);
            this.btnGallonToLitre.Name = "btnGallonToLitre";
            this.btnGallonToLitre.Size = new System.Drawing.Size(238, 29);
            this.btnGallonToLitre.TabIndex = 5;
            this.btnGallonToLitre.Text = "Gallon -> Litre";
            this.btnGallonToLitre.UseVisualStyleBackColor = true;
            this.btnGallonToLitre.Click += new System.EventHandler(this.btnGallonToLitre_Click);
            // 
            // btnLitreToGallon
            // 
            this.btnLitreToGallon.Location = new System.Drawing.Point(146, 228);
            this.btnLitreToGallon.Name = "btnLitreToGallon";
            this.btnLitreToGallon.Size = new System.Drawing.Size(238, 29);
            this.btnLitreToGallon.TabIndex = 6;
            this.btnLitreToGallon.Text = "Litre -> Gallon";
            this.btnLitreToGallon.UseVisualStyleBackColor = true;
            this.btnLitreToGallon.Click += new System.EventHandler(this.btnLitreToGallon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your result is :";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(146, 351);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(238, 27);
            this.txtResult.TabIndex = 8;
            // 
            // frmVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLitreToGallon);
            this.Controls.Add(this.btnGallonToLitre);
            this.Controls.Add(this.btnPintToLitre);
            this.Controls.Add(this.btnLitreToPint);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVolume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Volume";
            ((System.ComponentModel.ISupportInitialize)(this.txtVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtVolume;
        private System.Windows.Forms.Button btnLitreToPint;
        private System.Windows.Forms.Button btnPintToLitre;
        private System.Windows.Forms.Button btnGallonToLitre;
        private System.Windows.Forms.Button btnLitreToGallon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
    }
}