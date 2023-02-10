namespace Projekt
{
    partial class formNastaveni
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
            this.tlacitkoZmenaHesla = new System.Windows.Forms.Button();
            this.textBoxNoveHeslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTestNoveHeslo = new System.Windows.Forms.TextBox();
            this.textBoxAktualHeslo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tlacitkoZmenaHesla
            // 
            this.tlacitkoZmenaHesla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tlacitkoZmenaHesla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoZmenaHesla.ForeColor = System.Drawing.Color.SteelBlue;
            this.tlacitkoZmenaHesla.Location = new System.Drawing.Point(447, 12);
            this.tlacitkoZmenaHesla.Name = "tlacitkoZmenaHesla";
            this.tlacitkoZmenaHesla.Size = new System.Drawing.Size(126, 62);
            this.tlacitkoZmenaHesla.TabIndex = 0;
            this.tlacitkoZmenaHesla.Text = "Změnit heslo";
            this.tlacitkoZmenaHesla.UseVisualStyleBackColor = false;
            this.tlacitkoZmenaHesla.Click += new System.EventHandler(this.tlacitkoZmenaHesla_Click);
            // 
            // textBoxNoveHeslo
            // 
            this.textBoxNoveHeslo.Location = new System.Drawing.Point(111, 33);
            this.textBoxNoveHeslo.Name = "textBoxNoveHeslo";
            this.textBoxNoveHeslo.Size = new System.Drawing.Size(295, 23);
            this.textBoxNoveHeslo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nové";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nové znovu";
            // 
            // textBoxTestNoveHeslo
            // 
            this.textBoxTestNoveHeslo.Location = new System.Drawing.Point(111, 62);
            this.textBoxTestNoveHeslo.Name = "textBoxTestNoveHeslo";
            this.textBoxTestNoveHeslo.Size = new System.Drawing.Size(295, 23);
            this.textBoxTestNoveHeslo.TabIndex = 1;
            // 
            // textBoxAktualHeslo
            // 
            this.textBoxAktualHeslo.Location = new System.Drawing.Point(111, 4);
            this.textBoxAktualHeslo.Name = "textBoxAktualHeslo";
            this.textBoxAktualHeslo.Size = new System.Drawing.Size(295, 23);
            this.textBoxAktualHeslo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(24, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stávající heslo";
            // 
            // formNastaveni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAktualHeslo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTestNoveHeslo);
            this.Controls.Add(this.textBoxNoveHeslo);
            this.Controls.Add(this.tlacitkoZmenaHesla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formNastaveni";
            this.Text = "formNastaveni";
            this.Load += new System.EventHandler(this.formNastaveni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button tlacitkoZmenaHesla;
        private TextBox textBoxNoveHeslo;
        private Label label1;
        private Label label2;
        private TextBox textBoxTestNoveHeslo;
        private TextBox textBoxAktualHeslo;
        private Label label3;
    }
}