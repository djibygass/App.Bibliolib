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
using BCrypt.Net;

namespace Bibliolib
{
    public partial class NewAdminCreation : Form
    {
        public NewAdminCreation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Alogin.Text == "" || Apassword.Text == "")
            {
                MessageBox.Show("Merci de remplir tous les champs");
            }
            else
            {
                string Tpassword = BCrypt.Net.BCrypt.HashPassword(Apassword.Text);
                try
                {
                    Connection.db.Open();
                    MySqlCommand command = Connection.db.CreateCommand();

                    command.Parameters.AddWithValue("@login", Alogin.Text);
                    command.Parameters.AddWithValue("@password", Tpassword);
                    command.CommandText = "INSERT INTO  admins(login, password,A_a) VALUES  (@login, @password, '1')";
                    command.ExecuteReader();

                    Connection.db.Close();
                    Alogin.Text = "";
                    Apassword.Text = "";
                    MessageBox.Show("Vous avez ajoutez un nouvel admin");
                }
                catch
                {
                    MessageBox.Show("connexion échouée");
                }
            }
         
        
        }
    }
}
