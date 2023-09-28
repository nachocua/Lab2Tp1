using System;
using System.Collections;

namespace Componentes
{
    public class Juego
    {
        private bool partidaValida;
        public string Dificultad
        {
            get
            {
                return dificultad;
            }
            set
            {

                if (value == "Facil" || value == "Experto" || value == "Intermedio")
                {
                    dificultad = value;
                }
            }
        }
        private string dificultad;
        public int NroJuego
        { get; private set; }
        public int CantidadJugadores
        { get; set; }
        private ArrayList jugadores;
        private Tablero tablero;
        private ArrayList piezas;
        public Juego(int cantidadJugadores = 2)
        {
            jugadores = new ArrayList();
            piezas = new ArrayList();
            tablero = new Tablero();
            CantidadJugadores = cantidadJugadores;
            Dificultad = "Facil";
        }
        public void CargarJugador(string nombre, bool humano = false)
        {
            Jugador unJugador = new Jugador(nombre);
            jugadores.Add(unJugador);
            if (jugadores.Count == CantidadJugadores)
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
            foreach (Jugador auxJug in jugadores)
            {
                Caballero unCaballero = new Caballero(auxJug.Nombre, 0, auxJug.Nombre);
                piezas.Add(unCaballero);
                if (Dificultad != "Facil")
                {
                    Dragon unDragon = new Dragon(auxJug.Nombre, rnd.Next(tablero.TamañoTablero), auxJug.Nombre);
                    piezas.Add(unDragon);
                }
            }
            /*if (Dificultad == "Experto")
            {
                for (int i = 0; i < 3; i++)
                {
                    tablero.AgregarCalabozo();
                }
            }*/
        }
        public void Reset()
        {
            tablero.Reset();
            piezas.Clear();
            jugadores.Clear();
        }
        //Completar
        public void IniciarPartida()
        {

        }
        //Completar
        public void JugarRonda()
        {
            Random rnd = new Random();
            if (partidaValida)
            {
                foreach (Pieza unaPieza in piezas)
                {
                    unaPieza.Mover(rnd.Next());
                    if (Dificultad != "Facil")
                    {
                        if (HayDragon(unaPieza) )
                        {
                            // Avanzar o Retroceder
                        }
                        if (Dificultad == "Experto")
                        {
                            if (HayCalabozo(unaPieza))
                            {
                                //Hacer que pierda, que pierda turno, o nada
                            }
                        }
                    }
                }

            }
        }
        public bool AlguienGano(out string deQueJugador)
        {
            bool state = false;
            deQueJugador = null;
            foreach (Pieza pieza in piezas)
            {
                if (pieza is Caballero)
                {
                    if (pieza.Posición == tablero.TamañoTablero - 1)
                    {
                        state = true;
                        deQueJugador = pieza.Alineación;
                    }
                }
            }
            return state;
        }
        public int CantidadPiezas()
        {
            return piezas.Count;
        }
        public Pieza getPieza(int indx)
        {
            return (Pieza)piezas[indx];
        }
        public Jugador GetJugador(string alineacion)
        {
            Jugador unJugador = null;
            foreach (Jugador aux in jugadores)
            {
                if (aux.Nombre == alineacion)
                {
                    unJugador = aux;
                }
            }
            return unJugador;
        }
        public int TamañoTablero()
        {
            return tablero.TamañoTablero;
        }

        public bool HayDragon(Pieza unaPieza)
        {
            bool state = false;
            if (unaPieza is Caballero)
            {
                foreach (Pieza aux in piezas)
                {
                    if (aux.Alineación == unaPieza.Alineación)
                    {
                        state = true;
                    }
                }
            }
            return state;
        }

        public bool HayCalabozo(Pieza unaPieza)
        {
            bool state = false;
            if (unaPieza is Caballero)
            {
                for (int i = 0; i < tablero.CantidadCalabozos; i++)
                {
                    if (unaPieza.Posición == tablero.PosicionCalabozo(i))
                    {
                        state = true;
                    }
                }
            }
            return state;
        }

    }
}