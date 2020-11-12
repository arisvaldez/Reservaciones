using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Reservaciones
{
    class ConexionDB
    {
        public static SqlConnection GetConnection() 
        {
            string server = "localhost";
            string database = "reservarciones";
            string uid = "";
            string pwd = "";

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = $"Server={server}; catalog={database}; uid={uid}; pwd={pwd};";
            cn.Open();

            return cn;
        }

        public static SqlConnection GetSqlWinAuthenticationConnection()
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=reservaciones;Integrated Security=True");
            cn.Open();
            return cn;
        }

        public static MySqlConnection GetMysqlConnection()
        {
            string server = "localhost";
            string database = "reservaciones";
            string uid = "root";
            string pwd = "";

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = $"Server={server}; database={database}; uid={uid}; pwd={pwd};";
            cn.Open();

            return cn;
        }


    }
}
