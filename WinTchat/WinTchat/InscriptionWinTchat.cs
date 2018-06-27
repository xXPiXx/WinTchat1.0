using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WinTchat
{
    public partial class InscriptionWinTchat : Form
    {
        public InscriptionWinTchat()
        {
            InitializeComponent();
        }

        private void InscriptionWinTchat_Load(object sender, EventArgs e)
        {
            cb_langue.SelectedItem = "Français";
            cb_pays.SelectedItem = "France";
        }

        private void btn_inscrire_Click(object sender, EventArgs e)
        {
            if (!tb_email.Text.Contains("@"))
            {
                MessageBox.Show("Votre adresse email n'est pas valide");
                if (!tb_mdp.Text.Equals(tb_mdpConf.Text))
                {
                    MessageBox.Show("Les mots de passe ne sont pas identiques");
                    if (tb_pseudo.Text.Equals("") || tb_prenom.Text.Equals("") || tb_nom.Text.Equals("") || tb_mdpConf.Text.Equals("") || tb_mdp.Text.Equals("") || cb_langue.Text.Equals("") || cb_pays.Text.Equals("") || tb_email.Text.Equals(""))
                        MessageBox.Show("Vous avez oublié de remplir un des champs...");
                }
            }
            else
            {
                try
                {
                    var connectionString = "mongodb://109.0.171.86:33333";
                    var client = new MongoClient(connectionString);

                    IMongoDatabase dbWintchat = client.GetDatabase("Wintchat");
                    var BsonAuth_Users = dbWintchat.GetCollection<BsonDocument>("Auth_Users");

                    BsonDocument new_user_ano = new BsonDocument
                    {
                    { "pseudo", tb_pseudo.Text },
                    { "password", tb_mdpConf.Text },
                    { "full_name", tb_prenom.Text + " " + tb_nom.Text },
                    { "birth_date", dtp_naissance.Text },
                    { "pays", cb_pays.Text },
                    { "Langue", cb_langue.Text },
                    { "facebookid", "null" },
                    { "email", tb_email.Text },
                    { "join_date", DateTime.Now.ToString() },
                    { "is_connected", "false" },
                    };
                    BsonAuth_Users.InsertOneAsync(new_user_ano);

                    MessageBox.Show("Inscription effectuée !!");

                    Close();
                }
                catch
                {
                    MessageBox.Show("Le serveur WinTchat est actuellement injoignable.");
                }
            }
        }

        private void tb_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void tb_prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void tb_pseudo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void tb_mdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void tb_mdpConf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void tb_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
