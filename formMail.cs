using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;
using System.IO;

namespace Projekt
{
   

    public partial class formMail : Form
    {

        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "Projekt";



        public formMail()
        {
            InitializeComponent();
        }

        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        private void formMail_Load(object sender, EventArgs e)
        {
            textBoxMail.Text = Uzivatel.Email;
        }

        private void tlacitkoOdesli_Click(object sender, EventArgs e)
        {
            UserCredential credential;
            //cteni json souboru
            using (FileStream stream = new FileStream(Application.StartupPath + @"/credentials.json", FileMode.Open, FileAccess.Read))
            {
                string soubor = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                soubor = Path.Combine(soubor, ".credentials/gmail-dotnet-quickstart.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(soubor, true)).Result;
            }
            try
            {
                string message = $"To: {textBoxKomu.Text}\r\nSubject: {textBoxPredmet.Text}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h1>{textBoxTextMailu.Text}</h1>";
                //Gmail
                var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
                var msg = new Google.Apis.Gmail.v1.Data.Message();
                msg.Raw = Base64UrlEncode(message.ToString());
                service.Users.Messages.Send(msg, "me").Execute();
                MessageBox.Show("Email byl odeslán !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Email nebyl odeslán !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
