using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Models
{
     interface ICrud
    {
          List<object> Obtener(int id);
          void Insertar();
          void Modificar();
          void Eliminar(int id);
    }
}
