using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    class DBConnection
    {
        SqlConnection sqlConn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=dbControleFrotasDev;Trusted_Connection=True;");

        public SqlConnection getSqlConn()
        {
            return this.sqlConn;
        }

        public DBConnection()
        {

        }

        public void open()
        {
            sqlConn.Open();
        }

        public void close()
        {
            sqlConn.Close();
        }
    }
}
