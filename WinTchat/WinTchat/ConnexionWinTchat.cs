using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Security.Cryptography;
using System.Diagnostics;

namespace WinTchat
{
    public partial class Connexion_WinTchat : Form
    {
        ConnexionAccueil ca;
        public Connexion_WinTchat(ConnexionAccueil _ca)
        {
            ca = _ca;
            InitializeComponent();
        }

        private void Connexion_WinTchat_Load(object sender, EventArgs e)
        {
            
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "mongodb://109.0.171.86:33333";
                var client = new MongoClient(connectionString);

                IMongoDatabase dbWintchat = client.GetDatabase("Wintchat");
                var BsonAuth_Users = dbWintchat.GetCollection<BsonDocument>("Auth_Users");

                var ListAuth_Users = BsonAuth_Users.Find(_ => true).ToList();

                var user_match = false;

                for (int i = 0; i < ListAuth_Users.Count; i++)
                {
                    if (tb_email.Text.Equals(ListAuth_Users[i][1].ToString()) || tb_email.Text.Equals(ListAuth_Users[i][8].ToString()))
                    {
                        Debug.WriteLine("User found");
                        if (ComputeSha256Hash(tb_mdp.Text).Equals(ListAuth_Users[i][2].ToString()))
                        {
                            user_match = true;

                        }
                    }
                    else
                        Debug.WriteLine("Tentative numero : " + i);
                        Debug.WriteLine("User requested : " + tb_email.Text);
                        Debug.WriteLine("User for loop : " + ListAuth_Users[i][8]);
                        Debug.WriteLine("Pass requested : " + ComputeSha256Hash(tb_mdp.Text));
                        Debug.WriteLine("Pass for loop : " + ListAuth_Users[i][2]);

                }
                if(user_match == true)
                {
                    MessageBox.Show("Connexion réussie");
                    Menu m = new Menu("0", ca);
                    m.Show();
                } else
                {
                    MessageBox.Show("Aucun compte ne correspond à cette adresse Email");
                }
                
            }
            catch
            {
                MessageBox.Show("Le serveur WinTchat est actuellement injoignable");
            }
        }

        private void btn_inscription_Click(object sender, EventArgs e)
        {
            InscriptionWinTchat i = new InscriptionWinTchat();
            i.Show();
        }

        private void Connexion_WinTchat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
