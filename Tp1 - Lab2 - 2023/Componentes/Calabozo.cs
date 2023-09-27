namespace Componentes
{
    internal class Calabozo
    {
        public string Nombre { get; protected set; }
        public int Posición { get; protected set; }
        public Calabozo(string nombre, int posición)
        {
            Nombre = nombre;
            Posición = posición;
        }
    }
}