using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ATM
{
    public class DBConnection
    {
        private string connectionString = null;
        private SqlConnection sqlConn = null;

        public DBConnection()
        {
            connectionString = @"Data Source=MONOWAR-PC\SQLEXPRESS; Initial Catalog=ATMDB; User ID=sa; Password=1234";
            sqlConn = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection
        {
            get
            {
                return sqlConn;
            }
            private set
            {
            }
        }
    }
}
