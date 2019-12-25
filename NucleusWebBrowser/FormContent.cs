using EasyTabs;
using NucleusWebBrowser.Modules.Browser.Components;
using System;
using System.Windows.Forms;
namespace NucleusWebBrowser
{
    public partial class FormContent : Form
    {
        public FormContent()
        {
            InitializeComponent();
        }

        protected TitleBarTabs ParentsTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BrowserComponent browserComponent = new BrowserComponent();
            browserComponent.Dock = DockStyle.Fill;
            this.Controls.Add(browserComponent);
          
        }

    }
}
