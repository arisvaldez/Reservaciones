using Reservaciones.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Models
{
    class ProfesionalModel:IModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public int IdProfesion { get; set; }
        public string Profesion { get; set; }
        public List<TelefonoProfesionalModel> Telefonos { get; set; }
        public Tipos Tipo { get; set; } = Tipos.PROFESIONAL;
    }

    public class TelefonoProfesionalModel 
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }
    }


    public class DisponibilidadProfesionalModel 
    {
        public int IdProfesional { get; set; }
        public int IdDia { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
    }
}
