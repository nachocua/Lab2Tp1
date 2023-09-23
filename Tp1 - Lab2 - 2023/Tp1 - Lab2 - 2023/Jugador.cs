using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1___Lab2___2023
{
    public class Jugador
    {
        public string Nombre {get; private set;}
        public int Ganadas { get; private set;}
        public Jugador(string nombre)
        {
            Nombre = nombre;
            Ganadas = 0;
        }
        public void Ganaste()
        {
            Ganadas++;
        }
    }
}
