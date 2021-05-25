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
    public partial class livrecommandes : Form
    {
        public livrecommandes()
        {
            InitializeComponent();
            ShowBooks();
        }
        public void ShowBooks()
        {

            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.CommandText = "SELECT * FROM commande_livres";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listBook.Items.Add(reader.GetString(1));
            }
            Connection.db.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
