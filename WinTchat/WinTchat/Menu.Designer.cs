﻿namespace WinTchat
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
            this.lbl_nom = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_deco = new System.Windows.Forms.Button();
            this.btn_modifProfil = new System.Windows.Forms.Button();
            this.lbl_pseudo = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFbPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFbPicture
            // 
            this.pbFbPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbFbPicture.InitialImage = null;
            this.pbFbPicture.Location = new System.Drawing.Point(31, 31);
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
            this.tabControl1.Size = new System.Drawing.Size(1201, 592);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_birthdate);
            this.tabPage1.Controls.Add(this.lbl_email);
            this.tabPage1.Controls.Add(this.lbl_pseudo);
            this.tabPage1.Controls.Add(this.btn_modifProfil);
            this.tabPage1.Controls.Add(this.lbl_nom);
            this.tabPage1.Controls.Add(this.pbFbPicture);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1193, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mon compte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(173, 46);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(64, 20);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "lbl_nom";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1193, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mes amis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1193, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fils de discussion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_deco
            // 
            this.btn_deco.Location = new System.Drawing.Point(1006, 610);
            this.btn_deco.Name = "btn_deco";
            this.btn_deco.Size = new System.Drawing.Size(203, 32);
            this.btn_deco.TabIndex = 2;
            this.btn_deco.Text = "Déconnexion";
            this.btn_deco.UseVisualStyleBackColor = true;
            // 
            // btn_modifProfil
            // 
            this.btn_modifProfil.Location = new System.Drawing.Point(10, 503);
            this.btn_modifProfil.Name = "btn_modifProfil";
            this.btn_modifProfil.Size = new System.Drawing.Size(243, 45);
            this.btn_modifProfil.TabIndex = 2;
            this.btn_modifProfil.Text = "Modifier mon profil";
            this.btn_modifProfil.UseVisualStyleBackColor = true;
            // 
            // lbl_pseudo
            // 
            this.lbl_pseudo.AutoSize = true;
            this.lbl_pseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pseudo.Location = new System.Drawing.Point(502, 49);
            this.lbl_pseudo.Name = "lbl_pseudo";
            this.lbl_pseudo.Size = new System.Drawing.Size(133, 29);
            this.lbl_pseudo.TabIndex = 3;
            this.lbl_pseudo.Text = "lbl_pseudo";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(173, 80);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(70, 20);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "lbl_email";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(36, 154);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(96, 20);
            this.lbl_birthdate.TabIndex = 5;
            this.lbl_birthdate.Text = "lbl_birthdate";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 654);
            this.Controls.Add(this.btn_deco);
            this.Controls.Add(this.tabControl1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
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
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Button btn_deco;
        private System.Windows.Forms.Button btn_modifProfil;
        private System.Windows.Forms.Label lbl_pseudo;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_birthdate;
    }
}