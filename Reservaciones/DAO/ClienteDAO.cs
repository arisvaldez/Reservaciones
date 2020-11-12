using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Reservaciones.Models;

namespace Reservaciones.DAO
{
    class ClienteDAO
    {
        MySqlConnection cn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;

        public bool Insert(ClienteModel model) 
        {
            string query = $@"INSERT INTO cliente (nombre, apellido, tipo_documento, documento)
                                VALUES('{model.Nombre}','{model.Apellido}','{model.TipoDocumento}','{model.Documento}')";

            return ExecuteNonQuery(query);
        }

        public bool Update(ClienteModel model)
        {
            string query = "";

            return ExecuteNonQuery(query);
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM cliente WHERE id={id}";

            return ExecuteNonQuery(query);
        }


        private bool ExecuteNonQuery(string query)
        {
            try
            {
                cn = ConexionDB.GetMysqlConnection();
                cmd = new MySqlCommand();
                cmd.CommandText = query;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open) 
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return false;
        }


        public bool ExecuteNonQuery2(ClienteModel model)
        {
            try
            {
                string query = $"INSERT INTO cliente (nombre, apellido, tipo_documento, documento)"+
                               $"VALUES('{model.Nombre}','{model.Apellido}','{model.TipoDocumento}','{model.Documento}');"+
                               $"SELECT LAST_INSERT_ID();";

                cn = ConexionDB.GetMysqlConnection();
                cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = cn;

                long id = Convert.ToInt64(cmd.ExecuteScalar());

                foreach (TelefonoClienteModel item in model.Telefonos)
                {
                    query = $"INSERT telefono_cliente(id_cliente, numero, tipo)" +
                            $"VALUES('{id}', '{item.Numero}','{item.Tipo}')";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message );
                System.Windows.Forms.MessageBox.Show(e.StackTrace );
                return false;
            }
            finally
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return false;
        }

        public List<ClienteModel> GetClientes() 
        {
            string query = $"SELECT * FROM cliente";

            return ExecuteQuery(query);
        }

        private List<ClienteModel> ExecuteQuery(string query) 
        {
            var ClienteList = new List<ClienteModel>();
            try
            {
                cn = ConexionDB.GetMysqlConnection();
                cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = cn;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ClienteModel cliente = new ClienteModel();
                    cliente.Id = (int)reader["id"];
                    cliente.Nombre = reader["nombre"].ToString();
                    cliente.Apellido = reader["apellido"].ToString();
                    cliente.TipoDocumento = reader["tipo_documento"].ToString();
                    cliente.Documento = reader["documento"].ToString();
                    
                    ClienteList.Add(cliente);
                }

                return ClienteList;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
            finally
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return null;
        } 

    }
}
