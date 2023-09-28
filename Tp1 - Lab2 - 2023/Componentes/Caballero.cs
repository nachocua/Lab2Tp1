namespace Componentes
{
    public class Caballero : Pieza
    {
        private bool congelado;
        public Caballero(string nombre, int posición, string alineación) : base(nombre, posición, alineación)
        {
            congelado = false;
        }
        public override int Mover(int n)
        {
            if(congelado) 
            {
                congelado = false;
            }
            else
            {
                Posición += n;
                //Posición += (n % 6) + 1;
                if (Posición > 49)
                {
                    Posición = 49;
                }
                if (Posición < 0)
                {
                    Posición = 0;
                }
            }
            return Posición;
        }
        public void PerderTurno()
        {
            congelado = true;
        }
    }
}
