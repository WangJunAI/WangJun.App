using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace WangJun.DesktopApp
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser browser;
        public Form1()
        {
            InitializeComponent();
            InitBrowser();

        }

        public void InitBrowser()
        {
            ///browser = new ChromiumWebBrowser("http://localhost:14000/UI/Login/Login.html");
            browser = new ChromiumWebBrowser("http://www.baidu.com");

            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            //browser.AddressChanged += Browser_AddressChanged;
            browser.Click += Browser_Click;


        }

        private void Browser_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
           // throw new NotImplementedException();
        }
    }
}
