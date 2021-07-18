using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IntentoEvaluacion3.App_Code
{
    public class DBMaster
    {
        private SqlConnection conn;


        public SqlConnection GetConnection(){

           string cadena = "Data Source=DESKTOP-HE2UTAP\\SQLEXPRESS;" +
           "Initial Catalog=BuscoPega;" +
           "Persist Security Info=True;" +
           "User ID=piero;" +
           "Password=123456";

            conn = new SqlConnection(cadena);
            conn.Open();
            return conn;

        }

        public SqlDataReader GetReader(string query) {

            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = this.GetConnection();

            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void closeConnection() {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                this.conn.Close();
            }
        }


    }
}