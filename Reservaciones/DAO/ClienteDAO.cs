using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Reservaciones.Models;

namespace Reservaciones.DAO
{
    class ClienteDAO
    {
        public bool Insert(ClienteModel model)
        {
            string query = $"INSERT INTO cliente (nombre, apellido, tipo_documento, documento)" +
                           $"VALUES('{model.Nombre}','{model.Apellido}','{model.TipoDocumento}','{model.Documento}')" +
                           $"SELECT LAST_INSERT_ID();";

            long id = Commands.ExecuteScalar(query);

            foreach (TelefonoClienteModel item in model.Telefonos)
            {
                query = $"INSERT telefono_cliente(id_cliente, numero, tipo)" +
                        $"VALUES('{id}', '{item.Numero}','{item.Tipo}')";
                Commands.ExecuteNonQuery(query);
            }

            return true;
        }

        public bool Update(ClienteModel model)
        {
            string query = "";

            return Commands.ExecuteNonQuery(query);
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM cliente WHERE id={id}";
            return Commands.ExecuteNonQuery(query);
        }

        public List<ClienteModel> GetClientes()
        {
            string query = $"SELECT * FROM cliente";
            var clienteList = Commands.Query<ClienteModel>(query);

            foreach (var item in clienteList)
            {
                item.Telefonos = GetTelefonoClientes(item.Id);
            }

            return clienteList;
        }

        public List<TelefonoClienteModel> GetTelefonoClientes(int id)
        {
            string query = $"SELECT id_cliente, tipo, numero FROM telefono_cliente WHERE id_cliente= {id}";
            return Commands.Query<TelefonoClienteModel>(query);
        }
    }
}
