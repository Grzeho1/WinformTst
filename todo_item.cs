using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projekt
{
    public partial class todo_item : UserControl
    {
        public todo_item()
        {
            InitializeComponent();
        }

        private void todo_item_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Strikeout);
                this.BackColor = Color.Aqua;
                
            }
            else
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Regular);
            }
            if (zmena!=null)
            {
                zmena.Invoke(this,new EventArgs());
            }
        }
        public todo_item(string Text,bool check)
        {
            this.Text = Text;
            
            InitializeComponent();
            label1.Text = Text;
            checkBox1.Checked=check;
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Strikeout);

                this.BackColor = Color.Red;
            }
            else
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Regular);
                this.BackColor = Color.OliveDrab;
            }
            if (zmena != null)
            {
                zmena.Invoke(this, new EventArgs());
            }


        }
        public event EventHandler zmena = null;
    }
}
