using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Data.Database
{
    public class Adapter
    {
        private SqlConnection? _sqlConnection;

        public void OpenConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["ConnStringLocal"].ConnectionString;
            _sqlConnection = new SqlConnection(connString);
            _sqlConnection.Open();
        }

        public void CloseConnection()
        {
            _sqlConnection?.Close();
            _sqlConnection = null;
        }
    }
}
