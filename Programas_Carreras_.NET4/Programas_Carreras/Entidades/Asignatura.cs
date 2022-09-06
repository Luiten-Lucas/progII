using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programas_Carreras.Entidades
{
    class Asignatura
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
