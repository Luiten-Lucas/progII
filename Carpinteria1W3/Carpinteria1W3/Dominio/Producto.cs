using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria1W3.Dominio
{
    class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public bool Activo { get; set; }
        public Producto(int idProducto, string nombre, float precio, bool activo)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Precio = precio;
            Activo = activo;
        }

        

        
        
    }
}
