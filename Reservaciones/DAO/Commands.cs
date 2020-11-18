using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reservaciones.DAO
{
    static class Commands
    {
      
        public static bool ExecuteNonQuery(string query)
        {
            try
            {
                using (var cn = ConexionDB.GetMysqlConnection())
                {
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = cn;

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            cn.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            
            return false;
        }

        public static long ExecuteScalar(string query)
        {
            try
            {
                using (var cn = ConexionDB.GetMysqlConnection())
                {
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = cn;

                        return Convert.ToInt64(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<T> Query<T>(string query) where T : new()
        {
            
            List<T> res = new List<T>();
            var cn = ConexionDB.GetMysqlConnection();
            var cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = cn;

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                T t = new T();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Type type = t.GetType();
                    PropertyInfo prop = type.GetProperty(ToPascalCase(reader.GetName(i)));
                    prop.SetValue(t, reader.GetValue(i), null);

                }
                res.Add(t);
            }
            reader.Close();

            return res;
        }

        private static string ToPascalCase(string texto)
        {
            texto = Regex.Replace(texto, "_[a-z]", delegate (Match m)
            {
                return m.ToString().TrimStart('_').ToUpper();
            });

            var temp = texto.ToCharArray();
            temp[0] = temp[0].ToString().ToUpperInvariant().ToCharArray()[0];
            return new String(temp);
        }
    }
}
