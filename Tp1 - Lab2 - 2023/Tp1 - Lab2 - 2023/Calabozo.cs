using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1___Lab2___2023
{
    internal class Calabozo
    {
        public string Nombre { get; protected set; }
        public int Posición { get; protected set; }
        public string Alineación { get; protected set; }
        public Calabozo(string nombre, int posición)
        {
            Nombre = nombre;
            Posición = posición;
        }
    }
}