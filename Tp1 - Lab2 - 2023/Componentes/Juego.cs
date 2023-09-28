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
            Pieza unaPieza;
            foreach (Jugador auxJug in jugadores)
            {
                unaPieza = new Caballero(auxJug.Nombre, 0, auxJug.Nombre);
                piezas.Add(unaPieza);
                if (Dificultad != "Facil")
                {
                    unaPieza = new Dragon(auxJug.Nombre, rnd.Next(tablero.TamañoTablero), auxJug.Nombre);
                    piezas.Add(unaPieza);
                    if (CantidadJugadores == 2)
                    {
                        unaPieza = new Dragon(auxJug.Nombre, rnd.Next(tablero.TamañoTablero), auxJug.Nombre);
                        piezas.Add(unaPieza);
                    }
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
        public ArrayList IniciarPartida()
        {
            Random rnd = new Random();
            string ganador;
            ArrayList txt = new ArrayList();
            GenerarPiezas();
            while (!AlguienGano(out ganador))
            {
                ganador = JugarRonda(txt, rnd);
            }
            txt.Add("El ganador es " + ganador);
            return txt;
        }
        //Completar
        public string JugarRonda(ArrayList txt, Random rnd)
        {
            string ganador = "";
            //Random rnd = new Random();
            if (partidaValida)
            {
                foreach (Pieza unaPieza in piezas)
                {
                    if (!AlguienGano(out ganador))
                    {
                        string line;
                        if (unaPieza is Caballero)
                        {
                            line = string.Format("{0,-20} se movio a la pos | {1,3}", "Caballero de " + unaPieza.Alineación, unaPieza.Mover(rnd.Next(1,6)));
                            txt.Add(line);
                        }
                        if (Dificultad != "Facil")
                        {
                            if (unaPieza is Dragon)
                            {
                                line = string.Format("{0,-20} se movio a la pos | {1,3}", "Dragon de " + unaPieza.Alineación, unaPieza.Mover(rnd.Next()));
                                txt.Add(line);
                            }
                            if (HayDragon(unaPieza) > 0)
                            {
                                // Avanzar
                                line = string.Format("{0,-10} se encontro un dragon suyo, avanza {1} casillas", unaPieza.Alineación, 5);
                                line += " (Pos: " + unaPieza.Mover(5) + " )";
                                txt.Add(line);
                            }
                            else if (HayDragon(unaPieza) < 0)
                            {
                                //Retroceder
                                line = string.Format("{0,-10} se encontro un dragon enemigo, retrocede {1} casillas", unaPieza.Alineación, 5);
                                line += " (Pos: " + unaPieza.Mover(-5) + " )";
                                txt.Add(line);
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
            return ganador;
        }
        public int HayDragon(Pieza unaPieza)
        {
            int state = 0;
            if (unaPieza is Caballero)
            {
                foreach (Pieza aux in piezas)
                {
                    if (aux is Dragon)
                    {
                        if (unaPieza.Posición == aux.Posición)
                        {
                            if (unaPieza.Alineación == aux.Alineación)
                            {
                                state++;
                            }
                            else state--;
                        }
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

        //public bool HayDragon(Pieza unaPieza)
        //{
        //    bool state = false;
        //    if (unaPieza is Caballero)
        //    {
        //        foreach (Pieza aux in piezas)
        //        {
        //            if (aux.Alineación == unaPieza.Alineación)
        //            {
        //                state = true;
        //            }
        //        }
        //    }
        //    return state;
        //}

        //public bool HayCalabozo(Pieza unaPieza)
        //{
        //    bool state = false;
        //    if (unaPieza is Caballero)
        //    {
        //        for (int i = 0; i < tablero.CantidadCalabozos; i++)
        //        {
        //            if (unaPieza.Posición == tablero.PosicionCalabozo(i))
        //            {
        //                state = true;
        //            }
        //        }
        //    }
        //    return state;
        //}

    }
}