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

namespace WinTchat
{
    public partial class Connexion_WinTchat : Form
    {
        public Connexion_WinTchat()
        {
            InitializeComponent();
        }

        private void Connexion_WinTchat_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://109.0.171.86:33333";
            var client = new MongoClient(connectionString);

            IMongoDatabase dbWintchat = client.GetDatabase("Wintchat");
            var BsonAuth_Users = dbWintchat.GetCollection<BsonDocument>("Auth_Users");

            var ListAuth_Users = BsonAuth_Users.Find(_ => true).ToList();
        }
    }
}
