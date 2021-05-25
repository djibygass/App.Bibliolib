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
    
    public partial class modificationDeProfil : Form
    {
        public modificationDeProfil(string login)
        {
            InitializeComponent();
            labelAdmin1.Text = login;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChangeLogin.Enabled = true;
        }

        private void ChangeLogin_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            try
            {
                Connection.db.Open();
                MySqlCommand command = Connection.db.CreateCommand();

                command.Parameters.AddWithValue("@login", newLogin.Text);
      
                command.CommandText = "SELECT * FROM admins where login = @login AND A_a = '1' ";
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    check = true;
                }

                if (check == true)
                {
                    MessageBox.Show("Erreur, login déja existant ");
                }
       
                Connection.db.Close();
            }
            catch
            {
                MessageBox.Show("connexion échouée");
            }
            if (check == false)
            {
                if (newLogin.Text.Trim().Length !=0)
                {
                    Connection.db.Open();
                    MySqlCommand command = Connection.db.CreateCommand();

                    command.Parameters.AddWithValue("@login", labelAdmin1.Text);
                    command.Parameters.AddWithValue("@newLogin", newLogin.Text.Trim());
                    command.CommandText = "UPDATE admins set login = @newLogin where login = @login AND A_a='1' ";
                    command.ExecuteNonQuery();

                    Connection.db.Close();
                    MessageBox.Show("Votre login a été modifier");
                }
                else
                {
                    MessageBox.Show("Erreur, Champs non valide");
                }
            }

        }
      
        private void actualPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void newPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {
                changePassword.Enabled = true;
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            var passhash = "";
            if (actualPassword.Text.Trim().Length != 0 && newPassword.Text.Trim().Length != 0 && confirmPassword.Text.Trim().Length != 0 && newPassword.Text == confirmPassword.Text) 
            {
                
                Connection.db.Open();
                MySqlCommand command = Connection.db.CreateCommand();

                command.Parameters.AddWithValue("@login", labelAdmin1.Text);
                command.CommandText = "SELECT password FROM  admins WHERE login = @login AND A_a = '1' ";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    passhash = reader.GetString(0);
                }

                Connection.db.Close();
                if (BCrypt.Net.BCrypt.Verify(actualPassword.Text, passhash))
                {
                    string password = BCrypt.Net.BCrypt.HashPassword(newPassword.Text);
                    Connection.db.Open();
                    MySqlCommand cmd = Connection.db.CreateCommand();

                    cmd.Parameters.AddWithValue("@login", labelAdmin1.Text);
                    cmd.Parameters.AddWithValue("@newPassword", password);
                    cmd.CommandText = "UPDATE admins set password = @newPassword where login = @login AND A_a = '1' ";
                    cmd.ExecuteNonQuery();

                    Connection.db.Close();
                    MessageBox.Show("Mot de passe modifié");
                    actualPassword.Text = "";
                    newPassword.Text = "";
                    confirmPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                }

          
            }
            else
             {
                MessageBox.Show("Erreur, les champs rentrés sont invalides");
            }
        }
    }
}
