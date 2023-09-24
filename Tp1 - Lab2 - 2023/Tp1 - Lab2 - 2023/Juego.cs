using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Componentes;

namespace Tp1___Lab2___2023
{
    internal class Juego
    {
        private bool partidaValida;
        public string Dificultad { get; private set; }
        public int NroJuego { get; private set; }
        public int CantidadJugadores { get; private set; }
        private ArrayList jugadores = null;
        private Tablero tablero;
        private ArrayList piezas = null;
        Juego(int cantidadJugadores)
        {
            CantidadJugadores = cantidadJugadores;
            tablero = new Tablero();
            Dificultad = "Facil";
        }
        public void CargarJugador(string nombre, bool humano=false)
        {
            jugadores.Add(new Jugador(nombre));
            if(jugadores.Count == CantidadJugadores)
            {
                partidaValida = true;
            }
            else
            {
                partidaValida = false;
            }
        }
        public void GenerarPiezas()
        {
            Random rnd = new Random();
            foreach(Jugador auxJug in jugadores) 
            {
                Caballero unCaballero = new Caballero(auxJug.Nombre, 0, auxJug.Nombre);
                piezas.Add(unCaballero);
                if(Dificultad != "Facil")
                {
                    Dragon unDragon = new Dragon(auxJug.Nombre, rnd.Next(0,tablero.TamañoTablero), auxJug.Nombre);
                    piezas.Add(unDragon);
                }
            }
            if (Dificultad == "Experto") 
            {
                for (int i = 0; i < 3; i++)
                {
                    tablero.AgregarCalabozo();
                }
            }
        }
        public void Reset()
        {
            tablero.Reset();
            piezas.Clear();
        }
        //Completar
        public void IniciarPartida()
        {
            return false;
        }
        //Completar
        public void JugarRonda()
        {
            if (partidaValida)
            { 

            }
        }
        public bool AlguienGano(out string deQueJugador)
        {
            bool state =false;
            deQueJugador = null;
            foreach(Pieza pieza in piezas) 
            {
                if(pieza is Caballero)
                {
                    if(pieza.Posición == tablero.TamañoTablero - 1)
                    {
                        state = true;
                        deQueJugador = pieza.Alineación;
                    }
                }
            }
            return state;
        }
    }
}