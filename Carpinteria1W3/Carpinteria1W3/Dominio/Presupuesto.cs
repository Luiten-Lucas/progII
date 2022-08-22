using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria1W3.Dominio
{
    class Presupuesto
    {
        public int Numero { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Cliente { get; set; }
        public float Descuento { get; set; }
        public float Total { get; set; }
        public List<DetallePresupuesto> Detalles { get; }

        public Presupuesto(string cliente, float descuento, int numero)
        {
            Numero = numero;
            FechaAlta = DateTime.Now;
            Cliente = cliente;
            Descuento = descuento;
            Total = 0;
            Detalles = new List<DetallePresupuesto>();

        }

        public Presupuesto()
        {
        }

        public void agregarDetalle(DetallePresupuesto detalle)
        {
            if (detalle != null)
                Detalles.Add(detalle);

        }

        public void quitarDetalle(DetallePresupuesto detalle)
        {
            Detalles.Remove(detalle);
        }
    }
}
