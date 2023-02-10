namespace Projekt
{
    partial class formMail
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
            this.labelMyMail = new System.Windows.Forms.Label();
            this.labelKomu = new System.Windows.Forms.Label();
            this.labelPredmet = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPredmet = new System.Windows.Forms.TextBox();
            this.textBoxKomu = new System.Windows.Forms.TextBox();
            this.textBoxTextMailu = new System.Windows.Forms.TextBox();
            this.tlacitkoOdesli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMyMail
            // 
            this.labelMyMail.AutoSize = true;
            this.labelMyMail.Location = new System.Drawing.Point(25, 32);
            this.labelMyMail.Name = "labelMyMail";
            this.labelMyMail.Size = new System.Drawing.Size(36, 15);
            this.labelMyMail.TabIndex = 0;
            this.labelMyMail.Text = "Email";
            // 
            // labelKomu
            // 
            this.labelKomu.AutoSize = true;
            this.labelKomu.Location = new System.Drawing.Point(25, 80);
            this.labelKomu.Name = "labelKomu";
            this.labelKomu.Size = new System.Drawing.Size(42, 15);
            this.labelKomu.TabIndex = 1;
            this.labelKomu.Text = "Komu:";
            // 
            // labelPredmet
            // 
            this.labelPredmet.AutoSize = true;
            this.labelPredmet.Location = new System.Drawing.Point(21, 129);
            this.labelPredmet.Name = "labelPredmet";
            this.labelPredmet.Size = new System.Drawing.Size(52, 15);
            this.labelPredmet.TabIndex = 2;
            this.labelPredmet.Text = "Předmět";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(103, 24);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(206, 23);
            this.textBoxMail.TabIndex = 3;
            // 
            // textBoxPredmet
            // 
            this.textBoxPredmet.Location = new System.Drawing.Point(103, 121);
            this.textBoxPredmet.Name = "textBoxPredmet";
            this.textBoxPredmet.Size = new System.Drawing.Size(206, 23);
            this.textBoxPredmet.TabIndex = 4;
            // 
            // textBoxKomu
            // 
            this.textBoxKomu.Location = new System.Drawing.Point(103, 72);
            this.textBoxKomu.Name = "textBoxKomu";
            this.textBoxKomu.Size = new System.Drawing.Size(206, 23);
            this.textBoxKomu.TabIndex = 5;
            // 
            // textBoxTextMailu
            // 
            this.textBoxTextMailu.Location = new System.Drawing.Point(103, 175);
            this.textBoxTextMailu.Multiline = true;
            this.textBoxTextMailu.Name = "textBoxTextMailu";
            this.textBoxTextMailu.Size = new System.Drawing.Size(345, 110);
            this.textBoxTextMailu.TabIndex = 6;
            // 
            // tlacitkoOdesli
            // 
            this.tlacitkoOdesli.Location = new System.Drawing.Point(326, 305);
            this.tlacitkoOdesli.Name = "tlacitkoOdesli";
            this.tlacitkoOdesli.Size = new System.Drawing.Size(122, 23);
            this.tlacitkoOdesli.TabIndex = 7;
            this.tlacitkoOdesli.Text = "Odešli";
            this.tlacitkoOdesli.UseVisualStyleBackColor = true;
            this.tlacitkoOdesli.Click += new System.EventHandler(this.tlacitkoOdesli_Click);
            // 
            // formMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(470, 341);
            this.Controls.Add(this.tlacitkoOdesli);
            this.Controls.Add(this.textBoxTextMailu);
            this.Controls.Add(this.textBoxKomu);
            this.Controls.Add(this.textBoxPredmet);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelPredmet);
            this.Controls.Add(this.labelKomu);
            this.Controls.Add(this.labelMyMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMail";
            this.Text = "formMail";
            this.Load += new System.EventHandler(this.formMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMyMail;
        private Label labelKomu;
        private Label labelPredmet;
        private TextBox textBoxMail;
        private TextBox textBoxPredmet;
        private TextBox textBoxKomu;
        private TextBox textBoxTextMailu;
        private Button tlacitkoOdesli;
    }
}