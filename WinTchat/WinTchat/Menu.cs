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
using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;

namespace WinTchat
{
    public partial class Menu : Form
    {
        private readonly TaskScheduler _ui;
        private readonly string _accessToken;
        ConnexionAccueil ca;
        bool deco = false;
        string pseudo = "";
        IMongoDatabase dbWinTchat;
        public Menu(string accessToken, ConnexionAccueil _ca, string _pseudo, IMongoDatabase _db)
        {
            _accessToken = accessToken;
            _ui = TaskScheduler.FromCurrentSynchronizationContext();
            ca = _ca;
            pseudo = _pseudo;
            dbWinTchat = _db;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (_accessToken.Equals("0"))
            {
                var BsonAuth_Users = dbWinTchat.GetCollection<BsonDocument>("Auth_Users");
                var builder = Builders<BsonDocument>.Filter;
                var filt = builder.Eq("pseudo", pseudo) | builder.Eq("email", pseudo);
                var list = BsonAuth_Users.Find(filt).ToList();

                lbl_pseudo.Text = list[0][1].ToString();
                lbl_nom.Text = list[0][3].ToString();
                lbl_email.Text = list[0][8].ToString();
                lbl_birthdate.Text = list[0][4].ToString();
            }
            else
            {
                GetUserProfilePicture();
                RecuperationDonnees();
            }
        }

