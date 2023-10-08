using System;
using System.Collections;

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
            calabozos = new ArrayList();
        }
        public void Reset()
        {
            CantidadCalabozos = 0;
            calabozos.Clear();
        }
        public bool AgregarCalabozo(Random rnd)
        {
            bool noSePudo = false;
            int pos;
            do
            {
                pos = rnd.Next(1, 49);
                foreach (Calabozo aux in calabozos)
                {
                    if (aux.Posición == pos)
                    {
                        noSePudo = true;
                    }
                }
            }while(noSePudo);
            CantidadCalabozos++;
            Calabozo unCalabozo = new Calabozo("Dungeon " + CantidadCalabozos, pos);
            calabozos.Add(unCalabozo);
            return false;
        }
        public Calabozo getCalabozo(int idx)
        {
            return (Calabozo)calabozos[idx];
        }
    }
}
