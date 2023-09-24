namespace AppVisual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCrearJugador = new System.Windows.Forms.Button();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDemo = new System.Windows.Forms.Button();
            this.lbMarcador = new System.Windows.Forms.ListBox();
            this.rbFacil = new System.Windows.Forms.RadioButton();
            this.rbIntermedio = new System.Windows.Forms.RadioButton();
            this.rbExperto = new System.Windows.Forms.RadioButton();
            this.gbDificultad = new System.Windows.Forms.GroupBox();
            this.gbJugador = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCargarVirtuales = new System.Windows.Forms.Button();
            this.gbVirtuales = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbDificultad.SuspendLayout();
            this.gbJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbVirtuales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearJugador
            // 
            this.btnCrearJugador.Location = new System.Drawing.Point(9, 45);
            this.btnCrearJugador.Name = "btnCrearJugador";
            this.btnCrearJugador.Size = new System.Drawing.Size(150, 23);
            this.btnCrearJugador.TabIndex = 0;
            this.btnCrearJugador.Text = "Crear Jugador";
            this.btnCrearJugador.UseVisualStyleBackColor = true;
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Location = new System.Drawing.Point(285, 41);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(90, 23);
            this.btnIniciarJuego.TabIndex = 1;
            this.btnIniciarJuego.Text = "Iniciar Juego";
            this.btnIniciarJuego.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(59, 19);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(285, 12);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(90, 23);
            this.btnDemo.TabIndex = 4;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            // 
            // lbMarcador
            // 
            this.lbMarcador.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcador.FormattingEnabled = true;
            this.lbMarcador.ItemHeight = 15;
            this.lbMarcador.Location = new System.Drawing.Point(12, 101);
            this.lbMarcador.Name = "lbMarcador";
            this.lbMarcador.Size = new System.Drawing.Size(433, 184);
            this.lbMarcador.TabIndex = 5;
            // 
            // rbFacil
            // 
            this.rbFacil.AutoSize = true;
            this.rbFacil.Location = new System.Drawing.Point(6, 16);
            this.rbFacil.Name = "rbFacil";
            this.rbFacil.Size = new System.Drawing.Size(47, 17);
            this.rbFacil.TabIndex = 6;
            this.rbFacil.TabStop = true;
            this.rbFacil.Text = "Facil";
            this.rbFacil.UseVisualStyleBackColor = true;
            // 
            // rbIntermedio
            // 
            this.rbIntermedio.AutoSize = true;
            this.rbIntermedio.Location = new System.Drawing.Point(6, 40);
            this.rbIntermedio.Name = "rbIntermedio";
            this.rbIntermedio.Size = new System.Drawing.Size(74, 17);
            this.rbIntermedio.TabIndex = 7;
            this.rbIntermedio.TabStop = true;
            this.rbIntermedio.Text = "Intermedio";
            this.rbIntermedio.UseVisualStyleBackColor = true;
            // 
            // rbExperto
            // 
            this.rbExperto.AutoSize = true;
            this.rbExperto.Location = new System.Drawing.Point(6, 63);
            this.rbExperto.Name = "rbExperto";
            this.rbExperto.Size = new System.Drawing.Size(61, 17);
            this.rbExperto.TabIndex = 8;
            this.rbExperto.TabStop = true;
            this.rbExperto.Text = "Experto";
            this.rbExperto.UseVisualStyleBackColor = true;
            // 
            // gbDificultad
            // 
            this.gbDificultad.Controls.Add(this.rbIntermedio);
            this.gbDificultad.Controls.Add(this.rbExperto);
            this.gbDificultad.Controls.Add(this.rbFacil);
            this.gbDificultad.Location = new System.Drawing.Point(186, 12);
            this.gbDificultad.Name = "gbDificultad";
            this.gbDificultad.Size = new System.Drawing.Size(93, 88);
            this.gbDificultad.TabIndex = 9;
            this.gbDificultad.TabStop = false;
            this.gbDificultad.Text = "Dificultad";
            // 
            // gbJugador
            // 
            this.gbJugador.Controls.Add(this.tbNombre);
            this.gbJugador.Controls.Add(this.label1);
            this.gbJugador.Controls.Add(this.btnCrearJugador);
            this.gbJugador.Location = new System.Drawing.Point(12, 12);
            this.gbJugador.Name = "gbJugador";
            this.gbJugador.Size = new System.Drawing.Size(168, 83);
            this.gbJugador.TabIndex = 10;
            this.gbJugador.TabStop = false;
            this.gbJugador.Text = "Jugador";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(451, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(400, 400);
            this.webBrowser1.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(113, 23);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCargarVirtuales
            // 
            this.btnCargarVirtuales.Location = new System.Drawing.Point(6, 45);
            this.btnCargarVirtuales.Name = "btnCargarVirtuales";
            this.btnCargarVirtuales.Size = new System.Drawing.Size(113, 23);
            this.btnCargarVirtuales.TabIndex = 13;
            this.btnCargarVirtuales.Text = "Cargar";
            this.btnCargarVirtuales.UseVisualStyleBackColor = true;
            // 
            // gbVirtuales
            // 
            this.gbVirtuales.Controls.Add(this.numericUpDown1);
            this.gbVirtuales.Controls.Add(this.btnCargarVirtuales);
            this.gbVirtuales.Location = new System.Drawing.Point(12, 291);
            this.gbVirtuales.Name = "gbVirtuales";
            this.gbVirtuales.Size = new System.Drawing.Size(135, 76);
            this.gbVirtuales.TabIndex = 14;
            this.gbVirtuales.TabStop = false;
            this.gbVirtuales.Text = "Jugadores Virtuales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 428);
            this.Controls.Add(this.gbVirtuales);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.gbJugador);
            this.Controls.Add(this.gbDificultad);
            this.Controls.Add(this.lbMarcador);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnIniciarJuego);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDificultad.ResumeLayout(false);
            this.gbDificultad.PerformLayout();
            this.gbJugador.ResumeLayout(false);
            this.gbJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbVirtuales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearJugador;
        private System.Windows.Forms.Button btnIniciarJuego;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.ListBox lbMarcador;
        private System.Windows.Forms.RadioButton rbFacil;
        private System.Windows.Forms.RadioButton rbIntermedio;
        private System.Windows.Forms.RadioButton rbExperto;
        private System.Windows.Forms.GroupBox gbDificultad;
        private System.Windows.Forms.GroupBox gbJugador;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCargarVirtuales;
        private System.Windows.Forms.GroupBox gbVirtuales;
        private System.Windows.Forms.Timer timer;
    }
}

