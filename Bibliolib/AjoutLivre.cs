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
    public partial class AjoutLivre : Form
    {
        public AjoutLivre()
        {
            InitializeComponent();
            ShowBooks();
        }
        public void ShowBooks()
        {

            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.CommandText = "SELECT * FROM Livres where stat_livre = 0 AND quantite = 0";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listBooks.Items.Add(reader.GetString(1));
                //tableLayoutPanel1.Controls.Add(new Label() { Text = reader.GetString(0)});
            }
            Connection.db.Close();
        }

        private void listBooks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedBook.Text = listBooks.SelectedItems.ToString();
            foreach (var item in listBooks.SelectedItems)
            {
                selectedBook.Text = item.ToString();
            }
           
        }

        private void selectedBook_Click(object sender, EventArgs e)
        {

        }

        private void ajouterLivre_btn_Click(object sender, EventArgs e)
        {
            if (quantite.Text.Trim().Length != 0 && selectedBook.Text != "HERE"){
                if (int.TryParse(quantite.Text, out int quantit))
                {
                    Connection.db.Open();
                    MySqlCommand command = Connection.db.CreateCommand();

                    command.Parameters.AddWithValue("@quantite", quantit);
                    command.Parameters.AddWithValue("@titre", selectedBook.Text);
                    command.CommandText = "UPDATE livres set quantite = @quantite, stat_livre = '1' where titre = @titre ";
                    command.ExecuteNonQuery();

                    Connection.db.Close();
                    MessageBox.Show(" livre ajouté");
                    this.Close();
                    AjoutLivre aj1 = new AjoutLivre();
                    aj1.Show();
                }
                else
                {
                    MessageBox.Show("Erreur, Champs non valide");
                }
            }
            else
            {
                MessageBox.Show("Veuillez à bien choisir un livre et mettre une quantite, s'il n'y a pas de livre veuillez demander à un gérant de site de faire une demande d'ajout.");
            }
        }


    }
}
