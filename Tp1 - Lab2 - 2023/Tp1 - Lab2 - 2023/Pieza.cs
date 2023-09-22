using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1___Lab2___2023
{
    public abstract class Pieza
    {
        public string Nombre { get; protected set; }
        public int Posición { get; protected set; }
        public string Alineación { get; protected set; }
        public Pieza(string nombre, int posición, string alineación)
        {
            Nombre = nombre;
            Posición = posición;
            Alineación = alineación;
        }
        public abstract int Mover(int posicion);
    }
}
