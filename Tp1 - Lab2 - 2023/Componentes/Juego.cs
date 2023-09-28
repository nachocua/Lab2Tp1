using System;
using System.Collections;

namespace Componentes
{
    public class Juego
    {
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
            NroJuego = 0;
        }
        public void CargarJugador(string nombre, bool humano = false)
        {
            Jugador unJugador = new Jugador(nombre);
            jugadores.Add(unJugador);
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
                    unaPieza = new Dragon(auxJug.Nombre, rnd.Next(tablero.TamañoTablero-1), auxJug.Nombre);
                    piezas.Add(unaPieza);
                    if (CantidadJugadores == 2)
                    {
                        unaPieza = new Dragon(auxJug.Nombre, rnd.Next(tablero.TamañoTablero-1), auxJug.Nombre);
                        piezas.Add(unaPieza);
                    }
                }
            }
            if (Dificultad == "Experto")
            {
                for (int i = 0; i < 3; i++)
                {
                    tablero.AgregarCalabozo(rnd);
                }
            }
        }
        public void Reset()
        {
            tablero.Reset();
            piezas.Clear();
        }
        public void ResetJugadores()
        {
            jugadores.Clear();
        }
        //Completar
        public ArrayList IniciarPartida(out string ganador)
        {
            NroJuego++;
            Random rnd = new Random();
            ArrayList txt = new ArrayList();
            string line;
            txt.Add("|------------------------------|");
            txt.Add("|Juego "+NroJuego+" - "+dificultad + "\t       |");
            txt.Add("|------------------------------|");
            txt.Add("|");
            txt.Add("|");
            txt.Add("|");
            if (Dificultad == "Experto")
            {
                for (int i = 0; i < tablero.CantidadCalabozos; i++)
                {
                    line = string.Format("Posicion de {0}: {1}", tablero.getCalabozo(i).Nombre, tablero.getCalabozo(i).Posición);
                    txt.Add(line);
                }
            }
            while (!AlguienGano(out ganador))
            {
                ganador = JugarRonda(txt, rnd);
            }
            txt.Add("El ganador es " + ganador);
            foreach (Jugador unJugador in jugadores)
            {
                if (ganador == unJugador.Nombre)
                {
                    unJugador.Ganaste();
                }
            }
            return txt;
        }
        //Completar
        public string JugarRonda(ArrayList txt, Random rnd)
        {
            string ganador = "";
            string line;
            foreach (Pieza unaPieza in piezas)
            {
                if (!AlguienGano(out ganador))
                {
                    if (unaPieza is Caballero)
                    {
                        line = string.Format("{0,-20} se movio a la pos | {1,3}", "Caballero de " + unaPieza.Alineación, unaPieza.Mover(rnd.Next(1, 6)));
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
                            line = string.Format("{0,-10} se encontro un dragon aliado, avanza {1} casillas", unaPieza.Alineación, 5);
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
                                if (HayDragon(unaPieza) == 0)
                                {
                                    line = string.Format("{0,-20} entro a un calabozo, pierde un turno", "Caballero de " + unaPieza.Alineación);
                                    //((Caballero)unaPieza).PerderTurno();
                                    PerderTurno(unaPieza);
                                    txt.Add(line);
                                }
                                else if (HayDragon(unaPieza) > 0)
                                {
                                    line = string.Format("{0,-20} entro a un calabozo, pero su dragon estaba para rescatarlo", "Caballero de " + unaPieza.Alineación);
                                    txt.Add(line);
                                }
                                else if (HayDragon(unaPieza) < 0)
                                {
                                    line = string.Format("{0,-20} entro a un calabozo con un dragon enemigo, pierde el juego", "Caballero de " + unaPieza.Alineación);
                                    EliminarJugador(unaPieza);
                                    txt.Add(line);
                                }
                            }
                        }
                    }
                }
            }
            return ganador;
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
        public Jugador GetJugador(int indx)
        {
            return (Jugador)jugadores[indx];
        }
        public int TamañoTablero()
        {
            return tablero.TamañoTablero;
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
                    if (unaPieza.Posición == tablero.getCalabozo(i).Posición)
                    {
                        state = true;
                    }
                }
            }
            return state;
        }
        public void EliminarJugador(Pieza unaPieza)
        {
            foreach (Jugador unJugador in jugadores)
            {
                if (unJugador.Nombre == unaPieza.Alineación)
                {
                    jugadores.Remove(unJugador);
                }
            }
        }
        public void PerderTurno(Pieza unaPieza)
        {
            ((Caballero)unaPieza).PerderTurno();
            unaPieza.Mover(0);
        }
        public int GetPosicionCalabozo(int indx)
        {
            return tablero.getCalabozo(indx).Posición;
        }
        public void SumarPuntos(string ganador)
        {
            foreach (Jugador j in jugadores)
            {
                if (j.Nombre == ganador)
                {
                    j.Ganaste();
                }
            }
        }
    }
}