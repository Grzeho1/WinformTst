using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class formTodo : Form
    {
        
        public formTodo()
        {
            InitializeComponent();
            
        }
        int poz = 10;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            


        }
        public void pridat(string Text,bool check)
        {
            todo_item item = new todo_item(Text,check);
            panel1.Controls.Add(item);
            item.Top = poz;
            poz = (item.Top + item.Height + 10);
            
        }

        private void tlacitkoPridejItem_Click(object sender, EventArgs e)
        {
            pridat(textBoxTodo.Text,false);
            textBoxTodo.Text = "";


            

        }

        private void formTodo_Load(object sender, EventArgs e)
        {
            tlacitkoPridejItem.Enabled = false;
            
            
        }

        private void textBoxTodo_TextChanged(object sender, EventArgs e)
        {
            if(textBoxTodo.Text.Trim().Length > 0)
            {
                tlacitkoPridejItem.Enabled = true;
            }
            else
            {
                tlacitkoPridejItem.Enabled = false;
            }
            
        }
    }

}
