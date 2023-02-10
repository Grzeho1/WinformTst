using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Projekt
{
    public partial class formRegistrace : Form
    {

        public formRegistrace()
        {
            InitializeComponent();
            checkLogin();
        }
        SqlConnection con = new SqlConnection(@"Data Source=TOMAS;Initial Catalog=Projekt;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            formLogin nextForm = new formLogin();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
        private Boolean checkLogin()
        {
            string login=textBoxLogin.Text;
            Boolean loginFree=false;


            String kontrolaDuplicity = "SELECT * FROM Login WHERE login = '" + login + "'";


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = kontrolaDuplicity;
            cmd.Connection = con;
            SqlDataAdapter da=new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count>0)

            {
                loginFree = true;
            }
            return loginFree;
                

        }


        private void tlacitkoRegistruj_Click(object sender, EventArgs e)
        {
            string login, heslo, potvrzeniHesla,email;

            login = textBoxLogin.Text;
            heslo = textBoxHeslo.Text;
            email = textBoxEmail.Text; 
            potvrzeniHesla = textBoxPotvrzeni.Text;




            try
            {

                if (checkLogin() == true || login != "" || heslo != "" || heslo != potvrzeniHesla)

                    if (checkLogin() == true)
                    {
                        labelError.Text = "Uživatel uz existuje";
                    }
                    else if(login == "" || heslo == "")
                    {
                        MessageBox.Show("Nevyplneno", "chyba", MessageBoxButtons.OK);
                    }
                    else if(heslo != potvrzeniHesla)
                    {
                        MessageBox.Show("hesla se neshodují", "chyba", MessageBoxButtons.OK);
                    }



                else 
                {

                    String querry = "INSERT INTO  Login VALUES ('" + textBoxLogin.Text + "' ,'" + textBoxHeslo.Text + "','" + textBoxEmail.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    MessageBox.Show("Registrace proběhla uspěšně", ":)", MessageBoxButtons.OK);
                    textBoxHeslo.Clear();
                    textBoxLogin.Clear();
                    textBoxPotvrzeni.Clear();



                }
                  
            }
            
            catch (Exception)
            {
                MessageBox.Show("Chyba spojení", "Chyba", MessageBoxButtons.OK);
                
            }
            finally
            {
                con.Close();

                

            }
        }

        private void formRegistrace_Load(object sender, EventArgs e)
        {

        }
    }
}
