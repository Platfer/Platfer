// Copyright 2022 Cyril John Magayaga
// Platfer - Philippines' first web browser
// PlatferVersion = v1.3

using System;
using System.Windows.Forms;

namespace Platfer
{
    public partial class Form1 : Form
    {
        private readonly object txtUrl;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.bing.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Url", e.Url);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "DocumentCompleted Event");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
