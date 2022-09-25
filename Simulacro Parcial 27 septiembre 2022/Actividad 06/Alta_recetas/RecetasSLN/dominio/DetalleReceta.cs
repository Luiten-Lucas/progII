using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class DetalleReceta
    {
        public DetalleReceta(string ingrediente, int cantidad, int idIngrediente, int idReceta)
        {
            this.ingrediente = ingrediente;
            this.cantidad = cantidad;
            this.idIngrediente = idIngrediente;
            this.idReceta = idReceta;
        }

        public string ingrediente { get; set; }
        public int cantidad { get; set; }
        public int idIngrediente { get; set; }
        public int idReceta { get; set; }
    }
    
}
