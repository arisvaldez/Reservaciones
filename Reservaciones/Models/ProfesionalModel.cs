using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Models
{
    class ProfesionalModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public int IdProfesion { get; set; }
        public List<TelefonoProfesionalModel> Telefonos { get; set; }

    }

    public class TelefonoProfesionalModel 
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }
    }
}
