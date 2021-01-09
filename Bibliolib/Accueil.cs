using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Bibliolib
{
    public partial class espaceAdmin : Form
    {
        Thread th;
        private static MySqlConnection db = new MySqlConnection("database=bibliolib;server=localhost;user id = root; pwd=");
       
        public espaceAdmin(string login)
        {
            InitializeComponent();
            adminLogin.Text = login;

       
            /*Controls.Add(labeladd);
            listeAdmin.Controls.Add( labeladd);*/
            db.Open();
            
            MySqlCommand command = db.CreateCommand();
            command.CommandText = "SELECT login  FROM admin_site";
            MySqlDataReader reader = command.ExecuteReader();
           
            List <Label> labels = new List<Label>();
            while (reader.Read())
            {
                var add = new Label();
                add.Text = reader.GetString(0);

                add.Show();
                listeAdmin.Controls.Add(add);
                labels.Add(add);
            }
            db.Close();
            foreach (Label lab in labels)
            {
                listeAdmin.Controls.Add(lab);
                /* Label lab2 = new Label();
                 lab2.Text = "\n";
                 listeAdmin.Controls.Add(lab2);*/
            }

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewConnexion);
            th.Start();
        }
        private void openNewConnexion(object obj)
        {
            Application.Run(new Connexion());
        }

        private void espaceAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void espaceAdmin_Load(object sender, EventArgs e)
        {

        }

        private void changerDeMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void deSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
