namespace Projekt
{
    partial class formRegistrace
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxHeslo = new System.Windows.Forms.TextBox();
            this.textBoxPotvrzeni = new System.Windows.Forms.TextBox();
            this.tlacitkoRegistruj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Heslo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(42, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Potvrzení hesla";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxLogin.Location = new System.Drawing.Point(42, 72);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(267, 23);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxHeslo
            // 
            this.textBoxHeslo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxHeslo.Location = new System.Drawing.Point(42, 138);
            this.textBoxHeslo.Name = "textBoxHeslo";
            this.textBoxHeslo.PasswordChar = '*';
            this.textBoxHeslo.Size = new System.Drawing.Size(267, 23);
            this.textBoxHeslo.TabIndex = 2;
            this.textBoxHeslo.UseSystemPasswordChar = true;
            // 
            // textBoxPotvrzeni
            // 
            this.textBoxPotvrzeni.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPotvrzeni.Location = new System.Drawing.Point(42, 204);
            this.textBoxPotvrzeni.Name = "textBoxPotvrzeni";
            this.textBoxPotvrzeni.PasswordChar = '*';
            this.textBoxPotvrzeni.Size = new System.Drawing.Size(267, 23);
            this.textBoxPotvrzeni.TabIndex = 3;
            this.textBoxPotvrzeni.UseSystemPasswordChar = true;
            // 
            // tlacitkoRegistruj
            // 
            this.tlacitkoRegistruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoRegistruj.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tlacitkoRegistruj.ForeColor = System.Drawing.Color.SteelBlue;
            this.tlacitkoRegistruj.Location = new System.Drawing.Point(89, 316);
            this.tlacitkoRegistruj.Name = "tlacitkoRegistruj";
            this.tlacitkoRegistruj.Size = new System.Drawing.Size(159, 41);
            this.tlacitkoRegistruj.TabIndex = 3;
            this.tlacitkoRegistruj.Text = "Registruj";
            this.tlacitkoRegistruj.UseVisualStyleBackColor = true;
            this.tlacitkoRegistruj.Click += new System.EventHandler(this.tlacitkoRegistruj_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(42, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zpět na přihášení";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(89, 244);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 21);
            this.labelError.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelEmail.Location = new System.Drawing.Point(42, 228);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(230, 37);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email (nepovinné)";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxEmail.Location = new System.Drawing.Point(42, 268);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '*';
            this.textBoxEmail.Size = new System.Drawing.Size(267, 23);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.UseSystemPasswordChar = true;
            // 
            // formRegistrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(351, 416);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tlacitkoRegistruj);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPotvrzeni);
            this.Controls.Add(this.textBoxHeslo);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRegistrace";
            this.Text = "formRegistrace";
            this.Load += new System.EventHandler(this.formRegistrace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxLogin;
        private TextBox textBoxHeslo;
        private TextBox textBoxPotvrzeni;
        private Button tlacitkoRegistruj;
        private Button button1;
        private Label labelError;
        private Label labelEmail;
        private TextBox textBoxEmail;
    }
}