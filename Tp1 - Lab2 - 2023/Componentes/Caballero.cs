namespace Componentes
{
    public class Caballero : Pieza
    {
        private bool Congelado;
        public Caballero(string nombre, int posición, string alineación) : base(nombre, posición, alineación)
        {
            Congelado = false;
        }
        public override int Mover(int n)
        {
            if(Congelado) 
            {
                Congelado = false;
            }
            else
            {
                Posición += (n % 6) + 1;
                if (Posición > 49)
                {
                    Posición = 49;
                }
            }
            return Posición;
        }
    }
}
