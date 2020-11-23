using Reservaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.DAO
{
    class CitaDAO
    {
        public bool Insert(CitaModel model)
        {
            string query = $"INSERT INTO cita (id_profesional, id_cliente, id_dia, hora)" +
                           $"VALUES('{model.IdProfesional}','{model.IdCliente}','{model.IdDia}','{model.Hora}')";
            
            return Commands.ExecuteNonQuery(query);
        }

       
        public List<CitaModel> GetDisponibilidadProfesional(int id, string dia)
        {
            string query = $"SELECT * FROM cita WHERE id_cliente= {id} and id_dia='{dia}'";
            return Commands.Query<CitaModel>(query);
        }
    }
}
