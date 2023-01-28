// Platfer – Graphical web browser
// Copyright 2022-2023 Cyril John Magayaga
// Latest Release Date: v2.1
using System;
using CefSharp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace Platfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Platfer 
        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            PlatferURL.Text = "https://www.google.com";
            ChromiumWebBrowser chrome = new ChromiumWebBrowser(PlatferURL.Text);
            chrome.Parent = PlatferTabControl.SelectedTab;
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                PlatferURL.Text = e.Address;
            }));
        }

        // Platfer Search Button
        private void PlatferSearch_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = PlatferTabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome!=null)
                chrome.Load(PlatferURL.Text);
        }

        // Platfer Reload Button
        private void PlatferRefresh_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = PlatferTabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome != null)
                chrome.Refresh();
        }

        // Platfer Forward Button
        private void PlatferForward_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = PlatferTabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome != null)
            {
                if (chrome.CanGoForward)
                    chrome.Forward();
            }
        }

        // Platfer Back Button
        private void PlatferBack_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = PlatferTabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome != null)
            {
                if (chrome.CanGoBack)
                chrome.Back();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        // Platfer New Tab
        private void PlatferNewTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            PlatferTabControl.Controls.Add(tab);
            PlatferTabControl.SelectTab(PlatferTabControl.TabCount - 1);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser("https://www.google.com");
            chrome.Parent = tab;
            chrome.Dock = DockStyle.Fill;
            PlatferURL.Text = "https://www.google.com";
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;
        }

        private void Chrome_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                PlatferTabControl.SelectedTab.Text = e.Title;
            }));
        }

        // Platfer Home
        private void PlatferHome_Click(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            PlatferURL.Text = "https://www.google.com";
            ChromiumWebBrowser chrome = new ChromiumWebBrowser(PlatferURL.Text);
            chrome.Parent = PlatferTabControl.SelectedTab;
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;
        }
    }
}
