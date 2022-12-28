// Platfer
// Copyright 2022 Cyril John Magayaga
// Latest version: v1.5
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com");
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
                web.Navigate(txtUrl.Text);
        }

        WebBrowser webTab = null;

        private void btnNewtab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount-1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true};
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.com");
            txtUrl.Text = "https://www.google.com";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webTab.DocumentTitle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if(web!=null)
            {
                if (web.CanGoBack)
                    web.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                    web.GoForward();
            }
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if(web!=null)
                {
                    web.Navigate(txtUrl.Text);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanSelect)
                    web.Refresh();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanFocus)
                    web.GoHome();
                web.Navigate("https://www.google.com");
            }
        }
    }
}
