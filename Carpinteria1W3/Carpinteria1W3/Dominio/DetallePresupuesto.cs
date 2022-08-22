using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria1W3.Dominio
{
    class DetallePresupuesto
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public DetallePresupuesto(int cant, Producto P)
        {
            Cantidad = cant;
            Producto = P;
        }
        public float CalcularSubtotal()
        {
            return Producto.Precio * Cantidad;
        }
    }
}
