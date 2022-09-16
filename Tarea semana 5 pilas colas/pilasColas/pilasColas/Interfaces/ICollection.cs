using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilasColas.Interfaces
{
    internal interface ICollection
    {
        bool estaVacia();
        object extraer();
        object primero();
        bool añadir(object elemento);
    }
}
