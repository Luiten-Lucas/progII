using pilasColas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilasColas.Clases
{
    internal class Cola : ICollection
    {
        private List<Object> elementos;
        private int counter;

        public Cola ()
        {
            counter = 0;
            elementos = new List<Object>();
        }
        public bool añadir(object elemento)
        {
            bool added = false;
            if (counter < elementos.Count() +1)
            {
                elementos.Add(elemento);
                counter++;
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
                var posi = elementos.Count() - counter;
                obj = elementos[posi];
                elementos.RemoveAt(posi);
                //elementos[counter] = null;
                counter--;
            }
            return obj;
        }

        public object primero()
        {
            object obj = null;
            if (!estaVacia())
            {
                obj = elementos[0];
            }
            return obj;
        }
    }
}
