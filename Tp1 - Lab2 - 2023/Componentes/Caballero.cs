namespace Componentes
{
    public class Caballero : Pieza
    {
        public Caballero(string nombre, int posición, string alineación) : base(nombre, posición, alineación)
        { }
        public override int Mover(int n)
        {
            Posición += (n % 6) + 1;
            if (Posición > 49)
            {
                Posición = 49;
            }
            return Posición;
        }
    }
}
