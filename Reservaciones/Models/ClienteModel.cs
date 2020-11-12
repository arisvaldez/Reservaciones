using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Models
{
    class ClienteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public List<TelefonoClienteModel> Telefonos { get; set; }
    }

}
