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
        private static MySqlConnection db = new MySqlConnection("database=bibliolib;server=localhost;user id = root; pwd=");
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
            try
            {
                db.Open();
                MySqlCommand command = db.CreateCommand();

                command.Parameters.AddWithValue("@login", login.Text);
                command.Parameters.AddWithValue("@password", password.Text);
                command.CommandText = "SELECT login FROM admin where login =  (@login) AND password = (@password)";
                MySqlDataReader reader = command.ExecuteReader();
                Boolean check = false;
                while (reader.Read())
                {
                    check = true;
                }

                if (check == true)
                {
                    this.Hide();
                    espaceAdmin eA = new espaceAdmin(reader.GetString(0));
                    eA.Show(); 
                 }
                 else
                 {
                     MessageBox.Show("login ou mot de passe erroné");
                 }
                
                db.Close();
            }
            catch
            {
                MessageBox.Show("connexion échouée");
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
