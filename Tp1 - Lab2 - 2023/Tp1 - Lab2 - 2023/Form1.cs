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
        Juego unJuego;
        public Form1()
        {
            InitializeComponent();
            unJuego = new Juego(Convert.ToInt32(nuCantidadJugadores.Value));
            generarJugadores();
        }
        private Color GetBackColor(int indx)
        {
            Color unColor = Color.AntiqueWhite;
            switch(indx)
            {
                case 0:
                    unColor = Color.LightCoral;
                    break;
                case 1:
                    unColor = Color.LightBlue;
                    break;
            }
            return unColor;
        }
        private Point CalcularPosiciónTablero(int indx)
        {
            Point unPunto = new Point();
            int f = indx % 7,
                c;
            c = indx - (f * 7);
            unPunto.X = webBrowser1.Location.X + 12;
            unPunto.Y = webBrowser1.Location.Y + 12;
            unPunto.X += 44 * f;
            unPunto.Y += 44 * c;
            return unPunto;
        }
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
                nombre = "Virtual " + (i + 1);
                unJuego.CargarJugador(nombre);
                lbMarcador.Items.Add("Virtual: " + nombre + ". 0 Puntos.");
            }
        }
        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bool inicio = false;
            if(!inicio)
            {
                Width = 915;
                Height = 502;
                inicio = true;
                unJuego.GenerarPiezas();
                pictureBox1.BringToFront();
                pictureBox1.Location = CalcularPosiciónTablero(unJuego.getPieza(0).Posición);
                pictureBox1.BackColor = GetBackColor(unJuego.getPieza(0).Posición);
                //btnIniciarJuego.Enabled = false;
            }
            pictureBox1.Location = CalcularPosiciónTablero(unJuego.getPieza(0).Mover(rnd.Next()));
        }
    }
}
