namespace Componentes
{
    public abstract class Pieza
    {
        public string Nombre { get; protected set; }
        public int Posición { get; protected set; }
        public string Alineación { get; protected set; }
        private bool vivo;
        public Pieza(string nombre, int posición, string alineación)
        {
            Nombre = nombre;
            Posición = posición;
            Alineación = alineación;
            vivo = true;
        }
        public abstract int Mover(int posicion);
        public bool EstaVivo()
        {
            return vivo;
        }
        public void SeMurio()
        {
            vivo = false;
        }
    }
}
