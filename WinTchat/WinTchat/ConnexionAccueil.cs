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

namespace WinTchat
{
    public partial class ConnexionAccueil : Form
    {
        IMongoDatabase dbWintchat;
        private const string AppId = "145842399616974";

        /// <summary>
        /// Extended permissions is a comma separated list of permissions to ask the user.
        /// </summary>
        /// <remarks>
        /// For extensive list of available extended permissions refer to 
        /// https://developers.facebook.com/docs/reference/api/permissions/
        /// </remarks>
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
            // open the Facebook Login Dialog and ask for user permissions.
            var fbLoginDlg = new FbLogin(AppId, ExtendedPermissions);
            fbLoginDlg.ShowDialog();

            // The user has taken action, either allowed/denied or cancelled the authorization,
            // which can be known by looking at the dialogs FacebookOAuthResult property.
            // Depending on the result take appropriate actions.
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
                    { "password", "123456Ano" },
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
                // the user closed the FacebookLoginDialog, so do nothing.
                MessageBox.Show("Cancelled!");
                return;
            } 

            // Even though facebookOAuthResult is not null, it could had been an 
            // OAuth 2.0 error, so make sure to check IsSuccess property always.
            if (facebookOAuthResult.IsSuccess)
            {
                // since our respone_type in FacebookLoginDialog was token,
                // we got the access_token
                // The user now has successfully granted permission to our app.

                var dlg = new Menu(facebookOAuthResult.AccessToken, this, "" ,dbWintchat);
                dlg.ShowDialog();
            }
            else
            {
                // for some reason we failed to get the access token.
                // most likely the user clicked don't allow.
                MessageBox.Show(facebookOAuthResult.ErrorDescription);
            }
        }

        private void ConnexionAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
