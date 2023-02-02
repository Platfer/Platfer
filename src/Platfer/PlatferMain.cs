using CefSharp;
using CefSharp.WinForms;
using System;
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
    public partial class PlatferMain : Form
    {
        public PlatferMain()
        {
            InitializeComponent();
        }

        private void PlatferURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Platfer.Load(PlatferURL.Text);
        }

        ChromiumWebBrowser Platfer;

        private void PlatferMain_Load(object sender, EventArgs e)
        {
            PlatferURL.Text = "https://www.google.com";
            Platfer = new ChromiumWebBrowser(PlatferURL.Text);
            Platfer.Dock = DockStyle.Fill;
            this.PlatferContainer.Controls.Add(Platfer);
            Platfer.AddressChanged += Platfer_AddressChanged;
        }

        private void Platfer_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                PlatferURL.Text = e.Address;
            }));
        }

        private void PlatferSearch_Click(object sender, EventArgs e)
        {
            Platfer.Load(PlatferURL.Text);
        }

        private void PlatferBack_Click(object sender, EventArgs e)
        {
            Platfer.Back();
        }

        private void PlatferForward_Click(object sender, EventArgs e)
        {
            Platfer.Forward();
        }

        private void PlatferRefresh_Click(object sender, EventArgs e)
        {
            Platfer.Refresh();
        }

        private void PlatferHome_Click(object sender, EventArgs e)
        {
            PlatferURL.Text = "https://www.google.com";
            ChromiumWebBrowser Platfer = new ChromiumWebBrowser(PlatferURL.Text);
            Platfer.Dock = DockStyle.Fill;
        }

        private void PlatferContainer_Paint(object sender, PaintEventArgs e)
        {
            ChromiumWebBrowser Platfer = new ChromiumWebBrowser("https://www.google.com");
            Platfer.Dock = DockStyle.Fill;
        }
    }
}
