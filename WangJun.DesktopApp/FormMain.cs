﻿using System;
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

            browser = new ChromiumWebBrowser("http://localhost:14000/UI/Login/Login.html");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
