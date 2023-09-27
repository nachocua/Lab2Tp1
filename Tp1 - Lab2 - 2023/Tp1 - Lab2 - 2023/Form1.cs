using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Componentes;

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
            unJuego = new Juego(Convert.ToInt32(nuCantidadJugadores.Value));
            pictureBoxes = new PictureBox[10];
            nombres = new ArrayList();
            inicio = false;
            CargarNombres();
            generarJugadores();
            SetPictureBox();
            HabilitarPictureBox();
        }
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
        #region Config Pictures Box
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
                foreach (PictureBox unPictureBox in pictureBoxes) 
                {
                    unPictureBox.BringToFront();
                }
            }
            private void ConfigPictureBoxStart(PictureBox unPictureBox)
            {
                unPictureBox.Location = CalcularPosiciónTablero(unJuego.getPieza(0).Posición);
                unPictureBox.BackColor = GetBackColor(unJuego.getPieza(0).Posición);
            }
            private void ConfigPictureBoxMover(PictureBox unPictureBox, int posicion, int random)
            {
                pictureBox0.Location = CalcularPosiciónTablero();
                unPictureBox.BackColor = GetBackColor(unJuego.getPieza(posicion).Posición);
            }
        #endregion
        #region Operar Pictures Box
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
        #region Cambio de Dificultad
            private void rbFacil_CheckedChanged(object sender, EventArgs e)
            {
                unJuego.Dificultad = rbFacil.Text;
                tbNombre.Text = unJuego.Dificultad;
            }
            private void rbIntermedio_CheckedChanged(object sender, EventArgs e)
            {
                unJuego.Dificultad = rbIntermedio.Text;
                tbNombre.Text = unJuego.Dificultad;
            }
            private void rbExperto_CheckedChanged(object sender, EventArgs e)
            {
                unJuego.Dificultad = rbExperto.Text;
                tbNombre.Text = unJuego.Dificultad;
            }
        #endregion
        #region Trigger GenerarJugadores
            private void nuCantidadJugadores_ValueChanged(object sender, EventArgs e)
            {
                generarJugadores();
                HabilitarPictureBox();
            }
            private void rbDemo_CheckedChanged(object sender, EventArgs e)
            {
                generarJugadores();
                gbJugador.Enabled = false;
                HabilitarPictureBox();
            }
            private void rbJugar_CheckedChanged(object sender, EventArgs e)
            {
                generarJugadores();
                gbJugador.Enabled = true;
                HabilitarPictureBox();
            }
            private void tbNombre_TextChanged(object sender, EventArgs e)
            {
                if (rbJugar.Checked)
                {
                    generarJugadores();
                }
            }
        #endregion
        private void generarJugadores()
        {
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
            for(int i=0; i<virtualACrear; i++) 
            {
                nombre = (string)nombres[rnd.Next(20)];
                unJuego.CargarJugador(nombre);
                lbMarcador.Items.Add("Virtual: " + nombre + ". 0 Puntos.");
            }
        }
        private void HabilitarPictureBox()
        {
            for (int i = 2; i < pictureBoxes.Length-2; i++)
            {
                pictureBoxes[i].Visible = false;
            }
            if(rbJugar.Checked) 
            {
                pictureBoxes[0].Visible = true;
                pictureBoxes[1].Visible = true;
                pictureBoxes[8].Visible = false;
                pictureBoxes[9].Visible = false;
            }
            else
            {
                pictureBoxes[0].Visible = false;
                pictureBoxes[1].Visible = false;
                pictureBoxes[8].Visible = true;
                pictureBoxes[9].Visible = true;
            }
            for (int i = 0; i < unJuego.CantidadJugadores - 1; i++)
            {
                pictureBoxes[2 + 2 * i].Visible = true;
                pictureBoxes[3 + 2 * i].Visible = true;
            }
        }
        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (!inicio)
            {
                //HabilitarPictureBox();
                Width = 915;
                Height = 502;
                inicio = true;
                unJuego.GenerarPiezas();
                foreach (PictureBox unPictureBox in pictureBoxes)
                {
                    if (unPictureBox.Visible)
                    {
                        ConfigPictureBoxStart(unPictureBox);
                    }
                }
                //btnIniciarJuego.Enabled = false;
            }
            else
            {
                for (int i = 0; i < unJuego.CantidadPiezas(); i++)
                {
                    unJuego.getPieza(i).Mover(rnd.Next());
                }
                foreach (PictureBox unPictureBox in pictureBoxes)
                {
                    if(unPictureBox.Visible)
                    {
                        ConfigPictureBoxMover(unPictureBox, pictureBoxes);
                    }
                }
            }
        }
    }
}