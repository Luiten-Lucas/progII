using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {
        public Receta(int recetaNro, string nombre, string tipoReceta, string chef)
        {
            this.recetaNro = recetaNro;
            this.nombre = nombre;
            this.tipoReceta = tipoReceta;
            this.chef = chef;
        }

        public int recetaNro { get; set; }
        public string nombre { get; set; }
        public string tipoReceta { get; set; }
        public string chef { get; set; }
    }
}
