namespace Projekt
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelHeslo = new System.Windows.Forms.Label();
            this.textBoxHeslo = new System.Windows.Forms.TextBox();
            this.tlacitkoPrihlas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelLogin.Location = new System.Drawing.Point(12, 112);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(84, 37);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxLogin.Location = new System.Drawing.Point(102, 127);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(159, 23);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelHeslo
            // 
            this.labelHeslo.AutoSize = true;
            this.labelHeslo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeslo.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelHeslo.Location = new System.Drawing.Point(12, 163);
            this.labelHeslo.Name = "labelHeslo";
            this.labelHeslo.Size = new System.Drawing.Size(84, 37);
            this.labelHeslo.TabIndex = 0;
            this.labelHeslo.Text = "Heslo";
            // 
            // textBoxHeslo
            // 
            this.textBoxHeslo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxHeslo.Location = new System.Drawing.Point(102, 177);
            this.textBoxHeslo.Name = "textBoxHeslo";
            this.textBoxHeslo.Size = new System.Drawing.Size(159, 23);
            this.textBoxHeslo.TabIndex = 2;
            this.textBoxHeslo.UseSystemPasswordChar = true;
            // 
            // tlacitkoPrihlas
            // 
            this.tlacitkoPrihlas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tlacitkoPrihlas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoPrihlas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tlacitkoPrihlas.ForeColor = System.Drawing.Color.SteelBlue;
            this.tlacitkoPrihlas.Location = new System.Drawing.Point(12, 232);
            this.tlacitkoPrihlas.Name = "tlacitkoPrihlas";
            this.tlacitkoPrihlas.Size = new System.Drawing.Size(249, 68);
            this.tlacitkoPrihlas.TabIndex = 3;
            this.tlacitkoPrihlas.Text = "Přihlásit";
            this.tlacitkoPrihlas.UseVisualStyleBackColor = true;
            this.tlacitkoPrihlas.Click += new System.EventHandler(this.buttonPrihlas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(12, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrace";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(217, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 50);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(281, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tlacitkoPrihlas);
            this.Controls.Add(this.textBoxHeslo);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelHeslo);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "formLogin";
            this.Text = "formLogin";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLogin;
        private TextBox textBoxLogin;
        private Label labelHeslo;
        private TextBox textBoxHeslo;
        private Button tlacitkoPrihlas;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}