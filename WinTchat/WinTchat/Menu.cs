using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;

namespace WinTchat
{
    public partial class Menu : Form
    {
        private readonly TaskScheduler _ui;
        private readonly string _accessToken;
        public Menu(string accessToken)
        {
            _accessToken = accessToken;
            _ui = TaskScheduler.FromCurrentSynchronizationContext();

            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (_accessToken.Equals("0"))
            {

            }
            else
            { 
            GetUserProfilePicture();
            RecuperationDonnees();
            }
        }

        private void GetUserProfilePicture()
        {
            // note: avoid using synchronous methods if possible as it will block the thread until the result is received

            try
            {
                var fb = new FacebookClient(_accessToken);

                // Note: the result can either me IDictionary<string,object> or IList<object>
                // json objects with properties can be casted to IDictionary<string,object> or IDictionary<string,dynamic>
                // json arrays can be casted to IList<object> or IList<dynamic>

                // for this particular request we can guarantee that the result is
                // always IDictionary<string,object>.
                var result = (IDictionary<string, object>)fb.Get("me");

                // make sure to cast the object to appropriate type
                var id = (string)result["id"];

                // FacebookClient's Get/Post/Delete methods only supports JSON response results.
                // For non json results, you will need to use different mechanism,

                // here is an example for pictures.
                // available picture types: square (50x50), small (50xvariable height), large (about 200x variable height) (all size in pixels)
                // for more info visit http://developers.facebook.com/docs/reference/api
                string profilePictureUrl = string.Format("https://graph.facebook.com/v3.0/{0}/picture", id);

                WebClient wc = new WebClient();

                string startupPath = Environment.CurrentDirectory;
                bool exists = System.IO.Directory.Exists(startupPath + "\\tmp");

                if (!exists)
                    System.IO.Directory.CreateDirectory(startupPath + "\\tmp");

                wc.DownloadFile(new Uri(profilePictureUrl), startupPath + "\\tmp\\profilePicture.jpg");
                ResizeImage(startupPath + "\\tmp\\profilePicture.jpg", pbFbPicture);
            }
            catch (FacebookApiException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResizeImage(string path, PictureBox pb)
        {
            // réglages des valeurs servant au calcul
            int Lmax = pb.Width;
            // IMG est le nom de ma pictureBox
            int Hmax = pb.Height;

            Image i = Image.FromFile(path);
            // objet image à partir de l'image choisie
            double ratio = (double)Lmax / Hmax;
            // ratio de base à obtenir pour rentrer correctement dans la picturebox
            double ratioImage = (double)i.Width / i.Height;
            // ratio de l'image d'origine
            double Flng = i.Width;
            // largeur de l'image d'origine
            double Fht = i.Height;
            // hauteur de l'image d'origine
            if (Flng > Lmax || Fht > Hmax)
            // si l'image est plus grande d'une quelconque longueur
            {
                if (Flng > Lmax) // si la longueur est plus longue
                {
                    if (1 > ratioImage) // et si la largueur est plus longue
                    {
                        Fht = Hmax; // la hauteur prend la hauteur maximale
                        if (Flng > i.Height) Flng = Fht / ratioImage; // calcul de la longueur 
                        else Flng = Fht * ratioImage; // calcul de la longueur (bis)
                    }
                    else // seule la largeur est plus longue
                    {
                        Flng = Lmax; // la largeur prend la largeur maximale
                        if (Fht > i.Width) Fht = Flng / ratioImage; // calcul de la hauteur
                        else Fht = Flng / ratioImage;
                    }
                }
                else // seule la largeur est plus longue
                {
                    Fht = Hmax;
                    Flng = Fht * ratioImage;
                }
                pb.Image = Image.FromFile(path).GetThumbnailImage(Convert.ToInt32
                (Flng), Convert.ToInt32(Fht), null, IntPtr.Zero); // j'en tire une miniature
            }
            else pb.Image = Image.FromFile(path); // sinon j'affiche l'image de base
        }

        private void RecuperationDonnees()
        {
            // avoid using XAsync methods as it is marked obsolete.
            // use XAsync only for .net 3.5/SL4/WP7
            // use XTaskAsync methods instead.

            var fb = new FacebookClient(_accessToken);

            // make sure to add the appropriate event handler
            // before calling the async methods.
            // GetCompleted     => GetAsync
            // PostCompleted    => PostAsync
            // DeleteCompleted  => DeleteAsync
            fb.GetCompleted += (o, e) =>
            {
                // incase you support cancellation, make sure to check
                // e.Cancelled property first even before checking (e.Error != null).
                if (e.Cancelled)
                {
                    // for this example, we can ignore as we don't allow this
                    // example to be cancelled.
                }
                else if (e.Error != null)
                {
                    // error occurred
                    this.BeginInvoke(new MethodInvoker(
                                                 () =>
                                                 {
                                                     MessageBox.Show(e.Error.Message);
                                                 }));
                }
                else
                {
                    // the request was completed successfully

                    // now we can either cast it to IDictionary<string, object> or IList<object>
                    // depending on the type.
                    // For this example, we know that it is IDictionary<string,object>.
                    var result = (IDictionary<string, object>)e.GetResultData();

                    var firstName = (string)result["first_name"];
                    var lastName = (string)result["last_name"];

                    // since this is an async callback, make sure to be on the right thread
                    // when working with the UI.
                    this.BeginInvoke(new MethodInvoker(
                                         () =>
                                         {
                                             lbl_nomPrenom.Text = "First Name: " + firstName;
                                         }));
                }
            };

            // additional parameters can be passed and 
            // must be assignable from IDictionary<string, object> or anonymous object
            var parameters = new Dictionary<string, object>();
            parameters["fields"] = "first_name,last_name";

            fb.GetAsync("me", parameters);
            // or
            //fb.GetAsync("me", new { fields = new[] { "first_name", "last_name" } });
        }
    }
}
