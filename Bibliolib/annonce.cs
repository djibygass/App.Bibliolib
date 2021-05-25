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
    public partial class annonce : Form
    {
        public annonce()
        {
            InitializeComponent();
        }

        private void annonce_Load(object sender, EventArgs e)
        {

        }

        private void btn_publier_Click(object sender, EventArgs e)
        {
            if (textBox_titre.Text.Trim() == "" || textBox_Contenu.Text.Trim() == "")
            {
                MessageBox.Show("Merci de remplir tous les champs");
            }
            else
            {
                try
                {
                    Connection.db.Open();
                    MySqlCommand command = Connection.db.CreateCommand();

                    command.Parameters.AddWithValue("@titre", textBox_titre.Text);
                    command.Parameters.AddWithValue("@contenu", textBox_Contenu.Text);
                    command.CommandText = "INSERT INTO  annonces(titre, contenu,date_time) VALUES  (@titre, @contenu,NOW())";
                    command.ExecuteReader();

                    Connection.db.Close();
                    textBox_Contenu.Text = "";
                    textBox_titre.Text = "";
                    MessageBox.Show("Vous avez publié une nouvelle annonce");
                }
                catch
                {
                    MessageBox.Show("connexion échouée");
                }
            }
            

        }
    }
}
