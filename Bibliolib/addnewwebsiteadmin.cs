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
    public partial class addnewwebsiteadmin : Form
    {
        public addnewwebsiteadmin(string login)
        {
            InitializeComponent();
            adminlogin3.Text = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Aslogin.Text.Trim() == "" || Aspassword.Text.Trim() == "")
            {
                MessageBox.Show("Merci de remplir tous les champs");
            }
            string Tpassword = BCrypt.Net.BCrypt.HashPassword(Aspassword.Text);
            try
            {
                Connection.db.Open();
                MySqlCommand command = Connection.db.CreateCommand();

                command.Parameters.AddWithValue("@login", Aslogin.Text);
                command.Parameters.AddWithValue("@password", Tpassword);
                command.CommandText = "INSERT INTO  admins(login, password,A_a) VALUES  (@login, @password, '0')";
                command.ExecuteReader();

                Connection.db.Close();
            }
            catch
            {
                MessageBox.Show("connexion échouée");
            }
            Aslogin.Text = "";
            Aspassword.Text = "";
            MessageBox.Show("Vous avez ajouté un nouvel admin");
        }
    }
    
}
