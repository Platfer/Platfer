namespace Platfer
{
    partial class PlatferMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlatferMain));
            this.PlatferBack = new System.Windows.Forms.Button();
            this.PlatferForward = new System.Windows.Forms.Button();
            this.PlatferHome = new System.Windows.Forms.Button();
            this.PlatferURL = new System.Windows.Forms.TextBox();
            this.PlatferSearch = new System.Windows.Forms.Button();
            this.PlatferRefresh = new System.Windows.Forms.Button();
            this.PlatferContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PlatferBack
            // 
            this.PlatferBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlatferBack.Location = new System.Drawing.Point(12, 12);
            this.PlatferBack.Name = "PlatferBack";
            this.PlatferBack.Size = new System.Drawing.Size(24, 23);
            this.PlatferBack.TabIndex = 0;
            this.PlatferBack.Text = "<";
            this.PlatferBack.UseVisualStyleBackColor = true;
            this.PlatferBack.Click += new System.EventHandler(this.PlatferBack_Click);
            // 
            // PlatferForward
            // 
            this.PlatferForward.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlatferForward.Location = new System.Drawing.Point(42, 12);
            this.PlatferForward.Name = "PlatferForward";
            this.PlatferForward.Size = new System.Drawing.Size(24, 23);
            this.PlatferForward.TabIndex = 1;
            this.PlatferForward.Text = ">";
            this.PlatferForward.UseVisualStyleBackColor = true;
            this.PlatferForward.Click += new System.EventHandler(this.PlatferForward_Click);
            // 
            // PlatferHome
            // 
            this.PlatferHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlatferHome.Location = new System.Drawing.Point(102, 12);
            this.PlatferHome.Name = "PlatferHome";
            this.PlatferHome.Size = new System.Drawing.Size(49, 23);
            this.PlatferHome.TabIndex = 2;
            this.PlatferHome.Text = "Home";
            this.PlatferHome.UseVisualStyleBackColor = true;
            this.PlatferHome.Click += new System.EventHandler(this.PlatferHome_Click);
            // 
            // PlatferURL
            // 
            this.PlatferURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatferURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlatferURL.Location = new System.Drawing.Point(157, 12);
            this.PlatferURL.Multiline = true;
            this.PlatferURL.Name = "PlatferURL";
            this.PlatferURL.Size = new System.Drawing.Size(561, 20);
            this.PlatferURL.TabIndex = 3;
            this.PlatferURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlatferURL_KeyPress);
            // 
            // PlatferSearch
            // 
            this.PlatferSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatferSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlatferSearch.Location = new System.Drawing.Point(724, 12);
            this.PlatferSearch.Name = "PlatferSearch";
            this.PlatferSearch.Size = new System.Drawing.Size(64, 23);
            this.PlatferSearch.TabIndex = 4;
            this.PlatferSearch.Text = "Search";
            this.PlatferSearch.UseVisualStyleBackColor = true;
            this.PlatferSearch.Click += new System.EventHandler(this.PlatferSearch_Click);
            // 
            // PlatferRefresh
            // 
            this.PlatferRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlatferRefresh.Location = new System.Drawing.Point(72, 12);
            this.PlatferRefresh.Name = "PlatferRefresh";
            this.PlatferRefresh.Size = new System.Drawing.Size(24, 23);
            this.PlatferRefresh.TabIndex = 5;
            this.PlatferRefresh.Text = "⟳";
            this.PlatferRefresh.UseVisualStyleBackColor = true;
            this.PlatferRefresh.Click += new System.EventHandler(this.PlatferRefresh_Click);
            // 
            // PlatferContainer
            // 
            this.PlatferContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatferContainer.Location = new System.Drawing.Point(12, 41);
            this.PlatferContainer.Name = "PlatferContainer";
            this.PlatferContainer.Size = new System.Drawing.Size(776, 397);
            this.PlatferContainer.TabIndex = 6;
            this.PlatferContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PlatferContainer_Paint);
            // 
            // PlatferMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlatferContainer);
            this.Controls.Add(this.PlatferRefresh);
            this.Controls.Add(this.PlatferSearch);
            this.Controls.Add(this.PlatferURL);
            this.Controls.Add(this.PlatferHome);
            this.Controls.Add(this.PlatferForward);
            this.Controls.Add(this.PlatferBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlatferMain";
            this.Text = "Platfer";
            this.Load += new System.EventHandler(this.PlatferMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlatferBack;
        private System.Windows.Forms.Button PlatferForward;
        private System.Windows.Forms.Button PlatferHome;
        private System.Windows.Forms.TextBox PlatferURL;
        private System.Windows.Forms.Button PlatferSearch;
        private System.Windows.Forms.Button PlatferRefresh;
        private System.Windows.Forms.Panel PlatferContainer;
    }
}

