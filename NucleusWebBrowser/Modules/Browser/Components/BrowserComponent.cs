using CefSharp;
using CefSharp.WinForms;
using NucleusWebBrowser.Modules.Browser.Repository;
using System;
using System.Windows.Forms;

namespace NucleusWebBrowser.Modules.Browser.Components
{
    public partial class BrowserComponent : UserControl
    {
        public BrowserComponent()
        {
            InitializeComponent();
            InitializeChromium();
        }
        private ChromiumWebBrowser chromeBrowser;
        public void InitializeChromium()
        {
            //CefSettings settings = new CefSettings();
            //// Initialize cef with the provided settings
            //Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://www.google.com");
            // Add it to the form and fill it to the form window.
            chromeBrowser.Dock = DockStyle.Fill;
            this.browser_painel_central.Controls.Add(chromeBrowser);
        }
        private void BrowserComponent_Load(object sender, EventArgs e)
        {
          
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeBrowser.ShowDevTools();
        }

        private async void sessaoDevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cookieManager = Cef.GetGlobalCookieManager();
            var visitor = new CookieCollector();

            cookieManager.VisitUrlCookies("http://aflinemao.fs.ngestor.com", true, visitor);

            var cookies = await visitor.Task;
            var cookieHeader = CookieCollector.GetCookieHeader(cookies);

            MessageBox.Show(cookieHeader);
        }

        private void optionsMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            chromeBrowser.Back();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            chromeBrowser.Forward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("http://www.google.com");
        }
    }
}
