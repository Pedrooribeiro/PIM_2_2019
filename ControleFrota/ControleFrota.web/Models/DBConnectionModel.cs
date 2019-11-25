using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ControleFrota.web.Models
{
    public class DBConnectionModel
    {
        public class DBConnection
        {
            SqlConnection sqlConn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=dbControleFrotas;Trusted_Connection=True");
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
}