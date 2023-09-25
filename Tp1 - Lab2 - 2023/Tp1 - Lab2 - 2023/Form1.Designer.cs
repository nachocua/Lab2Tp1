namespace Tp1___Lab2___2023
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbVirtuales = new System.Windows.Forms.GroupBox();
            this.nuCantidadJugadores = new System.Windows.Forms.NumericUpDown();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.gbJugador = new System.Windows.Forms.GroupBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDificultad = new System.Windows.Forms.GroupBox();
            this.rbIntermedio = new System.Windows.Forms.RadioButton();
            this.rbExperto = new System.Windows.Forms.RadioButton();
            this.rbFacil = new System.Windows.Forms.RadioButton();
            this.lbMarcador = new System.Windows.Forms.ListBox();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.rbDemo = new System.Windows.Forms.RadioButton();
            this.rbJugar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboxTablero = new System.Windows.Forms.GroupBox();
            this.IList = new System.Windows.Forms.ImageList(this.components);
            this.gbVirtuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadJugadores)).BeginInit();
            this.gbJugador.SuspendLayout();
            this.gbDificultad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxTablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVirtuales
            // 
            this.gbVirtuales.Controls.Add(this.nuCantidadJugadores);
            this.gbVirtuales.Location = new System.Drawing.Point(16, 351);
            this.gbVirtuales.Name = "gbVirtuales";
            this.gbVirtuales.Size = new System.Drawing.Size(130, 76);
            this.gbVirtuales.TabIndex = 21;
            this.gbVirtuales.TabStop = false;
            this.gbVirtuales.Text = "Jugadores Virtuales";
            // 
            // nuCantidadJugadores
            // 
            this.nuCantidadJugadores.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuCantidadJugadores.Location = new System.Drawing.Point(7, 30);
            this.nuCantidadJugadores.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nuCantidadJugadores.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nuCantidadJugadores.Name = "nuCantidadJugadores";
            this.nuCantidadJugadores.Size = new System.Drawing.Size(113, 23);
            this.nuCantidadJugadores.TabIndex = 12;
            this.nuCantidadJugadores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nuCantidadJugadores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nuCantidadJugadores.ValueChanged += new System.EventHandler(this.nuCantidadJugadores_ValueChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(17, 17);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(472, 409);
            this.webBrowser1.TabIndex = 20;
            this.webBrowser1.Url = new System.Uri("http://127.0.0.1:5500/", System.UriKind.Absolute);
            // 
            // gbJugador
            // 
            this.gbJugador.Controls.Add(this.tbNombre);
            this.gbJugador.Controls.Add(this.label1);
            this.gbJugador.Enabled = false;
            this.gbJugador.Location = new System.Drawing.Point(93, 13);
            this.gbJugador.Name = "gbJugador";
            this.gbJugador.Size = new System.Drawing.Size(171, 88);
            this.gbJugador.TabIndex = 19;
            this.gbJugador.TabStop = false;
            this.gbJugador.Text = "Jugador";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(59, 37);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // gbDificultad
            // 
            this.gbDificultad.Controls.Add(this.rbIntermedio);
            this.gbDificultad.Controls.Add(this.rbExperto);
            this.gbDificultad.Controls.Add(this.rbFacil);
            this.gbDificultad.Location = new System.Drawing.Point(281, 13);
            this.gbDificultad.Name = "gbDificultad";
            this.gbDificultad.Size = new System.Drawing.Size(93, 88);
            this.gbDificultad.TabIndex = 18;
            this.gbDificultad.TabStop = false;
            this.gbDificultad.Text = "Dificultad";
            // 
            // rbIntermedio
            // 
            this.rbIntermedio.AutoSize = true;
            this.rbIntermedio.Location = new System.Drawing.Point(6, 40);
            this.rbIntermedio.Name = "rbIntermedio";
            this.rbIntermedio.Size = new System.Drawing.Size(74, 17);
            this.rbIntermedio.TabIndex = 7;
            this.rbIntermedio.Text = "Intermedio";
            this.rbIntermedio.UseVisualStyleBackColor = true;
            this.rbIntermedio.CheckedChanged += new System.EventHandler(this.rbIntermedio_CheckedChanged);
            // 
            // rbExperto
            // 
            this.rbExperto.AutoSize = true;
            this.rbExperto.Location = new System.Drawing.Point(6, 63);
            this.rbExperto.Name = "rbExperto";
            this.rbExperto.Size = new System.Drawing.Size(61, 17);
            this.rbExperto.TabIndex = 8;
            this.rbExperto.Text = "Experto";
            this.rbExperto.UseVisualStyleBackColor = true;
            this.rbExperto.CheckedChanged += new System.EventHandler(this.rbExperto_CheckedChanged);
            // 
            // rbFacil
            // 
            this.rbFacil.AutoSize = true;
            this.rbFacil.Checked = true;
            this.rbFacil.Location = new System.Drawing.Point(6, 16);
            this.rbFacil.Name = "rbFacil";
            this.rbFacil.Size = new System.Drawing.Size(47, 17);
            this.rbFacil.TabIndex = 6;
            this.rbFacil.TabStop = true;
            this.rbFacil.Text = "Facil";
            this.rbFacil.UseVisualStyleBackColor = true;
            this.rbFacil.CheckedChanged += new System.EventHandler(this.rbFacil_CheckedChanged);
            // 
            // lbMarcador
            // 
            this.lbMarcador.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcador.FormattingEnabled = true;
            this.lbMarcador.ItemHeight = 15;
            this.lbMarcador.Location = new System.Drawing.Point(12, 117);
            this.lbMarcador.Name = "lbMarcador";
            this.lbMarcador.Size = new System.Drawing.Size(363, 214);
            this.lbMarcador.TabIndex = 17;
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Location = new System.Drawing.Point(201, 379);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(147, 23);
            this.btnIniciarJuego.TabIndex = 15;
            this.btnIniciarJuego.Text = "Iniciar Juego";
            this.btnIniciarJuego.UseVisualStyleBackColor = true;
            this.btnIniciarJuego.Click += new System.EventHandler(this.btnIniciarJuego_Click);
            // 
            // rbDemo
            // 
            this.rbDemo.AutoSize = true;
            this.rbDemo.Checked = true;
            this.rbDemo.Location = new System.Drawing.Point(6, 22);
            this.rbDemo.Name = "rbDemo";
            this.rbDemo.Size = new System.Drawing.Size(53, 17);
            this.rbDemo.TabIndex = 22;
            this.rbDemo.TabStop = true;
            this.rbDemo.Text = "Demo";
            this.rbDemo.UseVisualStyleBackColor = true;
            this.rbDemo.CheckedChanged += new System.EventHandler(this.rbDemo_CheckedChanged);
            // 
            // rbJugar
            // 
            this.rbJugar.AutoSize = true;
            this.rbJugar.Location = new System.Drawing.Point(6, 51);
            this.rbJugar.Name = "rbJugar";
            this.rbJugar.Size = new System.Drawing.Size(51, 17);
            this.rbJugar.TabIndex = 23;
            this.rbJugar.Text = "Jugar";
            this.rbJugar.UseVisualStyleBackColor = true;
            this.rbJugar.CheckedChanged += new System.EventHandler(this.rbJugar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDemo);
            this.groupBox1.Controls.Add(this.rbJugar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(74, 88);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo juego";
            // 
            // gboxTablero
            // 
            this.gboxTablero.BackColor = System.Drawing.Color.Gray;
            this.gboxTablero.Controls.Add(this.webBrowser1);
            this.gboxTablero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxTablero.Location = new System.Drawing.Point(381, 12);
            this.gboxTablero.Name = "gboxTablero";
            this.gboxTablero.Size = new System.Drawing.Size(512, 445);
            this.gboxTablero.TabIndex = 26;
            this.gboxTablero.TabStop = false;
            this.gboxTablero.Visible = false;
            // 
            // IList
            // 
            this.IList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IList.ImageStream")));
            this.IList.TransparentColor = System.Drawing.Color.Transparent;
            this.IList.Images.SetKeyName(0, "Caballero Humano.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1087, 800);
            this.Controls.Add(this.gboxTablero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbVirtuales);
            this.Controls.Add(this.gbJugador);
            this.Controls.Add(this.gbDificultad);
            this.Controls.Add(this.lbMarcador);
            this.Controls.Add(this.btnIniciarJuego);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbVirtuales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadJugadores)).EndInit();
            this.gbJugador.ResumeLayout(false);
            this.gbJugador.PerformLayout();
            this.gbDificultad.ResumeLayout(false);
            this.gbDificultad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxTablero.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVirtuales;
        private System.Windows.Forms.NumericUpDown nuCantidadJugadores;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox gbJugador;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDificultad;
        private System.Windows.Forms.RadioButton rbIntermedio;
        private System.Windows.Forms.RadioButton rbExperto;
        private System.Windows.Forms.RadioButton rbFacil;
        private System.Windows.Forms.ListBox lbMarcador;
        private System.Windows.Forms.Button btnIniciarJuego;
        private System.Windows.Forms.RadioButton rbDemo;
        private System.Windows.Forms.RadioButton rbJugar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gboxTablero;
        private System.Windows.Forms.ImageList IList;
    }
}

