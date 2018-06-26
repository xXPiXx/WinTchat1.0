namespace WinTchat
{
    partial class Connexion_WinTchat
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.btn_inscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(115, 46);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(56, 20);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email :";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(58, 124);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(113, 20);
            this.lbl_mdp.TabIndex = 2;
            this.lbl_mdp.Text = "Mot de passe :";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(193, 43);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(350, 26);
            this.tb_email.TabIndex = 3;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(193, 121);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(350, 26);
            this.tb_mdp.TabIndex = 5;
            this.tb_mdp.UseSystemPasswordChar = true;
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(165, 213);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(249, 46);
            this.btn_connexion.TabIndex = 6;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // btn_inscription
            // 
            this.btn_inscription.Location = new System.Drawing.Point(165, 297);
            this.btn_inscription.Name = "btn_inscription";
            this.btn_inscription.Size = new System.Drawing.Size(249, 46);
            this.btn_inscription.TabIndex = 7;
            this.btn_inscription.Text = "Inscription";
            this.btn_inscription.UseVisualStyleBackColor = true;
            this.btn_inscription.Click += new System.EventHandler(this.btn_inscription_Click);
            // 
            // Connexion_WinTchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 382);
            this.Controls.Add(this.btn_inscription);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_email);
            this.Name = "Connexion_WinTchat";
            this.Text = "Connexion WinTchat";
            this.Load += new System.EventHandler(this.Connexion_WinTchat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.Button btn_inscription;
    }
}