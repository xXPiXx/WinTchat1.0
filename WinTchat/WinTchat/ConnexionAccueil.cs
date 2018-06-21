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

namespace WinTchat
{
    public partial class ConnexionAccueil : Form
    {
        private const string AppId = "145842399616974";

        /// <summary>
        /// Extended permissions is a comma separated list of permissions to ask the user.
        /// </summary>
        /// <remarks>
        /// For extensive list of available extended permissions refer to 
        /// https://developers.facebook.com/docs/reference/api/permissions/
        /// </remarks>
        private const string ExtendedPermissions = "public_profile";
        public ConnexionAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCoCompte_Click(object sender, EventArgs e)
        {

        }

        private void btnCoFb_Click(object sender, EventArgs e)
        {
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
                //var dlg = new InfoDialog(facebookOAuthResult.AccessToken);
                //dlg.ShowDialog();
                MessageBox.Show("Connexion établie");
                var dlg = new Menu(facebookOAuthResult.AccessToken);
                dlg.ShowDialog();
            }
            else
            {
                // for some reason we failed to get the access token.
                // most likely the user clicked don't allow.
                MessageBox.Show(facebookOAuthResult.ErrorDescription);
            }
        }
    }
}
