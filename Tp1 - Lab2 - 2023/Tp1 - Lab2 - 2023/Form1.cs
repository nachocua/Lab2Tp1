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
        Point[] listaPuntos;
        public Form1()
        {
            InitializeComponent();
            unJuego = new Juego(Convert.ToInt32(nuCantidadJugadores.Value));
            generarJugadores();
            listaPuntos = new Point[unJuego.TamañoTablero()];
        }
        private Point CalcularPosiciónTablero(int indx)
        {
            Point unPunto = new Point();
            int f = indx / 7,
                c;
            if(indx == 8)
            {
                f--;
            }
            c = (indx - f * 7);
            unPunto.X = c;
            unPunto.Y = f;
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
            btnIniciarJuego.Enabled = false;
            gboxTablero.Visible = true;
            Width = 915;
            Height = 502;
        }
    }
}
