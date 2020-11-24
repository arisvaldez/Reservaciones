using Reservaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.DAO
{
    class ProfesionalDAO
    {
        
        public bool Insert(ProfesionalModel model)
        {
            string query = $"INSERT INTO profesional (nombre, apellido, tipo_documento, documento, id_profesion)"+
                           $"VALUES('{model.Nombre}','{model.Apellido}','{model.TipoDocumento}','{model.Documento}','{model.IdProfesion}')"+
                           $"SELECT LAST_INSERT_ID();";

            long id = Commands.ExecuteScalar(query);

            foreach (TelefonoProfesionalModel item in model.Telefonos)
            {
                query = $"INSERT telefono_profesional(id_profesional, numero, tipo)" +
                        $"VALUES('{id}', '{item.Numero}','{item.Tipo}')";
                Commands.ExecuteNonQuery(query);
            }

            return true;
        }

        public bool Update(ProfesionalModel model)
        {
            string query = "";

            return Commands.ExecuteNonQuery(query);
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM profesional WHERE id={id}";
            return Commands.ExecuteNonQuery(query);
        }


        public List<ProfesionalModel> Get(string documento = "None")
        {
            string query = $"SELECT * FROM profesional";
            
            if (documento != "None")
                query += $" WHERE documento ={documento}";

            return Commands.Query<ProfesionalModel>(query);
        }

        public List<TelefonoProfesionalModel> GetTelefonoProfesional(int id) 
        {
            string query = $"SELECT id_profesional, tipo, numero FROM telefono_profesional WHERE id_profesional= {id}";
            return Commands.Query<TelefonoProfesionalModel>(query);
        }

        public List<DisponibilidadProfesionalModel> GetDisponibilidadProfesional(int id , int dia = -1) 
        {
            string query = $"SELECT * FROM disponibilidad WHERE id_profesional = {id}";
            if (dia >= 0)
                query = query + $" AND id_dia = {dia}";

            return Commands.Query<DisponibilidadProfesionalModel>(query);
        }
    }
}
