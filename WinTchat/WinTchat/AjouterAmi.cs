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
    public partial class AjouterAmi : Form
    {
        string pseudo = "";
        public AjouterAmi(string _pseudo)
        {
            InitializeComponent();
            pseudo = _pseudo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://109.0.171.86:33333";
            var client = new MongoClient(connectionString);

            IMongoDatabase dbWintchat = client.GetDatabase("Wintchat");
            var BsonAuth_Users = dbWintchat.GetCollection<BsonDocument>("Auth_Users");

            var ListAuth_Users = BsonAuth_Users.Find(_ => true).ToList();

            var user_exist = false;

            var pseudo_to_add = textBox1.Text;

            for (int i = 0; i < ListAuth_Users.Count; i++)
            {
                if(pseudo_to_add == ListAuth_Users[i][1])
                {
                    user_exist = true;
                }
            }

            if (!user_exist)
            {
                MessageBox.Show("Le pseudo ne donne aucun résultat.");
            }
            else
            {
                var BsonFriends = dbWintchat.GetCollection<BsonDocument>("Friends");
                BsonDocument new_friend = new BsonDocument
                    {
                    { "pseudo1", pseudo },
                    { "pseudo2", pseudo_to_add },
                    };

                BsonFriends.InsertOneAsync(new_friend);

                MessageBox.Show("Ami ajouté !");

                Close();
            }

        }
    }
}
