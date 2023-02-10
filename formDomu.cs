using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Net;
namespace Projekt
{
    public partial class formDomu : Form
    {
        public formDomu()
        {
            InitializeComponent();
        }

        private void formDomu_Load(object sender, EventArgs e)
        {
            casovac.Start();
            InitBrowser();

        }

        private void casovac_Tick(object sender, EventArgs e)
        {
            labelHodiny.Text = DateTime.Now.ToString("dd.  MMMM  H:mm:ss");

        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://www.google.com/");
        }

        void Pocasi()
        {
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/3.0/onecall?lat=39.31&lon=-74.5&exclude=hourly&appid=784dce9177341e93f289398169ac9fa4");
                var json = web.DownloadString(url);
               
         }
        }
    }
}
