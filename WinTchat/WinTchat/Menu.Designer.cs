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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_nomPrenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFbPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFbPicture
            // 
            this.pbFbPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbFbPicture.InitialImage = null;
            this.pbFbPicture.Location = new System.Drawing.Point(25, 49);
            this.pbFbPicture.Name = "pbFbPicture";
            this.pbFbPicture.Size = new System.Drawing.Size(120, 120);
            this.pbFbPicture.TabIndex = 0;
            this.pbFbPicture.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1201, 630);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_nomPrenom);
            this.tabPage1.Controls.Add(this.pbFbPicture);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1193, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mon compte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1193, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mes amis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1193, 597);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fils de discussion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_nomPrenom
            // 
            this.lbl_nomPrenom.AutoSize = true;
            this.lbl_nomPrenom.Location = new System.Drawing.Point(198, 49);
            this.lbl_nomPrenom.Name = "lbl_nomPrenom";
            this.lbl_nomPrenom.Size = new System.Drawing.Size(51, 20);
            this.lbl_nomPrenom.TabIndex = 1;
            this.lbl_nomPrenom.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 654);
            this.Controls.Add(this.tabControl1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFbPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFbPicture;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_nomPrenom;
    }
}