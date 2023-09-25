using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Caballero : Pieza
    {
        public Caballero(string nombre, int posición, string alineación) : base(nombre, posición, alineación)
        { }
        public override int Mover(int n)
        {
            /*Posición += (n % 6) + 1;*/
            return Posición+= 1;
        }
    }
}
