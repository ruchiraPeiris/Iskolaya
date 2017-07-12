using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskolaya
{

    class MysqlConn
    {

        public MySqlCommand command;
        public MySqlDataReader mdr;
        public string query;
        public string con = "datasource=localhost;port=3306;username=root;password=ruchira";
    }
}
