namespace WinTchat
{
    partial class InscriptionWinTchat
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
            this.lbl_pseudo = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_pays = new System.Windows.Forms.Label();
            this.lbl_langue = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_pseudo = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.tb_mdpConf = new System.Windows.Forms.TextBox();
            this.lbl_mdpConf = new System.Windows.Forms.Label();
            this.dtp_naissance = new System.Windows.Forms.DateTimePicker();
            this.cb_pays = new System.Windows.Forms.ComboBox();
            this.cb_langue = new System.Windows.Forms.ComboBox();
            this.btn_inscrire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_pseudo
            // 
            this.lbl_pseudo.AutoSize = true;
            this.lbl_pseudo.Location = new System.Drawing.Point(141, 140);
            this.lbl_pseudo.Name = "lbl_pseudo";
            this.lbl_pseudo.Size = new System.Drawing.Size(71, 20);
            this.lbl_pseudo.TabIndex = 0;
            this.lbl_pseudo.Text = "Pseudo :";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(162, 40);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(50, 20);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "Nom :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(140, 90);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(72, 20);
            this.lbl_prenom.TabIndex = 2;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(99, 190);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(113, 20);
            this.lbl_mdp.TabIndex = 3;
            this.lbl_mdp.Text = "Mot de passe :";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(62, 290);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(150, 20);
            this.lbl_birthdate.TabIndex = 4;
            this.lbl_birthdate.Text = "Date de naissance :";
            // 
            // lbl_pays
            // 
            this.lbl_pays.AutoSize = true;
            this.lbl_pays.Location = new System.Drawing.Point(161, 340);
            this.lbl_pays.Name = "lbl_pays";
            this.lbl_pays.Size = new System.Drawing.Size(51, 20);
            this.lbl_pays.TabIndex = 5;
            this.lbl_pays.Text = "Pays :";
            // 
            // lbl_langue
            // 
            this.lbl_langue.AutoSize = true;
            this.lbl_langue.Location = new System.Drawing.Point(141, 390);
            this.lbl_langue.Name = "lbl_langue";
            this.lbl_langue.Size = new System.Drawing.Size(71, 20);
            this.lbl_langue.TabIndex = 6;
            this.lbl_langue.Text = "Langue :";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(228, 37);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(356, 26);
            this.tb_nom.TabIndex = 7;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(228, 87);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(356, 26);
            this.tb_prenom.TabIndex = 8;
            // 
            // tb_pseudo
            // 
            this.tb_pseudo.Location = new System.Drawing.Point(228, 137);
            this.tb_pseudo.Name = "tb_pseudo";
            this.tb_pseudo.Size = new System.Drawing.Size(356, 26);
            this.tb_pseudo.TabIndex = 9;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(228, 187);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.PasswordChar = '●';
            this.tb_mdp.Size = new System.Drawing.Size(356, 26);
            this.tb_mdp.TabIndex = 10;
            this.tb_mdp.UseSystemPasswordChar = true;
            // 
            // tb_mdpConf
            // 
            this.tb_mdpConf.Location = new System.Drawing.Point(228, 237);
            this.tb_mdpConf.Name = "tb_mdpConf";
            this.tb_mdpConf.PasswordChar = '●';
            this.tb_mdpConf.Size = new System.Drawing.Size(356, 26);
            this.tb_mdpConf.TabIndex = 12;
            this.tb_mdpConf.UseSystemPasswordChar = true;
            // 
            // lbl_mdpConf
            // 
            this.lbl_mdpConf.AutoSize = true;
            this.lbl_mdpConf.Location = new System.Drawing.Point(7, 240);
            this.lbl_mdpConf.Name = "lbl_mdpConf";
            this.lbl_mdpConf.Size = new System.Drawing.Size(205, 20);
            this.lbl_mdpConf.TabIndex = 11;
            this.lbl_mdpConf.Text = "Confirmez le mot de passe :";
            // 
            // dtp_naissance
            // 
            this.dtp_naissance.Location = new System.Drawing.Point(228, 285);
            this.dtp_naissance.Name = "dtp_naissance";
            this.dtp_naissance.Size = new System.Drawing.Size(277, 26);
            this.dtp_naissance.TabIndex = 13;
            // 
            // cb_pays
            // 
            this.cb_pays.FormattingEnabled = true;
            this.cb_pays.Location = new System.Drawing.Point(228, 337);
            this.cb_pays.Name = "cb_pays";
            this.cb_pays.Size = new System.Drawing.Size(213, 28);
            this.cb_pays.TabIndex = 14;
            // 
            // cb_langue
            // 
            this.cb_langue.FormattingEnabled = true;
            this.cb_langue.Location = new System.Drawing.Point(228, 387);
            this.cb_langue.Name = "cb_langue";
            this.cb_langue.Size = new System.Drawing.Size(213, 28);
            this.cb_langue.TabIndex = 15;
            // 
            // btn_inscrire
            // 
            this.btn_inscrire.Location = new System.Drawing.Point(578, 427);
            this.btn_inscrire.Name = "btn_inscrire";
            this.btn_inscrire.Size = new System.Drawing.Size(210, 56);
            this.btn_inscrire.TabIndex = 16;
            this.btn_inscrire.Text = "S\'inscrire";
            this.btn_inscrire.UseVisualStyleBackColor = true;
            this.btn_inscrire.Click += new System.EventHandler(this.btn_inscrire_Click);
            // 
            // InscriptionWinTchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btn_inscrire);
            this.Controls.Add(this.cb_langue);
            this.Controls.Add(this.cb_pays);
            this.Controls.Add(this.dtp_naissance);
            this.Controls.Add(this.tb_mdpConf);
            this.Controls.Add(this.lbl_mdpConf);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_pseudo);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.lbl_langue);
            this.Controls.Add(this.lbl_pays);
            this.Controls.Add(this.lbl_birthdate);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.lbl_pseudo);
            this.Name = "InscriptionWinTchat";
            this.Text = "InscriptionWinTchat";
            this.Load += new System.EventHandler(this.InscriptionWinTchat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pseudo;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label lbl_pays;
        private System.Windows.Forms.Label lbl_langue;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_pseudo;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.TextBox tb_mdpConf;
        private System.Windows.Forms.Label lbl_mdpConf;
        private System.Windows.Forms.DateTimePicker dtp_naissance;
        private System.Windows.Forms.ComboBox cb_pays;
        private System.Windows.Forms.ComboBox cb_langue;
        private System.Windows.Forms.Button btn_inscrire;
    }
}