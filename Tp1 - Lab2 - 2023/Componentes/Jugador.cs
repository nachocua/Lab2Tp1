namespace Componentes
{
    public class Jugador
    {
        public string Nombre { get; private set; }
        public int Ganadas { get; private set; }
        public Jugador(string nombre)
        {
            Nombre = nombre;
            Ganadas = 0;
        }
        public void Ganaste()
        {
            Ganadas++;
        }
    }
}
