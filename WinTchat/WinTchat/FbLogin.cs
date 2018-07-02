using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Configuration;
using MongoDB.Bson.IO;
using Newtonsoft.Json;

namespace WinTchat
{
    public partial class FbLogin : Form
    {
        private readonly Uri _loginUrl;
        protected FacebookClient _fb;
        public FacebookOAuthResult FacebookOAuthResult { get; private set; }
        public FbLogin(string appId, string extendedPermissions)
            : this(new FacebookClient(), appId, extendedPermissions)
        {}
        public FbLogin(FacebookClient fb, string appId, string extendedPermissions)
        {
            if (fb == null)
                throw new ArgumentNullException("fb");
            if (string.IsNullOrWhiteSpace(appId))
                throw new ArgumentNullException("appId");

            _fb = fb;
            _loginUrl = GenerateLoginUrl(appId, extendedPermissions);

            InitializeComponent();
        }

        private Uri GenerateLoginUrl(string appId, string extendedPermissions)
        {
            dynamic parameters = new ExpandoObject();
            parameters.client_id = appId;
            parameters.redirect_uri = "https://localhost:44320/signin-facebook";         
            parameters.response_type = "token";           
            parameters.display = "popup";
                        
            if (!string.IsNullOrWhiteSpace(extendedPermissions))
                parameters.scope = extendedPermissions;
                        
            return _fb.GetLoginUrl(parameters);
        }

        private void FbLogin_Load(object sender, EventArgs e)
        {           
            wbFb.Navigate(_loginUrl.AbsoluteUri);
        }

        private void wbFb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {         
            FacebookOAuthResult oauthResult;
            if (_fb.TryParseOAuthCallbackUrl(e.Url, out oauthResult))
            {                
                FacebookOAuthResult = oauthResult;
                DialogResult = FacebookOAuthResult.IsSuccess ? DialogResult.OK : DialogResult.No;
            }
            else
                FacebookOAuthResult = null;            
        }
    }
}
