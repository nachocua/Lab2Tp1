using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1___Lab2___2023
{
    internal class Juego
    {
        private bool partidaValida;
        public string Dificultad { get; private set; }
        public int NroJuego { get; private set; }
        public int CantidadJugadores { get; private set; }
        public int CantidadJugadoresActuales { get; private set; }
        ArrayList jugadores;
        Tablero tablero;
        Juego(int cantidadJugadores)
        {
            CantidadJugadores = cantidadJugadores;
            tablero = new Tablero();
        }
        public void CargarJugador(string nombre, bool humano)
        {
            jugadores.Add(new Jugador(nombre));
        }
        public void GenerarPiezas()
        {

        }
        public void Reset()
        {
            tablero.Reset();
            jugadores.Clear();
        }
        public bool IniciarPartida()
        { 
            return false; // terminar
        }
        public void JugarRonda()
        {

        }
        public bool AlguienGano()
        {
            return false; // terminar
        }
    }
}
