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
        int ids = 0;
        int idr = 3;
        public espaceAdmin(string login, int id)
        {
            InitializeComponent();
            adminLogin.Text = login;
            ShowAdminSite();
            ShowAdmin();
             ids = id;
            ShowMessages(id, idr);

        }
        public void ShowAdminSite()
        {

            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.CommandText = "SELECT * FROM admins where A_a = '0' ";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listAdminSite.Items.Add(reader.GetString(1));
            }

            Connection.db.Close();
        }
        public void ShowAdmin()
        {

            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@login", adminLogin.Text);
            command.CommandText = "SELECT * FROM admins where login != @login AND A_a ='1'";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listAdmin.Items.Add(reader.GetString(1));
                //tableLayoutPanel1.Controls.Add(new Label() { Text = reader.GetString(0)});
            }
            Connection.db.Close();
        }

        public void ShowMessages(int sender, int recipient)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoSize = false;
            flowLayoutPanel1.Size = new Size(446, 309);
            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@idsender",sender);
            command.Parameters.AddWithValue("@idrecipient", recipient);
           
            command.CommandText = "SELECT * FROM chatbox JOIN admins ON admins.id = chatbox.id_sender ORDER BY date_time";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((Convert.ToInt32(reader.GetString(1)) == sender && Convert.ToInt32(reader.GetString(2)) == recipient) || (Convert.ToInt32(reader.GetString(1)) == recipient && Convert.ToInt32(reader.GetString(2)) == sender))
                {
                    flowLayoutPanel1.Controls.Add(
                       new Label()
                       {
                           Text = "\n" + reader.GetString(7) + "\n" + reader.GetString(3) + "\n" + reader.GetString(4) + "\n_____________________________\n",
                           AutoSize = true
                       }
                        );
                }
            }
            Connection.db.Close();
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

        private void espaceAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void espaceAdmin_Load(object sender, EventArgs e)
        {

        }

        private void changerDeMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificationDeProfil mp = new modificationDeProfil(adminLogin.Text);
            mp.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void deSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewwebsiteadmin ana = new addnewwebsiteadmin(adminLogin.Text);
            ana.Show();
        }
        //when he start typing..
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            send_btn.Enabled = true;
        }

        //when he select a contact in listadmin 
        //the name of this contact is printed on the box
        private void listAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            box.Text = listAdmin.SelectedItems.ToString();
            foreach (var item in listAdmin.SelectedItems)
            {
                box.Text = item.ToString();
            }
            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@login", box.Text);

            command.CommandText = "SELECT id FROM admins where login = @login  ";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idhide.Text = reader.GetString(0);
            }
            Connection.db.Close();
            idr = Convert.ToInt32(idhide.Text);
            ShowMessages(ids, idr);
        }
        //when he select a contact in listadminsite 
        //the name of those contact is printed on the box
        private void listAdminSite_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            box.Text = listAdminSite.SelectedItems.ToString();
            foreach (var item in listAdminSite.SelectedItems)
            {
                box.Text = item.ToString();
            }
            Connection.db.Open();

            MySqlCommand command = Connection.db.CreateCommand();
            command.Parameters.AddWithValue("@login", box.Text);

            command.CommandText = "SELECT id FROM admins where login = @login";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                idhide.Text = reader.GetString(0);
            }
            Connection.db.Close();
            idr = Convert.ToInt32(idhide.Text);
            ShowMessages(ids, idr);
        }
        //when the user hit the send btn
        private void send_btn_Click(object sender, EventArgs e)
        {
            //if the text the textBox is empty
            if (message.TextLength == 0)
            {
                MessageBox.Show("Champ Message est vide");
            }
            else
            {
                try
                {
                    Connection.db.Open();
                    MySqlCommand command = Connection.db.CreateCommand();
                    command.Parameters.AddWithValue("@idsender", ids);
                    command.Parameters.AddWithValue("@idrecipient", idr);
                    command.Parameters.AddWithValue("@content", message.Text);
                    command.CommandText = "INSERT INTO chatbox(id_sender, id_recipient, content,date_time,lu) VALUES (@idsender , @idrecipient, @content, NOW(),'0')";
                    command.ExecuteNonQuery();
             /*       if (command.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("Insertion effectué");
                    }
                    else
                    {
                        MessageBox.Show("Insertion non effectué");
                    }*/
                }
                catch
                {
                    MessageBox.Show("db problems");
                }
                Connection.db.Close();
                message.Text = "";

                ShowMessages(ids, idr);
            }
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

        private void duLogicielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAdminCreation nA = new  NewAdminCreation();
            nA.Show();
        }

        private void uneNouvelleLibrairieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewlibBib adl = new addnewlibBib(adminLogin.Text);
            adl.Show();
        }

        private void uneNouvelleAdresseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewadress adnadr = new addnewadress(adminLogin.Text);
            adnadr.Show();
        }

        private void leStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void publierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uneAnnonceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            annonce an = new annonce();
            an.Show();
        }

        private void paramètreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restockageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            livrecommandes lc = new livrecommandes();
            lc.Show();
        }

        private void ajouterUnLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutLivre al = new AjoutLivre();
            al.Show();
        }
    }
}
