using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Utils
{
    public interface IModel
    {
        Tipos Tipo { get; set; }
    }

    public enum Tipos {CLIENTE, PROFESIONAL}
}
