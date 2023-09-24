using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Tablero
    {
        public int CantidadCalabozos { get; private set; }
        private ArrayList calabozos = null;
        public int TamañoTablero { get; private set; }
        public Tablero(int tamaño = 50)
        {
            CantidadCalabozos = 0;
            TamañoTablero = tamaño;
        }
        public void Reset()
        {
            CantidadCalabozos = 0;
            calabozos.Clear();
        }
        public void AgregarCalabozo()
        {
            CantidadCalabozos++;
            Random rnd = new Random();
            int pos = rnd.Next();
            Calabozo unCalabozo = new Calabozo("Dungeon " + pos, pos);
            calabozos.Add(unCalabozo);
        }
    }
}
