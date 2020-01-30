namespace nikSimetic
{
    partial class Form1
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
            this.chbDorucak = new System.Windows.Forms.CheckBox();
            this.chbRucak = new System.Windows.Forms.CheckBox();
            this.chbVecera = new System.Windows.Forms.CheckBox();
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.chbSakrijNarudbu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chbDorucak
            // 
            this.chbDorucak.AutoSize = true;
            this.chbDorucak.Location = new System.Drawing.Point(118, 72);
            this.chbDorucak.Name = "chbDorucak";
            this.chbDorucak.Size = new System.Drawing.Size(67, 17);
            this.chbDorucak.TabIndex = 0;
            this.chbDorucak.Text = "Doručak";
            this.chbDorucak.UseVisualStyleBackColor = true;
            // 
            // chbRucak
            // 
            this.chbRucak.AutoSize = true;
            this.chbRucak.Location = new System.Drawing.Point(118, 166);
            this.chbRucak.Name = "chbRucak";
            this.chbRucak.Size = new System.Drawing.Size(58, 17);
            this.chbRucak.TabIndex = 1;
            this.chbRucak.Text = "Ručak";
            this.chbRucak.UseVisualStyleBackColor = true;
            // 
            // chbVecera
            // 
            this.chbVecera.AutoSize = true;
            this.chbVecera.Location = new System.Drawing.Point(118, 237);
            this.chbVecera.Name = "chbVecera";
            this.chbVecera.Size = new System.Drawing.Size(60, 17);
            this.chbVecera.TabIndex = 2;
            this.chbVecera.Text = "Večera";
            this.chbVecera.UseVisualStyleBackColor = true;
            this.chbVecera.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(348, 53);
            this.txtPrikaz.Multiline = true;
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(307, 201);
            this.txtPrikaz.TabIndex = 3;
            this.txtPrikaz.Text = "Odabrali ste:";
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(118, 358);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 4;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            // 
            // chbSakrijNarudbu
            // 
            this.chbSakrijNarudbu.AutoSize = true;
            this.chbSakrijNarudbu.Location = new System.Drawing.Point(404, 358);
            this.chbSakrijNarudbu.Name = "chbSakrijNarudbu";
            this.chbSakrijNarudbu.Size = new System.Drawing.Size(97, 17);
            this.chbSakrijNarudbu.TabIndex = 5;
            this.chbSakrijNarudbu.Text = "Sakrij Naruđbu";
            this.chbSakrijNarudbu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbSakrijNarudbu);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.chbVecera);
            this.Controls.Add(this.chbRucak);
            this.Controls.Add(this.chbDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbDorucak;
        private System.Windows.Forms.CheckBox chbRucak;
        private System.Windows.Forms.CheckBox chbVecera;
        private System.Windows.Forms.TextBox txtPrikaz;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.CheckBox chbSakrijNarudbu;
    }
}

