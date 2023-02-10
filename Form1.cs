using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Projekt
    
{
    public partial class Form1 : Form
    {
        
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        formTodo formTd;

        ///*********
        /// Povoluje pohyb s oknem
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        //*********

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightElliepse

            );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNavigace.Height = tlacitkoDomu.Height;
            panelNavigace.Top = tlacitkoDomu.Top;
            panelNavigace.Left = tlacitkoDomu.Left;
            tlacitkoDomu.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "Domù";
            this.panelHlavni.Controls.Clear();
            formDomu formDomu = new formDomu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formDomu.FormBorderStyle = FormBorderStyle.None;
            this.panelHlavni.Controls.Add(formDomu);
            formDomu.Show();



            // API pro zobrazení aktuální ceny BTC
            string apiKey = "ID9N2ILR6H1BU48H";
            string url = $"https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency=BTC&to_currency=USD&apikey={apiKey}";

            using (WebClient client = new WebClient())
            {
                try
                {
                    string json = client.DownloadString(url);
                    JObject data = JObject.Parse(json);
                    string price = (string)data["Realtime Currency Exchange Rate"]["5. Exchange Rate"];
                    textBox1.Text =("Cena BTC/USD = " + price +" "+"USD");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            //**

        }
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelJmeno.Text = Uzivatel.Login;
        }

        private void tlacitkoDomu_Click(object sender, EventArgs e)
        {
            panelNavigace.Height = tlacitkoDomu.Height;
            panelNavigace.Top = tlacitkoDomu.Top;
            panelNavigace.Left = tlacitkoDomu.Left;
            tlacitkoDomu.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "Domù";
            this.panelHlavni.Controls.Clear();
            formDomu formDomu = new formDomu() { Dock = DockStyle.Fill,TopLevel=false,TopMost = true};
            formDomu.FormBorderStyle = FormBorderStyle.None;
            this.panelHlavni.Controls.Add(formDomu);
            formDomu.Show();
        }

        private void tlacitkoDomu_Leave(object sender, EventArgs e)
        {
            tlacitkoDomu.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void tlacitkoTodo_Click(object sender, EventArgs e)
        {



            panelNavigace.Height = tlacitkoTodo.Height;
            panelNavigace.Top = tlacitkoTodo.Top;
            panelNavigace.Left = tlacitkoTodo.Left;
            tlacitkoTodo.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "ToDo";
            this.panelHlavni.Controls.Clear();
            formTodo formTodo = new formTodo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTodo.FormBorderStyle = FormBorderStyle.None;
            this.panelHlavni.Controls.Add(formTodo);
            formTodo.Show();


        }

        private void tlacitkoTodo_Leave(object sender, EventArgs e)
        {
            tlacitkoTodo.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void tlacitkoNastaveni_Click(object sender, EventArgs e)
        {
            panelNavigace.Height = tlacitkoNastaveni.Height;
            panelNavigace.Top = tlacitkoNastaveni.Top;
            panelNavigace.Left = tlacitkoNastaveni.Left;
            tlacitkoNastaveni.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "Nastavení";
            this.panelHlavni.Controls.Clear();
            formNastaveni formNastaveni = new formNastaveni() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formNastaveni.FormBorderStyle = FormBorderStyle.None;
            this.panelHlavni.Controls.Add(formNastaveni);
            formNastaveni.Show();   

        }
      

        private void tlacitkoKalendar_Click(object sender, EventArgs e)
        {
            panelNavigace.Height = tlacitkoKalendar.Height;
            panelNavigace.Top = tlacitkoKalendar.Top;
            panelNavigace.Left = tlacitkoKalendar.Left;
            tlacitkoKalendar.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "Kalendáø";
        }

        private void tlacitkoKalendar_Leave(object sender, EventArgs e)
        {
            tlacitkoKalendar.BackColor = Color.FromArgb(24, 30, 54);
        }


        private void tlacitkoNastaveni_Leave(object sender, EventArgs e)
        {
            tlacitkoNastaveni.BackColor = Color.FromArgb(24, 30, 54);
        }

        

        private void tlacitkoMail_Click(object sender, EventArgs e)
        {
            panelNavigace.Height = tlacitkoMail.Height;
            panelNavigace.Top = tlacitkoMail.Top;
            panelNavigace.Left = tlacitkoMail.Left;
            tlacitkoMail.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "Email";
            this.panelHlavni.Controls.Clear();
            formMail formMail = new formMail() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMail.FormBorderStyle = FormBorderStyle.None;
            this.panelHlavni.Controls.Add(formMail);
            formMail.Show();
        }

        private void tlacitkoMail_Leave(object sender, EventArgs e)
        {
            tlacitkoMail.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}