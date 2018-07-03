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
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pseudo = new System.Windows.Forms.Label();
            this.btn_modifProfil = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_deco = new System.Windows.Forms.Button();
            this.Amis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFbPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFbPicture
            // 
            this.pbFbPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbFbPicture.InitialImage = null;
            this.pbFbPicture.Location = new System.Drawing.Point(21, 20);
            this.pbFbPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pbFbPicture.Name = "pbFbPicture";
            this.pbFbPicture.Size = new System.Drawing.Size(80, 78);
            this.pbFbPicture.TabIndex = 0;
            this.pbFbPicture.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 385);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_birthdate);
            this.tabPage1.Controls.Add(this.lbl_email);
            this.tabPage1.Controls.Add(this.lbl_pseudo);
            this.tabPage1.Controls.Add(this.btn_modifProfil);
            this.tabPage1.Controls.Add(this.lbl_nom);
            this.tabPage1.Controls.Add(this.pbFbPicture);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(793, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mon compte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(24, 100);
            this.lbl_birthdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(64, 13);
            this.lbl_birthdate.TabIndex = 5;
            this.lbl_birthdate.Text = "lbl_birthdate";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(115, 52);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "lbl_email";
            // 
            // lbl_pseudo
            // 
            this.lbl_pseudo.AutoSize = true;
            this.lbl_pseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pseudo.Location = new System.Drawing.Point(335, 32);
            this.lbl_pseudo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pseudo.Name = "lbl_pseudo";
            this.lbl_pseudo.Size = new System.Drawing.Size(86, 20);
            this.lbl_pseudo.TabIndex = 3;
            this.lbl_pseudo.Text = "lbl_pseudo";
            // 
            // btn_modifProfil
            // 
            this.btn_modifProfil.Location = new System.Drawing.Point(7, 327);
            this.btn_modifProfil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modifProfil.Name = "btn_modifProfil";
            this.btn_modifProfil.Size = new System.Drawing.Size(162, 29);
            this.btn_modifProfil.TabIndex = 2;
            this.btn_modifProfil.Text = "Modifier mon profil";
            this.btn_modifProfil.UseVisualStyleBackColor = true;
            this.btn_modifProfil.Click += new System.EventHandler(this.btn_modifProfil_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(115, 30);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(43, 13);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "lbl_nom";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(793, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mes amis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amis,
            this.Nom,
            this.Etat});
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(793, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mes discussions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_deco
            // 
            this.btn_deco.Location = new System.Drawing.Point(671, 396);
            this.btn_deco.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deco.Name = "btn_deco";
            this.btn_deco.Size = new System.Drawing.Size(135, 21);
            this.btn_deco.TabIndex = 2;
            this.btn_deco.Text = "Déconnexion";
            this.btn_deco.UseVisualStyleBackColor = true;
            this.btn_deco.Click += new System.EventHandler(this.btn_deco_Click);
            // 
            // Amis
            // 
            this.Amis.HeaderText = "Pseudo";
            this.Amis.Name = "Amis";
            this.Amis.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Etat
            // 
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            this.Etat.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rechercher un ami";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(446, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 425);
            this.Controls.Add(this.btn_deco);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFbPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFbPicture;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Button btn_deco;
        private System.Windows.Forms.Button btn_modifProfil;
        private System.Windows.Forms.Label lbl_pseudo;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}