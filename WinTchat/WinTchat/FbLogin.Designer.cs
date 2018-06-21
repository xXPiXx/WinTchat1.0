namespace WinTchat
{
    partial class FbLogin
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
            this.wbFb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbFb
            // 
            this.wbFb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbFb.Location = new System.Drawing.Point(0, 0);
            this.wbFb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbFb.Name = "wbFb";
            this.wbFb.Size = new System.Drawing.Size(917, 655);
            this.wbFb.TabIndex = 0;
            this.wbFb.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbFb_Navigated);
            // 
            // FbLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 655);
            this.Controls.Add(this.wbFb);
            this.Name = "FbLogin";
            this.Text = "Connexion avec Facebook";
            this.Load += new System.EventHandler(this.FbLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbFb;
    }
}