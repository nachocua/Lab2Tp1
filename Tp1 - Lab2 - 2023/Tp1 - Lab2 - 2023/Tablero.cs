using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1___Lab2___2023
{
    internal class Tablero
    {
        public int CantidadCalabozos { get; private set; }
        private ArrayList calabozos;
        public Tablero() 
        {
            CantidadCalabozos = 0;
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
