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
    public partial class addnewlibBib : Form
    {
        public addnewlibBib(string login)
        {
            InitializeComponent();
            Adminlogin4.Text = login;
            showAdress();
            showAdminSite();
        }
        public void showAdress()
        {
            try
            {
                Connection.db.Open();

                MySqlCommand command = Connection.db.CreateCommand();

                command.CommandText = "SELECT * FROM adresses WHERE att is NULL";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxAdress.Items.Add(reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4));
                }
                Connection.db.Close();
            }
            catch
            {
                MessageBox.Show("connexion échouée");
            }
        }

        public void showAdminSite()
        {
            try
            {
                Connection.db.Open();

                MySqlCommand command = Connection.db.CreateCommand();

                command.CommandText = "SELECT * FROM admins WHERE A_a = '0' and att is NULL";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxAdminsite.Items.Add(reader.GetString(1));
                }
                Connection.db.Close();
            }
            catch
            {
                MessageBox.Show("connexion échouée");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


           
        
        }
        public int returnIdAdress(string num, string zip, string city, string adjoin)
        {
            string idadress = "";
            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@numero", Convert.ToInt32(num));
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@zip", Convert.ToInt32(zip));
            command.Parameters.AddWithValue("@adname", adjoin.TrimEnd().TrimStart());
            command.CommandText = "SELECT id FROM adresses WHERE numero = @numero AND rue LIKE @adname AND  ville = @city AND codepostal = @zip";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idadress = reader.GetString(0);
            }
            Connection.db.Close();
            return Convert.ToInt32(idadress);
        }

        public int returnIdAdmins(string adminlog)
        {
            string idadmin = "";
            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@login", adminlog);

            command.CommandText = "SELECT id FROM admins WHERE login = @login AND A_a = '0'";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idadmin = reader.GetString(0);
            }
            Connection.db.Close();
            return Convert.ToInt32(idadmin);
         
        }

        public void newBib(int idadress, int idAdminSite)
        {
            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@idadmin", idAdminSite);
            command.Parameters.AddWithValue("@idadress", idadress);

            command.CommandText = "INSERT INTO bibliotheques(id_adresse, id_adminsite) VALUES (@idadress,@idadmin)";
            command.ExecuteNonQuery();
            Connection.db.Close();

        }

        public void newLib(int idadress, int idAdminSite)
        {
            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@idadmin", idAdminSite);
            command.Parameters.AddWithValue("@idadress", idadress);

            command.CommandText = "INSERT INTO librairies(id_adresse, id_adminsite) VALUES (@idadress,@idadmin)";
            command.ExecuteNonQuery();
            Connection.db.Close();

        }
        public void attUpdateAdress(int idadress)
        {
            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@idadress", idadress);

            command.CommandText = "UPDATE adresses SET att = '1' WHERE id = @idadress";
            command.ExecuteNonQuery();
            Connection.db.Close();

        }

        public void attUpdateAdmins(int idadmin)
        {
            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@idadmins", idadmin);

            command.CommandText = "UPDATE admins SET att = '1' WHERE id = @idadmins AND A_a = '0' ";
            command.ExecuteNonQuery();
            Connection.db.Close();

        }

        public void refresh()
        {
            var newlog = Adminlogin4.Text;
            this.Close();
            addnewlibBib adn = new addnewlibBib(newlog); 
            adn.Show();
        }
        private void comboBoxAdminsite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
 
            if (comboBoxAdress.Text.Trim().Length != 0 && comboBoxAdminsite.Text.Trim().Length !=0)
            {
                string[] adress = comboBoxAdress.Text.Split(' ');
                string num = adress[0];
                string zip = adress[adress.Length - 1];
                string city = adress[adress.Length - 2];
                

                adress[0] = "";
                adress[adress.Length - 1] = "";
                adress[adress.Length - 2] = "";

                string adjoin = String.Join(" ", adress);
                
                  /*  MessageBox.Show(num + zip + city);
                    MessageBox.Show(adjoin);*/
                if (checkBoxbib.Checked == true && checkBoxlib.Checked == true)
                {

                   DialogResult result = MessageBox.Show("êtes-vous sur de vouloir créer une Bibliothèque et une librairie dans le même Etablissment ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                       
                        int idadr = returnIdAdress(num, zip, city, adjoin);
                        int idad = returnIdAdmins(comboBoxAdminsite.Text);
                        newBib(idadr, idad);
                        newLib(idadr, idad);
                        attUpdateAdress(idadr);
                        attUpdateAdmins(idad);
                        MessageBox.Show("Vous avez créer un nouvel établissment");
                        refresh();
                    }
                    if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Opération Annulée");
                    }

                }
               else if (checkBoxbib.Checked == true && checkBoxlib.Checked == false)
                {
                    DialogResult result = MessageBox.Show("êtes-vous sûre de vouloir créer une nouvelle Bibliothèque ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {

                        int idadr = returnIdAdress(num, zip, city, adjoin);
                        int idad = returnIdAdmins(comboBoxAdminsite.Text);
                        newBib(idadr, idad);
                        attUpdateAdress(idadr);
                        attUpdateAdmins(idad);
                        MessageBox.Show("Vous avez créer une nouvelle Bibliothèque");
                        refresh();
                    }
                    if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Opération Annulée");
                    }
                }
               else if (checkBoxbib.Checked == false && checkBoxlib.Checked == true)
                {
                    DialogResult result = MessageBox.Show("êtes-vous sûre de vouloir créer une nouvelle Librairie ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {

                        int idadr = returnIdAdress(num, zip, city, adjoin);
                        int idad = returnIdAdmins(comboBoxAdminsite.Text);
                        newLib(idadr, idad);
                        attUpdateAdress(idadr);
                        attUpdateAdmins(idad);
                        MessageBox.Show("Vous avez créer une nouvelle Libriarie");
                        refresh();
                    }
                    if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Opération Annulée");
                    }
                }
                else
                {
                    MessageBox.Show("choisir un checkBox");
                }
            }
            else
            {
                MessageBox.Show("Veuillez à Bien choisir un gérant et une Adresse ou En créer s'il n'y a n'en pas");
            }
               
        }
    }
}
