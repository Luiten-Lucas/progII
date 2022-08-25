using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_17_agosto__2nda_clase_.Entidades
{
    internal class Carrera
    {
        public Carrera(string nombre, string titulo)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
        }

        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public Plan plan { get; set; }

        public void agregarPlan(Plan plan)
        {
            this.plan = plan;
        }
        public void quitarDetalle(Plan plan)
        {
            this.plan = new Plan();
        }
    }
}
