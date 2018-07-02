using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Security.Cryptography;

namespace WinTchat
{
    public partial class ConnexionAccueil : Form
    {
        IMongoDatabase dbWintchat;
        private const string AppId = "145842399616974";
        
        /// https://developers.facebook.com/docs/reference/api/permissions/
       
        private const string ExtendedPermissions = "public_profile,email,user_birthday";
        public ConnexionAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCoCompte_Click(object sender, EventArgs e)
        {
            Hide();
            var CoCompte = new Connexion_WinTchat(this);
            CoCompte.ShowDialog();
        }

        private void btnCoFb_Click(object sender, EventArgs e)
        {
            Hide();
            ConnexionAccueil ca = this;
            
            var fbLoginDlg = new FbLogin(AppId, ExtendedPermissions);
            fbLoginDlg.ShowDialog();
           
            TakeLoggedInAction(fbLoginDlg.FacebookOAuthResult);
        }

        private void btnCoAnonyme_Click(object sender, EventArgs e)
        {
            Hide();
            try
            {
                var connectionString = "mongodb://109.0.171.86:33333";
                var client = new MongoClient(connectionString);

                dbWintchat = client.GetDatabase("Wintchat");
                var BsonAuth_Users = dbWintchat.GetCollection<BsonDocument>("Auth_Users");
                string pseudo = "anonyme" + ObjectId.GenerateNewId();

                BsonDocument new_user_ano = new BsonDocument
                {
                    { "pseudo", pseudo },
                    { "password", ComputeSha256Hash("123456Ano") },
                    { "full_name", "John Doe" },
                    { "birth_date", "null" },
                    { "pays", "Anonyme" },
                    { "Langue", "Anonyme" },
                    { "facebookid", "null" },
                    { "email", "Anonyme" },
                    { "join_date", "Anonyme" },
                    { "is_connected", "true" },
                };
                BsonAuth_Users.InsertOneAsync(new_user_ano);

                Menu m = new Menu("0", this, pseudo, dbWintchat);
                m.Show();
            }
            catch
            {
                MessageBox.Show("Le serveur WinTchat est actuellement injoignable.");
            }
        }

        private void TakeLoggedInAction(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult == null)
            {                
                MessageBox.Show("Cancelled!");
                return;
            }
           
            if (facebookOAuthResult.IsSuccess)
            {                
                var dlg = new Menu(facebookOAuthResult.AccessToken, this, "" ,dbWintchat);
                dlg.ShowDialog();
            }
            else                     
                MessageBox.Show(facebookOAuthResult.ErrorDescription);            
        }

        private void ConnexionAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        static string ComputeSha256Hash(string rawData)
        {           
            using (SHA256 sha256Hash = SHA256.Create())
            {                
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
 
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
