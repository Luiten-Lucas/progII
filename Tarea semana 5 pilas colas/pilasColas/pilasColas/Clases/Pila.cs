using pilasColas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilasColas.Clases
{
    internal class Pila : ICollection
    {

        private object[] elementos;
        private int counter;

        public Pila(int cantidad)
        {
            counter = 0;
            elementos = new object[cantidad];
        }

        public bool añadir(object elemento)
        {
            bool added = false;
            if (counter < elementos.Length + 1)
            {
                elementos[++counter] = elemento;
                added = true;
            }
            return added;
        }

        public bool estaVacia()
        {
            return counter == 0;
        }

        public object extraer()
        {
            object obj = null;
            if (!estaVacia())
            {
                obj = elementos[counter];
                elementos[counter] = null;
                counter--;
            }
            return obj;
        }

        public object primero()
        {
            object obj = null;
            if (!estaVacia())
            {
                obj = elementos[1];
            }
            return obj;
        }
    }
}
