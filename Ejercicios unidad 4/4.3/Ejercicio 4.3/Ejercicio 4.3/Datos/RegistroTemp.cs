using Ejercicio_4._3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_4._3.Datos
{
    public class RegistroTemp
    {
        private static RegistroTemp instancia;
        private RegistroTemp() { }
        private static List<Temperatura> temperaturas = new List<Temperatura>();
        public static RegistroTemp ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new RegistroTemp();
            }
            return instancia;
        }

        public string RegistrarTemperatura(Temperatura temp)
        {
            if (temp.Iot == 0)
                return "La medición ingresada no es válida!";
            temperaturas.Add(temp);
            return "Se registró exitosamente la temperatura indicada.";
        }
        public List<Temperatura> ObtenerTemperaturas()
        {
            return temperaturas;
        }
        public List<Temperatura> ObtenerTemperaturaPorIot(int iot)
        {
            List<Temperatura> respuesta = new List<Temperatura>();
            foreach (Temperatura t in temperaturas)
            {
                if (t.Iot == iot)
                    respuesta.Add(t);
            }
            return respuesta;
        }
    }
}
