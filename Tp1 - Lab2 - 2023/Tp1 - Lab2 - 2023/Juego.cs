using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1___Lab2___2023
{
    internal class Juego
    {
        public int CantidadJugadores { get; private set; }
        public int CantidadJugadoresActuales { get; private set; }
        Juego(int cantidadJugadores)
        {
            CantidadJugadores = cantidadJugadores;
        }
    }
}
