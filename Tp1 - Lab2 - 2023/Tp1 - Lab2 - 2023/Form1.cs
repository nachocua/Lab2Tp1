using Componentes;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Tp1___Lab2___2023
{
    public partial class Form1 : Form
    {
        private Juego unJuego;
        private PictureBox[] pictureBoxes;
        private bool inicio;
        private ArrayList nombres;
        public Form1()
        {
            InitializeComponent();
            unJuego = new Juego();
            pictureBoxes = new PictureBox[13];
            nombres = new ArrayList();
            inicio = false;
            CargarNombres();
            SetPictureBox();
            generarJugadores();
            HabilitarPictureBox();
        }
        #region CargarNombres
            /// <summary>
            /// Metodo que llena un contenedor con 20 nombres de personas para ser usados luego de manera aleatoria
            /// </summary>
            private void CargarNombres()
            {
                nombres.Add("Ana");
                nombres.Add("Beto");
                nombres.Add("Carlos");
                nombres.Add("Diana");
                nombres.Add("Elena");
                nombres.Add("Fernando");
                nombres.Add("Gabriela");
                nombres.Add("Hugo");
                nombres.Add("Isabel");
                nombres.Add("Juan");
                nombres.Add("Karla");
                nombres.Add("Luis");
                nombres.Add("Marta");
                nombres.Add("Natalia");
                nombres.Add("Oscar");
                nombres.Add("Patricia");
                nombres.Add("Quintín");
                nombres.Add("Rosa");
                nombres.Add("Santiago");
                nombres.Add("Teresa");
            }
        #endregion
        #region SetPictureBox
            /// <summary>
            /// Completa un vector con las referencias de los pictureBox para poder operarlos de manera genérica
            /// </summary>
            private void SetPictureBox()
            {
                pictureBoxes[0] = pictureBox0;
                pictureBoxes[1] = pictureBox1;
                pictureBoxes[2] = pictureBox2;
                pictureBoxes[3] = pictureBox3;
                pictureBoxes[4] = pictureBox4;
                pictureBoxes[5] = pictureBox5;
                pictureBoxes[6] = pictureBox6;
                pictureBoxes[7] = pictureBox7;
                pictureBoxes[8] = pictureBox8;
                pictureBoxes[9] = pictureBox9;
                pictureBoxes[10] = pictureBox10;
                pictureBoxes[11] = pictureBox11;
                pictureBoxes[12] = pictureBox12;
            }
        #endregion
        #region ConfigPictureBox
            /// <summary>
            /// Mueve un PictureBox por encima del tablero
            /// </summary>
            /// <param name="unPictureBox">Referencia al pictureBox que se desea mover.</param>
            /// <param name="indx">Indice de la pieza que se relaciona con su respectivo pictureBox.</param>
            private void ConfigPictureBox(PictureBox unPictureBox, int indx)
            {
                unPictureBox.Location = CalcularPosiciónTablero(unJuego.getPieza(indx).Posición);
                unPictureBox.BackColor = GetBackColor(unJuego.getPieza(indx).Posición);
            }
        #endregion
        #region GetBackColor
            /// <summary>
            /// Calcula la paleta de fondo segun la posición del tablero.
            /// </summary>
            /// <param name="indx">Indica la posición de la pieza en el tablero</param>
            /// <returns>Devuelve un objeto de la clase Color que representa el color de fondo de la cuadricula</returns>
            private Color GetBackColor(int indx)
            {
                Color unColor = Color.AntiqueWhite;
                switch (indx)
                {
                    case 49:
                        unColor = Color.LightCoral;
                        break;
                    case 0:
                        unColor = Color.LightBlue;
                        break;
                }
                return unColor;
            }
        #endregion
        #region CalcularPosiciónTablero
            /// <summary>
            /// Calcula la posición en la pantalla segun la posición del tablero.
            /// </summary>
            /// <param name="indx">Indica la posición de la pieza en el tablero</param>
            /// <returns>Devuelve un objeto de la clase Point (x,y) que representa el pixel superior izquierdo de un elemento gráfico</returns>
            private Point CalcularPosiciónTablero(int indx)
            {
                Point unPunto = new Point();
                if (indx != 49)
                {
                    unPunto.X = webBrowser1.Location.X + 12 + 44 * (indx % 7);
                    unPunto.Y = webBrowser1.Location.Y + 12 + 45 * (indx / 7);
                }
                else
                {
                    unPunto.X = webBrowser1.Location.X + 12 + 44 * 7;
                    unPunto.Y = webBrowser1.Location.Y + 12 + 45 * 6;
                }
                return unPunto;
            }
        #endregion
        #region CambiarDificultad
            /// <summary>
            /// Cambia la dificultad del juego segun el radioButton
            /// </summary>
            /// <param name="sender">objeto que será interpretado como un RadioButton</param>
            private void CambiarDificultad(object sender, EventArgs e)
            {
                RadioButton unRadioButton = sender as RadioButton;
                unJuego.Dificultad = unRadioButton.Text;
                HabilitarPictureBox();
            }
        #endregion
        #region Trigger GenerarJugadores
            private void nuCantidadJugadores_ValueChanged(object sender, EventArgs e)
            {
                generarJugadores();
            }
        #endregion
        #region Demo/Jugar
            /// <summary>
            /// Determina si es Demo o Jugar
            /// </summary>
            /// <param name="sender">objeto que será interpretado como un RadioButton</param>
            private void TipoJuego(object sender, EventArgs e)
            {
                RadioButton unRadioButton = sender as RadioButton;
                if (unRadioButton.Text == rbJugar.Text)
                {
                    gbJugador.Enabled = true;
                }
                else
                {
                    gbJugador.Enabled = false;
                }
                generarJugadores();
            }
        #endregion
        #region CambioNombre
        private void CambioNombre(object sender, EventArgs e)
        {
            generarJugadores();
        }
        #endregion
        #region GenerarJugadores 
        /// <summary>
        /// Genera los jugadores para el juego
        /// </summary>
            private void generarJugadores()
            {
                unJuego.Reset();
                lbMarcador.Items.Clear();
                unJuego.CantidadJugadores = Convert.ToInt32(nuCantidadJugadores.Value);
                string nombre;
                int virtualACrear = unJuego.CantidadJugadores - 1;
                Random rnd = new Random();
                if (rbJugar.Checked)
                {
                    unJuego.CargarJugador(tbNombre.Text, true);
                    lbMarcador.Items.Add("Humano: " + tbNombre.Text + ". 0 Puntos.");
                }
                else
                {
                    virtualACrear++;
                }
                for (int i = 0; i < virtualACrear; i++)
                {
                    nombre = (string)nombres[rnd.Next(20)];
                    unJuego.CargarJugador(nombre);
                    lbMarcador.Items.Add("Virtual: " + nombre + ". 0 Puntos.");
                }
                HabilitarPictureBox();
            }
        #endregion
        #region HabilitarPictureBox
            /// <summary>
            /// Spawnea los PictureBox que van a ser utilizados para el juego
            /// </summary>
            private void HabilitarPictureBox()
            {
                int cantidadJugadores = Convert.ToInt32(nuCantidadJugadores.Value);
                int i;
                for (i = 0; i < pictureBoxes.Length; i++)
                {
                    pictureBoxes[i].Visible = false;
                }
                if(cantidadJugadores==2)
                {
                    if(unJuego.Dificultad!="Facil")
                    {
                        if (rbJugar.Checked)
                        {
                            pictureBoxes[2].Visible = true;
                        }
                        else
                        {
                            pictureBoxes[12].Visible = true;
                        }
                        pictureBoxes[5].Visible = true;
                    }
                }
                cantidadJugadores--;
                if (rbJugar.Checked)
                {
                    pictureBoxes[0].Visible = true;
                    if (unJuego.Dificultad != "Facil")
                    {
                        pictureBoxes[1].Visible = true;
                    }
                }
                else
                {
                    pictureBoxes[10].Visible = true;
                    if (unJuego.Dificultad != "Facil")
                    {
                        pictureBoxes[11].Visible = true;
                    }
                }
                pictureBoxes[3].Visible = true;
                if (unJuego.Dificultad != "Facil")
                {
                    pictureBoxes[4].Visible = true;
                }
                cantidadJugadores--;
                for (i=0; i<cantidadJugadores; i++)
                {
                    if (unJuego.Dificultad != "Facil")
                    {
                        pictureBoxes[7 + 2*i].Visible = true;
                    }
                    pictureBoxes[6 + 2 * i].Visible = true;
                }
            }
        #endregion
        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int cont = 0;
            if (!inicio)
            {
                inicio = true;
                unJuego.GenerarPiezas();
                //btnIniciarJuego.Enabled = false;
                gbDificultad.Enabled = false;
                gbJugador.Enabled = false;
                gbTipoJuego.Enabled = false;
                gbVirtuales.Enabled = false;
            }
            else
            {
                ArrayList txt = new ArrayList();
                unJuego.JugarRonda(txt, rnd);
            }
            foreach (PictureBox unPictureBox in pictureBoxes)
            {
                if (unPictureBox.Visible)
                {
                    ConfigPictureBox(unPictureBox, cont);
                    cont++;
                }
            }
        }
    }
}