        private void GetUserProfilePicture()
        {
            if (!_accessToken.Equals("0"))
            {
                try
                {
                    var fb = new FacebookClient(_accessToken);
                    var result = (IDictionary<string, object>)fb.Get("me");
                    var id = (string)result["id"];

                    string profilePictureUrl = string.Format("https://graph.facebook.com/v3.0/{0}/picture", id);
                    string startupPath = Environment.CurrentDirectory;
                    bool exists = System.IO.Directory.Exists(startupPath + "\\tmp");

                    WebClient wc = new WebClient();

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
            else
            {
                if (!System.IO.Directory.Exists(Environment.CurrentDirectory + "\\tmp"))
                    System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\tmp");
                else
                {

                }
            }
        }

        private void ResizeImage(string path, PictureBox pb)
        {
            int Lmax = pb.Width;
            int Hmax = pb.Height;

            Image i = Image.FromFile(path);

            double ratio = (double)Lmax / Hmax;
            double ratioImage = (double)i.Width / i.Height;
            double Flng = i.Width;
            double Fht = i.Height;

            if (Flng > Lmax || Fht > Hmax)
            {
                if (Flng > Lmax)
                {
                    if (1 > ratioImage)
                    {
                        Fht = Hmax;
                        if (Flng > i.Height) Flng = Fht / ratioImage;
                        else Flng = Fht * ratioImage;
                    }
                    else
                    {
                        Flng = Lmax;
                        if (Fht > i.Width) Fht = Flng / ratioImage;
                        else Fht = Flng / ratioImage;
                    }
                }
                else
                {
                    Fht = Hmax;
                    Flng = Fht * ratioImage;
                }
                pb.Image = Image.FromFile(path).GetThumbnailImage(Convert.ToInt32
                (Flng), Convert.ToInt32(Fht), null, IntPtr.Zero);
            }
            else pb.Image = Image.FromFile(path);
        }

        private void RecuperationDonnees()
        {
            var fb = new FacebookClient(_accessToken);

            fb.GetCompleted += (o, e) =>
            {
                if (e.Cancelled)
                { }
                else if (e.Error != null)
                {
                    this.BeginInvoke(new MethodInvoker(
                                                 () =>
                                                 {
                                                     MessageBox.Show(e.Error.Message);
                                                 }));
                }
                else
                {
                    var result = (IDictionary<string, object>)e.GetResultData();
                    var firstName = (string)result["first_name"];
                    var lastName = (string)result["last_name"];
                    var email = (string)result["email"];

                    this.BeginInvoke(new MethodInvoker(
                                         () =>
                                         {
                                             lbl_nom.Text = firstName + " " + lastName;
                                             lbl_email.Text = email;
                                         }));

                    /*var BsonAuth_Users = dbWinTchat.GetCollection<BsonDocument>("Auth_Users");
                    var builder = Builders<BsonDocument>.Filter;
                    var filt = builder.Eq("email", email);
                    var list = BsonAuth_Users.Find(filt).ToList();

                    if (list.Count == 0)
                    {
                        BsonDocument new_user_ano = new BsonDocument
                        {
                        { "pseudo", firstName[0] + lastName },
                        { "password", null },
                        { "full_name", firstName + " " + lastName },
                        { "birth_date", null },
                        { "pays", null },
                        { "Langue", null },
                        { "facebookid", _accessToken },
                        { "email", email },
                        { "join_date", DateTime.Now.ToString() },
                        { "is_connected", "true" },
                        };
                        BsonAuth_Users.InsertOneAsync(new_user_ano);
                    }*/
                }
            };

            var parameters = new Dictionary<string, object>();
            parameters["fields"] = "first_name,last_name,email";

            fb.GetAsync("me", parameters);

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!deco)
                Application.Exit();
        }

        private void btn_modifProfil_Click(object sender, EventArgs e)
        {

        }

        private void btn_deco_Click(object sender, EventArgs e)
        {
            deco = true;
            ca.Show();
            Close();
        }

        private void btn_envoyer_Click(object sender, EventArgs e)
        {
            /*var connectionString = "mongodb://109.0.171.86:33333";
            var client = new MongoClient(connectionString);

            IMongoDatabase dbWintchat = client.GetDatabase("Wintchat");
            var BsonMots_interdits = dbWinTchat.GetCollection<BsonDocument>("MotsInterdits");
            var ListMots_interdits = BsonMots_interdits.Find(_ => true).ToList();

            for(int i = 0; i < ListMots_interdits.Count;i++)
            {
                for (int j = 0; j < ListMots_interdits.Count-1; j++)
                {
                    if (ListMots_interdits[j][1].ToString().Length < ListMots_interdits[j+1][1].ToString().Length)
                    {
                        var tampon = ListMots_interdits[j+1][1];
                        ListMots_interdits[j+1][1] = ListMots_interdits[j][1];
                        ListMots_interdits[j][1] = tampon;
                    }
                }
            }

            string test = tb_mssg.Text;
            for (int i = 0; i < ListMots_interdits.Count; i++)
            {
                if (test.Contains(ListMots_interdits[i][1].ToString()))
                {

                    string remove = ListMots_interdits[i][1].ToString();

                    int j = 0;
                    j = test.IndexOf(remove);

                    test = test.Remove(j, remove.Length);
                    test = test.Insert(j, "****");

                    lbl_rep.Text = test;
                }
            }*/
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])//your specific tabname
            {
                var connectionString = "mongodb://109.0.171.86:33333";
                var client = new MongoClient(connectionString);
                IMongoDatabase dbWintchat = client.GetDatabase("Wintchat");
                var BsonFriends = dbWintchat.GetCollection<BsonDocument>("Friends");
                var ListFriends = BsonFriends.Find(_ => true).ToList();
                var BsonAuth_Users = dbWintchat.GetCollection<BsonDocument>("Auth_Users");
                var ListAuth_Users = BsonAuth_Users.Find(_ => true).ToList();
                for (int i = 0; i < ListFriends.Count; i++)
                {
                    if(ListFriends[i][1] == pseudo)
                    {
                        for (int j = 0; j < ListAuth_Users.Count; j++)
                        {
                            if (ListFriends[i][2] == ListAuth_Users[j][1])
                            {
                                var state = "";
                                if(ListAuth_Users[j][10] == "True")
                                {
                                    state = "En ligne";
                                } else
                                {
                                    state = "Déconnecté";
                                }
                                dataGridView1.Rows.Add(ListAuth_Users[j][1], ListAuth_Users[j][3], state);
                            }
                        }
                        
                   
                    } else if(ListFriends[i][2] == pseudo) {
                        for(int j = 0; j < ListAuth_Users.Count; j++)
                        {
                            if (ListFriends[i][1] == ListAuth_Users[j][1])
                            {
                                var state = "";
                                if (ListAuth_Users[j][10] == "True")
                                {
                                    state = "En ligne";
                                }
                                else
                                {
                                    state = "Déconnecté";
                                }
                                dataGridView1.Rows.Add(ListAuth_Users[j][1], ListAuth_Users[j][3], state);
                            }
                        }
                    }
                }
            }
        }
    }
}
