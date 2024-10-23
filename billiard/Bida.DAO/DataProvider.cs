using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bida.DAO
{
    class DataProvider
    {
        public static string onStr = @"Server=DESKTOP-5N3G6R3\MSSQLSERVER01;Database=Bida;Integrated Security=True;";

        SqlConnection conn;
        private SqlCommand command;

        public DataProvider()
        {
            conn = new SqlConnection(onStr);
        }

        public void Connect()
        {
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine("Connection error: " + ex.Message);
                throw;
            }
        }
        public void Disconnect()
        {
            conn.Close();
        }
        public SqlDataReader ExcuteReader(String sql)
        {
            command = new SqlCommand(sql, conn);
            return command.ExecuteReader();
        }
        public void executeNonQuery(string sql)
        {
            this.command = new SqlCommand(sql, conn);
            this.command.ExecuteNonQuery();
        }
    }
}
