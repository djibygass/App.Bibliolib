using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bibliolib
{
    class Connection
    {
        public static MySqlConnection db = new MySqlConnection("database=bibliolib;server=localhost;user id = root; pwd=");
           
    }
}
