namespace WinTchat
{
    partial class Menu
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
            this.pbFbPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFbPicture
            // 
            this.pbFbPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbFbPicture.InitialImage = null;
            this.pbFbPicture.Location = new System.Drawing.Point(22, 26);
            this.pbFbPicture.Name = "pbFbPicture";
            this.pbFbPicture.Size = new System.Drawing.Size(120, 120);
            this.pbFbPicture.TabIndex = 0;
            this.pbFbPicture.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 654);
            this.Controls.Add(this.pbFbPicture);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFbPicture;
    }
}