using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Dragon : Pieza
    {
        public Dragon(string nombre, int posición, string alineación) : base(nombre, posición, alineación)
        { }
        public override int Mover(int n)
        {
            return Posición = n;
        }
    }
}
