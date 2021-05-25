using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bibliolib
{
    public partial class Connexion : Form
    {
        //pdo
        
        public Connexion()
        {
            InitializeComponent();
        /*    panel1.Location = new Point(
             this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            var checkit = 0;
            var id = 0;
            var loginstr = "";
            var passhash = "";
            try
            {
                Connection.db.Open();
               
                MySqlCommand command = Connection.db.CreateCommand();

                  command.Parameters.AddWithValue("@login", login.Text);
                  command.Parameters.AddWithValue("@password", password.Text);
                  command.CommandText = "SELECT * FROM admins where login =  (@login) AND A_a = '1' ";
                  MySqlDataReader reader = command.ExecuteReader();
               

                  Boolean check = false;
                  while (reader.Read())
                  {
                    check = true;
                    id = Convert.ToInt32(reader.GetString(0));
                    loginstr = reader.GetString(1);
                    passhash = reader.GetString(2);
                  }

                  if (check == true && BCrypt.Net.BCrypt.Verify(password.Text, passhash))
                  {
                    checkit = 1;
                  }
                   else
                   {
                       MessageBox.Show("login ou mot de passe erroné");   
                   }

                Connection.db.Close();
            }
            catch
            {
                MessageBox.Show("connexion échouée");
            }
            if (checkit==1)
            {
                this.Hide();

                espaceAdmin eA = new espaceAdmin(loginstr,id);
                eA.Show();
            }

        }

        public void Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
