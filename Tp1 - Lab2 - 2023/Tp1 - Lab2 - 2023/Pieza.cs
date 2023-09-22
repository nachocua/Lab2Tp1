using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1___Lab2___2023
{
    internal abstract class Pieza
    {
        public string Nombre { get; private set; }
        public int Posición { get; private set; }
        public string Alineación { get; private set; }
        Pieza(string nombre, int posición, string alineación)
        {
            Nombre = nombre;
            Posición = posición;
            Alineación = alineación;
        }
        public abstract int Mover(int posicion);
    }
}
