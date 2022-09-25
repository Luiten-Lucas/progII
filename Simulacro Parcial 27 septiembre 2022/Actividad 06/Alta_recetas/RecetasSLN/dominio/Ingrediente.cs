using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Ingrediente
    {
        public Ingrediente(int ingredienteId, string nombre, string unidad)
        {
            this.ingredienteId = ingredienteId;
            this.nombre = nombre;
            this.unidad = unidad;
        }

        public int ingredienteId { get; set; }
        public string nombre { get; set; }
        public string unidad { get; set; }
    }
}
