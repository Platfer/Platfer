// Platfer
// Copyright 2022-2023 Cyril John Magayaga
// Latest Release Date: v2.0
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

        private void PlatferSearch_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = PlatferTabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome!=null)
                chrome.Load(PlatferURL.Text);
        }

        private void PlatferRefresh_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = PlatferTabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome != null)
                chrome.Refresh();
        }

        private void PlatferForward_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = PlatferTabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chrome != null)
            {
                if (chrome.CanGoForward)
                    chrome.Forward();
            }
        }

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
