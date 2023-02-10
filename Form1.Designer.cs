namespace Projekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlacitkoMail = new System.Windows.Forms.Button();
            this.panelNavigace = new System.Windows.Forms.Panel();
            this.tlacitkoNastaveni = new System.Windows.Forms.Button();
            this.tlacitkoKalendar = new System.Windows.Forms.Button();
            this.tlacitkoTodo = new System.Windows.Forms.Button();
            this.tlacitkoDomu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNazev = new System.Windows.Forms.Label();
            this.panelHlavni = new System.Windows.Forms.Panel();
            this.tlacitkoExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.tlacitkoMail);
            this.panel1.Controls.Add(this.panelNavigace);
            this.panel1.Controls.Add(this.tlacitkoNastaveni);
            this.panel1.Controls.Add(this.tlacitkoKalendar);
            this.panel1.Controls.Add(this.tlacitkoTodo);
            this.panel1.Controls.Add(this.tlacitkoDomu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 577);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tlacitkoMail
            // 
            this.tlacitkoMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlacitkoMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlacitkoMail.FlatAppearance.BorderSize = 0;
            this.tlacitkoMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoMail.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tlacitkoMail.ForeColor = System.Drawing.Color.SteelBlue;
            this.tlacitkoMail.Image = ((System.Drawing.Image)(resources.GetObject("tlacitkoMail.Image")));
            this.tlacitkoMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlacitkoMail.Location = new System.Drawing.Point(0, 412);
            this.tlacitkoMail.Name = "tlacitkoMail";
            this.tlacitkoMail.Size = new System.Drawing.Size(181, 63);
            this.tlacitkoMail.TabIndex = 3;
            this.tlacitkoMail.Text = "Mail";
            this.tlacitkoMail.UseVisualStyleBackColor = true;
            this.tlacitkoMail.Click += new System.EventHandler(this.tlacitkoMail_Click);
            this.tlacitkoMail.Leave += new System.EventHandler(this.tlacitkoMail_Leave);
            // 
            // panelNavigace
            // 
            this.panelNavigace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNavigace.Location = new System.Drawing.Point(0, 193);
            this.panelNavigace.Name = "panelNavigace";
            this.panelNavigace.Size = new System.Drawing.Size(3, 100);
            this.panelNavigace.TabIndex = 2;
            // 
            // tlacitkoNastaveni
            // 
            this.tlacitkoNastaveni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlacitkoNastaveni.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlacitkoNastaveni.FlatAppearance.BorderSize = 0;
            this.tlacitkoNastaveni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoNastaveni.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tlacitkoNastaveni.ForeColor = System.Drawing.Color.SteelBlue;
            this.tlacitkoNastaveni.Image = ((System.Drawing.Image)(resources.GetObject("tlacitkoNastaveni.Image")));
            this.tlacitkoNastaveni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlacitkoNastaveni.Location = new System.Drawing.Point(0, 349);
            this.tlacitkoNastaveni.Name = "tlacitkoNastaveni";
            this.tlacitkoNastaveni.Size = new System.Drawing.Size(181, 63);
            this.tlacitkoNastaveni.TabIndex = 1;
            this.tlacitkoNastaveni.Text = "Nastavení";
            this.tlacitkoNastaveni.UseVisualStyleBackColor = true;
            this.tlacitkoNastaveni.Click += new System.EventHandler(this.tlacitkoNastaveni_Click);
            this.tlacitkoNastaveni.Leave += new System.EventHandler(this.tlacitkoNastaveni_Leave);
            // 
            // tlacitkoKalendar
            // 
            this.tlacitkoKalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlacitkoKalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlacitkoKalendar.FlatAppearance.BorderSize = 0;
            this.tlacitkoKalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoKalendar.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tlacitkoKalendar.ForeColor = System.Drawing.Color.SteelBlue;
            this.tlacitkoKalendar.Image = ((System.Drawing.Image)(resources.GetObject("tlacitkoKalendar.Image")));
            this.tlacitkoKalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlacitkoKalendar.Location = new System.Drawing.Point(0, 286);
            this.tlacitkoKalendar.Name = "tlacitkoKalendar";
            this.tlacitkoKalendar.Size = new System.Drawing.Size(181, 63);
            this.tlacitkoKalendar.TabIndex = 1;
            this.tlacitkoKalendar.Text = "Kalendář";
            this.tlacitkoKalendar.UseVisualStyleBackColor = true;
            this.tlacitkoKalendar.Click += new System.EventHandler(this.tlacitkoKalendar_Click);
            this.tlacitkoKalendar.Leave += new System.EventHandler(this.tlacitkoKalendar_Leave);
            // 
            // tlacitkoTodo
            // 
            this.tlacitkoTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlacitkoTodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlacitkoTodo.FlatAppearance.BorderSize = 0;
            this.tlacitkoTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoTodo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tlacitkoTodo.ForeColor = System.Drawing.Color.SteelBlue;
            this.tlacitkoTodo.Image = ((System.Drawing.Image)(resources.GetObject("tlacitkoTodo.Image")));
            this.tlacitkoTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlacitkoTodo.Location = new System.Drawing.Point(0, 223);
            this.tlacitkoTodo.Name = "tlacitkoTodo";
            this.tlacitkoTodo.Size = new System.Drawing.Size(181, 63);
            this.tlacitkoTodo.TabIndex = 1;
            this.tlacitkoTodo.Text = "ToDo";
            this.tlacitkoTodo.UseVisualStyleBackColor = true;
            this.tlacitkoTodo.Click += new System.EventHandler(this.tlacitkoTodo_Click);
            this.tlacitkoTodo.Leave += new System.EventHandler(this.tlacitkoTodo_Leave);
            // 
            // tlacitkoDomu
            // 
            this.tlacitkoDomu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlacitkoDomu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlacitkoDomu.FlatAppearance.BorderSize = 0;
            this.tlacitkoDomu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoDomu.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tlacitkoDomu.ForeColor = System.Drawing.Color.SteelBlue;
            this.tlacitkoDomu.Image = ((System.Drawing.Image)(resources.GetObject("tlacitkoDomu.Image")));
            this.tlacitkoDomu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlacitkoDomu.Location = new System.Drawing.Point(0, 160);
            this.tlacitkoDomu.Name = "tlacitkoDomu";
            this.tlacitkoDomu.Size = new System.Drawing.Size(181, 63);
            this.tlacitkoDomu.TabIndex = 1;
            this.tlacitkoDomu.Text = "Domů";
            this.tlacitkoDomu.UseVisualStyleBackColor = true;
            this.tlacitkoDomu.Click += new System.EventHandler(this.tlacitkoDomu_Click);
            this.tlacitkoDomu.Leave += new System.EventHandler(this.tlacitkoDomu_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelJmeno);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 160);
            this.panel2.TabIndex = 0;
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJmeno.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelJmeno.Location = new System.Drawing.Point(51, 127);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(81, 28);
            this.labelJmeno.TabIndex = 2;
            this.labelJmeno.Text = "uzivatel";
            this.labelJmeno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(44, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uživatel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelNazev
            // 
            this.labelNazev.AutoSize = true;
            this.labelNazev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.labelNazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNazev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelNazev.Location = new System.Drawing.Point(223, 12);
            this.labelNazev.Name = "labelNazev";
            this.labelNazev.Size = new System.Drawing.Size(90, 31);
            this.labelNazev.TabIndex = 1;
            this.labelNazev.Text = "Domů";
            // 
            // panelHlavni
            // 
            this.panelHlavni.Location = new System.Drawing.Point(187, 71);
            this.panelHlavni.Name = "panelHlavni";
            this.panelHlavni.Size = new System.Drawing.Size(752, 494);
            this.panelHlavni.TabIndex = 2;
            // 
            // tlacitkoExit
            // 
            this.tlacitkoExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tlacitkoExit.FlatAppearance.BorderSize = 0;
            this.tlacitkoExit.Image = ((System.Drawing.Image)(resources.GetObject("tlacitkoExit.Image")));
            this.tlacitkoExit.Location = new System.Drawing.Point(893, 8);
            this.tlacitkoExit.Name = "tlacitkoExit";
            this.tlacitkoExit.Size = new System.Drawing.Size(46, 51);
            this.tlacitkoExit.TabIndex = 4;
            this.tlacitkoExit.UseVisualStyleBackColor = false;
            this.tlacitkoExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(374, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tlacitkoExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHlavni);
            this.Controls.Add(this.labelNazev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button tlacitkoDomu;
        private Label label1;
        private Panel panelNavigace;
        private Button tlacitkoNastaveni;
        private Button tlacitkoKalendar;
        private Button tlacitkoTodo;
        private Label labelNazev;
        private Panel panelHlavni;
        private Label labelJmeno;
        private Button tlacitkoMail;
        private Button tlacitkoExit;
        private TextBox textBox1;
    }
}