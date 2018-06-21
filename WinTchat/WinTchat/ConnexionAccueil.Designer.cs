namespace WinTchat
{
    partial class ConnexionAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCoCompte = new System.Windows.Forms.Button();
            this.btnCoAnonyme = new System.Windows.Forms.Button();
            this.lblAcueil = new System.Windows.Forms.Label();
            this.btnCoFb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCoCompte
            // 
            this.btnCoCompte.Location = new System.Drawing.Point(47, 92);
            this.btnCoCompte.Name = "btnCoCompte";
            this.btnCoCompte.Size = new System.Drawing.Size(273, 54);
            this.btnCoCompte.TabIndex = 0;
            this.btnCoCompte.Text = "Se connecter avec un compte WinTchat";
            this.btnCoCompte.UseVisualStyleBackColor = true;
            this.btnCoCompte.Click += new System.EventHandler(this.btnCoCompte_Click);
            // 
            // btnCoAnonyme
            // 
            this.btnCoAnonyme.Location = new System.Drawing.Point(47, 228);
            this.btnCoAnonyme.Name = "btnCoAnonyme";
            this.btnCoAnonyme.Size = new System.Drawing.Size(273, 54);
            this.btnCoAnonyme.TabIndex = 1;
            this.btnCoAnonyme.Text = "Se connecter anonymement";
            this.btnCoAnonyme.UseVisualStyleBackColor = true;
            this.btnCoAnonyme.Click += new System.EventHandler(this.btnCoAnonyme_Click);
            // 
            // lblAcueil
            // 
            this.lblAcueil.AutoSize = true;
            this.lblAcueil.Location = new System.Drawing.Point(97, 29);
            this.lblAcueil.Name = "lblAcueil";
            this.lblAcueil.Size = new System.Drawing.Size(188, 20);
            this.lblAcueil.TabIndex = 2;
            this.lblAcueil.Text = "Bienvenu sur WinTchat !!!";
            // 
            // btnCoFb
            // 
            this.btnCoFb.Location = new System.Drawing.Point(47, 159);
            this.btnCoFb.Name = "btnCoFb";
            this.btnCoFb.Size = new System.Drawing.Size(273, 54);
            this.btnCoFb.TabIndex = 3;
            this.btnCoFb.Text = "Se connecter avec Facebook";
            this.btnCoFb.UseVisualStyleBackColor = true;
            this.btnCoFb.Click += new System.EventHandler(this.btnCoFb_Click);
            // 
            // ConnexionAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 319);
            this.Controls.Add(this.btnCoFb);
            this.Controls.Add(this.lblAcueil);
            this.Controls.Add(this.btnCoAnonyme);
            this.Controls.Add(this.btnCoCompte);
            this.Name = "ConnexionAccueil";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCoCompte;
        private System.Windows.Forms.Button btnCoAnonyme;
        private System.Windows.Forms.Label lblAcueil;
        private System.Windows.Forms.Button btnCoFb;
    }
}

