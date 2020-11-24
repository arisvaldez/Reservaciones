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
            string query = $"INSERT INTO cita (id_profesional, id_cliente, id_dia, hora, fecha_cita)" +
                           $"VALUES('{model.IdProfesional}','{model.IdCliente}','{model.IdDia}','{model.Hora}','{model.FechaCita}')";
            
            return Commands.ExecuteNonQuery(query);
        }

       
        public List<CitaModel> GetDisponibilidadProfesionalPorFecha(int id, string date)
        {
            string query = $"SELECT * FROM cita WHERE id_profesional= {id} and fecha_cita='{date}'";
            return Commands.Query<CitaModel>(query);
        }
    }
}
