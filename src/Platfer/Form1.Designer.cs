namespace Platfer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlatferBack = new System.Windows.Forms.Button();
            this.PlatferForward = new System.Windows.Forms.Button();
            this.PlatferRefresh = new System.Windows.Forms.Button();
            this.PlatferHome = new System.Windows.Forms.Button();
            this.PlatferNewTab = new System.Windows.Forms.Button();
            this.PlatferSearch = new System.Windows.Forms.Button();
            this.PlatferURL = new System.Windows.Forms.TextBox();
            this.PlatferTabControl = new System.Windows.Forms.TabControl();
            this.PlatferTabPage = new System.Windows.Forms.TabPage();
            this.PlatferTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlatferBack
            // 
            this.PlatferBack.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.PlatferBack.Location = new System.Drawing.Point(12, 12);
            this.PlatferBack.Name = "PlatferBack";
            this.PlatferBack.Size = new System.Drawing.Size(27, 27);
            this.PlatferBack.TabIndex = 0;
            this.PlatferBack.Text = "←";
            this.PlatferBack.UseVisualStyleBackColor = true;
            this.PlatferBack.Click += new System.EventHandler(this.PlatferBack_Click);
            // 
            // PlatferForward
            // 
            this.PlatferForward.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.PlatferForward.Location = new System.Drawing.Point(45, 12);
            this.PlatferForward.Name = "PlatferForward";
            this.PlatferForward.Size = new System.Drawing.Size(27, 27);
            this.PlatferForward.TabIndex = 1;
            this.PlatferForward.Text = "→";
            this.PlatferForward.UseVisualStyleBackColor = true;
            this.PlatferForward.Click += new System.EventHandler(this.PlatferForward_Click);
            // 
            // PlatferRefresh
            // 
            this.PlatferRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PlatferRefresh.Location = new System.Drawing.Point(78, 12);
            this.PlatferRefresh.Name = "PlatferRefresh";
            this.PlatferRefresh.Size = new System.Drawing.Size(27, 27);
            this.PlatferRefresh.TabIndex = 2;
            this.PlatferRefresh.Text = "↻";
            this.PlatferRefresh.UseVisualStyleBackColor = true;
            this.PlatferRefresh.Click += new System.EventHandler(this.PlatferRefresh_Click);
            // 
            // PlatferHome
            // 
            this.PlatferHome.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.PlatferHome.Location = new System.Drawing.Point(111, 12);
            this.PlatferHome.Name = "PlatferHome";
            this.PlatferHome.Size = new System.Drawing.Size(75, 27);
            this.PlatferHome.TabIndex = 3;
            this.PlatferHome.Text = "Home";
            this.PlatferHome.UseVisualStyleBackColor = true;
            this.PlatferHome.Click += new System.EventHandler(this.PlatferHome_Click);
            // 
            // PlatferNewTab
            // 
            this.PlatferNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatferNewTab.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PlatferNewTab.Location = new System.Drawing.Point(964, 12);
            this.PlatferNewTab.Name = "PlatferNewTab";
            this.PlatferNewTab.Size = new System.Drawing.Size(27, 27);
            this.PlatferNewTab.TabIndex = 5;
            this.PlatferNewTab.Text = "+";
            this.PlatferNewTab.UseVisualStyleBackColor = true;
            this.PlatferNewTab.Click += new System.EventHandler(this.PlatferNewTab_Click);
            // 
            // PlatferSearch
            // 
            this.PlatferSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatferSearch.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.PlatferSearch.Location = new System.Drawing.Point(997, 12);
            this.PlatferSearch.Name = "PlatferSearch";
            this.PlatferSearch.Size = new System.Drawing.Size(75, 27);
            this.PlatferSearch.TabIndex = 6;
            this.PlatferSearch.Text = "Search";
            this.PlatferSearch.UseVisualStyleBackColor = true;
            this.PlatferSearch.Click += new System.EventHandler(this.PlatferSearch_Click);
            // 
            // PlatferURL
            // 
            this.PlatferURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatferURL.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.PlatferURL.Location = new System.Drawing.Point(192, 12);
            this.PlatferURL.Multiline = true;
            this.PlatferURL.Name = "PlatferURL";
            this.PlatferURL.Size = new System.Drawing.Size(766, 27);
            this.PlatferURL.TabIndex = 7;
            // 
            // PlatferTabControl
            // 
            this.PlatferTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatferTabControl.Controls.Add(this.PlatferTabPage);
            this.PlatferTabControl.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.PlatferTabControl.Location = new System.Drawing.Point(1, 45);
            this.PlatferTabControl.Name = "PlatferTabControl";
            this.PlatferTabControl.SelectedIndex = 0;
            this.PlatferTabControl.Size = new System.Drawing.Size(1083, 619);
            this.PlatferTabControl.TabIndex = 8;
            // 
            // PlatferTabPage
            // 
            this.PlatferTabPage.Location = new System.Drawing.Point(4, 22);
            this.PlatferTabPage.Name = "PlatferTabPage";
            this.PlatferTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlatferTabPage.Size = new System.Drawing.Size(1075, 593);
            this.PlatferTabPage.TabIndex = 0;
            this.PlatferTabPage.Text = "tabPage1";
            this.PlatferTabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.PlatferTabControl);
            this.Controls.Add(this.PlatferURL);
            this.Controls.Add(this.PlatferSearch);
            this.Controls.Add(this.PlatferNewTab);
            this.Controls.Add(this.PlatferHome);
            this.Controls.Add(this.PlatferRefresh);
            this.Controls.Add(this.PlatferForward);
            this.Controls.Add(this.PlatferBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Platfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PlatferTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlatferBack;
        private System.Windows.Forms.Button PlatferForward;
        private System.Windows.Forms.Button PlatferRefresh;
        private System.Windows.Forms.Button PlatferHome;
        private System.Windows.Forms.Button PlatferNewTab;
        private System.Windows.Forms.Button PlatferSearch;
        private System.Windows.Forms.TextBox PlatferURL;
        private System.Windows.Forms.TabControl PlatferTabControl;
        private System.Windows.Forms.TabPage PlatferTabPage;
    }
}

