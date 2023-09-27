namespace Componentes
{
    public class Dragon : Pieza
    {
        public Dragon(string nombre, int posición, string alineación) : base(nombre, posición, alineación)
        { }
        public override int Mover(int n)
        {
            return Posición = n % 49;
        }
    }
}
