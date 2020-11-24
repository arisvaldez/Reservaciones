using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Models
{
    class CitaModel
    {
        public int Id { get; set; }
        public int IdProfesional { get; set; }
        public int IdCliente { get; set; }
        public int IdEstado { get; set; }
        public int IdDia { get; set; }
        public string Hora { get; set; }
        public string FechaCita { get; set; }
        public DateTime Creado { get; set; }
    }
}
