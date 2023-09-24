using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    internal class Calabozo
    {
        public string Nombre { get; protected set; }
        public int Posición { get; protected set; }
        public Calabozo(string nombre, int posición)
        {
            Nombre = nombre;
            Posición = posición;
        }
    }
}