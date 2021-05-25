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
    public partial class addnewadress : Form
    {
        public addnewadress(string login)
        {
            InitializeComponent();
            Adminlogin5.Text = login;
        }

  /*      public bool checkAdresse()
        {
            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@idsender", sender);
            command.Parameters.AddWithValue("@idrecipient", recipient);

            command.CommandText = "SELECT * FROM adresses WHERE numero = @numero AND rue = @rue";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((Convert.ToInt32(reader.GetString(1)) == sender && Convert.ToInt32(reader.GetString(2)) == recipient) || (Convert.ToInt32(reader.GetString(1)) == recipient && Convert.ToInt32(reader.GetString(2)) == sender))
                {
                    flowLayoutPanel1.Controls.Add(
                       new Label()
                       {
                           Text = "\n" + reader.GetString(6) + "\n" + reader.GetString(3) + "\n" + reader.GetString(4) + "\n_____________________________\n",
                           AutoSize = true
                       }
                        );
                }
            }
            Connection.db.Close();
            return false;
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (numero.Text.Trim().Length !=0 && rue.Text.Trim().Length != 0 && ville.Text.Trim().Length != 0 && zip.Text.Trim().Length != 0)
            {
                if ( Int32.TryParse(numero.Text, out int num) && Int32.TryParse(zip.Text, out int ziip))
                {
                    Connection.db.Open();

                    MySqlCommand command = Connection.db.CreateCommand();
                    command.Parameters.AddWithValue("@numero", num);
                    command.Parameters.AddWithValue("@rue", rue.Text);
                    command.Parameters.AddWithValue("@ville", ville.Text);
                    command.Parameters.AddWithValue("@zip", ziip);

                    command.CommandText = "INSERT INTO adresses(numero, rue, ville, codepostal) VALUES (@numero,@rue,@ville,@zip)";
                    command.ExecuteNonQuery();
                    Connection.db.Close();
                    numero.Text = "";
                    rue.Text = "";
                    ville.Text = "";
                    zip.Text = "";
                    MessageBox.Show("Vous avez ajouté une nouvelle adresse, reste à lui attribuer un établissement");
                }
                else
                {
                    MessageBox.Show("Erreur, Veuillez à Rentrer des information Valide.");
                }
            }
            else
            {
                MessageBox.Show("Erreur, un des Champs est vide");
            }
        }

        private void addnewadress_Load(object sender, EventArgs e)
        {

        }
    }
}
