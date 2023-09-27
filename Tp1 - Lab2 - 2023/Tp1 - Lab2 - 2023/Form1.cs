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
            SetPictureBox();
            generarJugadores();
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
            private void ConfigPictureBoxStart(PictureBox unPictureBox, int indx)
            {
                unPictureBox.Location = CalcularPosiciónTablero(unJuego.getPieza(indx).Posición);
                unPictureBox.BackColor = GetBackColor(unJuego.getPieza(indx).Posición);
            }
            private void ConfigPictureBoxMover(PictureBox unPictureBox, int indx, int random)
            {
                unPictureBox.Location = CalcularPosiciónTablero(unJuego.getPieza(indx).Mover(random));
                unPictureBox.BackColor = GetBackColor(unJuego.getPieza(indx).Posición);
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
                HabilitarPictureBox();
            }
            private void rbIntermedio_CheckedChanged(object sender, EventArgs e)
            {
                unJuego.Dificultad = rbIntermedio.Text;
                tbNombre.Text = unJuego.Dificultad;
                HabilitarPictureBox();
            }
            private void rbExperto_CheckedChanged(object sender, EventArgs e)
            {
                unJuego.Dificultad = rbExperto.Text;
                tbNombre.Text = unJuego.Dificultad;
                HabilitarPictureBox();
            }
        #endregion
        #region Trigger GenerarJugadores
            private void nuCantidadJugadores_ValueChanged(object sender, EventArgs e)
            {
                generarJugadores();
            }
            private void rbDemo_CheckedChanged(object sender, EventArgs e)
            {
                generarJugadores();
                gbJugador.Enabled = false;
            }
            private void rbJugar_CheckedChanged(object sender, EventArgs e)
            {
                generarJugadores();
                gbJugador.Enabled = true;
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
            HabilitarPictureBox();
        }
        private void HabilitarPictureBox()
        {
            int cantidadJugadores = unJuego.CantidadJugadores;
            int i;
            for (i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Visible = false;
            }
            if (rbJugar.Checked)
            {
                cantidadJugadores--;
                pictureBoxes[0].Visible = true;
                if (unJuego.Dificultad!="Facil")
                {
                    pictureBoxes[1].Visible = true;
                }
            }
            if(unJuego.Dificultad!="Facil")
            {
                for (i = 0; i < cantidadJugadores; i++)
                {
                    pictureBoxes[3+2*i].Visible = true;
                }
            }
            for (i = 0; i < cantidadJugadores; i++)
            {
                pictureBoxes[2 + 2 * i].Visible = true;
            }
        }
        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int cont = 0;
            if (!inicio)
            {
                //Width = 915;
                //Height = 502;
                inicio = true;
                unJuego.GenerarPiezas();
                foreach (PictureBox unPictureBox in pictureBoxes)
                {
                    if (unPictureBox.Visible)
                    {
                        ConfigPictureBoxStart(unPictureBox, cont);
                        cont++;
                    }
                }
                //btnIniciarJuego.Enabled = false;
            }
            else
            {
                /*
                for (int i = 0; i < unJuego.CantidadPiezas(); i++)
                {
                    unJuego.getPieza(i).Mover(rnd.Next());
                }
                */
                foreach (PictureBox unPictureBox in pictureBoxes)
                {
                    if(unPictureBox.Visible)
                    {
                        ConfigPictureBoxMover(unPictureBox, cont, rnd.Next());
                        cont++;
                    }
                }
            }
        }
    }
}