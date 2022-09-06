using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programas_Carreras.Entidades
{
    class Plan
    {
        public int Anio { get; set; }
        public int Cuatrimestre { get; set; }
        public string Materia { get; set; }

        public Plan(int anio, int cuatrimestre, string materia)
        {
            Anio = anio;
            Cuatrimestre = cuatrimestre;
            Materia = materia;
        }

        public Plan()
        {
            Anio = 0;
            Cuatrimestre = 0;
            Materia = "";
        }
        public override string ToString()
        {
            return Anio.ToString() + Cuatrimestre.ToString() + Materia;
        }
    }
}
