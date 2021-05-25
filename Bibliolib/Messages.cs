using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bibliolib
{
    /*   class Messages
       {
           public void ShowMessages(int sender, int recipient)
           {
               flowLayoutPanel1.Controls.Clear();
               flowLayoutPanel1.AutoSize = false;
               flowLayoutPanel1.Size = new Size(446, 309);
               Connection.db.Open();

               MySqlCommand command = Connection.db.CreateCommand();
               command.Parameters.AddWithValue("@idsender", sender);
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
                              Text = "\n" + reader.GetString(6) + "\n" + reader.GetString(3) + "\n" + reader.GetString(4) + "\n_____________________________\n",
                              AutoSize = true
                          }
                           );
                   }
               }
               Connection.db.Close();
           }
       }*/
}
