using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_17_agosto__2nda_clase_.Entidades
{
    internal class Asignatura
    {
        public string Materia { get; set; }
        public Asignatura(string materia)
        {
            Materia = materia ?? throw new ArgumentNullException(nameof(materia));
        }
        public Asignatura()
        {
            Materia = "";
        }
        public override string ToString()
        {
            return Materia;
        }

    }
}
