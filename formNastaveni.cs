using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projekt
{
    public partial class formNastaveni : Form
    {
        public formNastaveni()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=TOMAS;Initial Catalog=Projekt;Integrated Security=True");

        private void formNastaveni_Load(object sender, EventArgs e)
        {
           
        }

        private void tlacitkoZmenaHesla_Click(object sender, EventArgs e)
        {
            string heslo = Uzivatel.Heslo;
            

            if (textBoxNoveHeslo.Text == textBoxTestNoveHeslo.Text && heslo==textBoxAktualHeslo.Text)
            {

                String querry = "UPDATE Login SET heslo = '" + textBoxNoveHeslo.Text + "' WHERE login = '" + Uzivatel.Login + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                MessageBox.Show("Změna hesla proběhla ůspěšně", "ok", MessageBoxButtons.OK);
                con.Close();
            }
            else
            {
                MessageBox.Show("Změna hesla neproběhla", "Chyba", MessageBoxButtons.OK);
                con.Close();
            }
            

        }
    }
}
