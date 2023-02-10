namespace Projekt
{
    partial class formTodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTodo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlacitkoPridejItem = new System.Windows.Forms.Button();
            this.textBoxTodo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 343);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tlacitkoPridejItem
            // 
            this.tlacitkoPridejItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tlacitkoPridejItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoPridejItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tlacitkoPridejItem.Image = ((System.Drawing.Image)(resources.GetObject("tlacitkoPridejItem.Image")));
            this.tlacitkoPridejItem.Location = new System.Drawing.Point(617, 381);
            this.tlacitkoPridejItem.Name = "tlacitkoPridejItem";
            this.tlacitkoPridejItem.Size = new System.Drawing.Size(104, 95);
            this.tlacitkoPridejItem.TabIndex = 2;
            this.tlacitkoPridejItem.UseVisualStyleBackColor = true;
            this.tlacitkoPridejItem.Click += new System.EventHandler(this.tlacitkoPridejItem_Click);
            // 
            // textBoxTodo
            // 
            this.textBoxTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxTodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTodo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBoxTodo.Location = new System.Drawing.Point(12, 401);
            this.textBoxTodo.Multiline = true;
            this.textBoxTodo.Name = "textBoxTodo";
            this.textBoxTodo.Size = new System.Drawing.Size(599, 64);
            this.textBoxTodo.TabIndex = 3;
            this.textBoxTodo.TextChanged += new System.EventHandler(this.textBoxTodo_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 372);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // formTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxTodo);
            this.Controls.Add(this.tlacitkoPridejItem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTodo";
            this.Text = "formTodo";
            this.Load += new System.EventHandler(this.formTodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Button tlacitkoPridejItem;
        private TextBox textBoxTodo;
        private DateTimePicker dateTimePicker1;
    }
}