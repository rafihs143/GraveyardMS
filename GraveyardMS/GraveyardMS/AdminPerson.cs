using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace GraveyardMS
{
    class AdminPerson:IDisposable
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public AdminPerson()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2[A]"].ConnectionString);
            connection.Open();
        }
        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
        }
        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            connection.Close();
        }

    }
  
}
