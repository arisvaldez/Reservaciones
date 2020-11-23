using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Utils
{
   public interface IContract
    {
        void Execute(IModel data);
    }
}
