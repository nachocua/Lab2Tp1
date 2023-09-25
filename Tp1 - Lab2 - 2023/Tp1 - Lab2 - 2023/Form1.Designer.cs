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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IList = new System.Windows.Forms.ImageList(this.components);
            this.gbVirtuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadJugadores)).BeginInit();
            this.gbJugador.SuspendLayout();
            this.gbDificultad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVirtuales
            // 
            this.gbVirtuales.Controls.Add(this.nuCantidadJugadores);
            this.gbVirtuales.Location = new System.Drawing.Point(21, 432);
            this.gbVirtuales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbVirtuales.Name = "gbVirtuales";
            this.gbVirtuales.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbVirtuales.Size = new System.Drawing.Size(173, 94);
            this.gbVirtuales.TabIndex = 21;
            this.gbVirtuales.TabStop = false;
            this.gbVirtuales.Text = "Jugadores Virtuales";
            // 
            // nuCantidadJugadores
            // 
            this.nuCantidadJugadores.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuCantidadJugadores.Location = new System.Drawing.Point(9, 37);
            this.nuCantidadJugadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nuCantidadJugadores.Size = new System.Drawing.Size(151, 27);
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
            this.webBrowser1.Location = new System.Drawing.Point(507, 23);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(629, 503);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://127.0.0.1:5500/", System.UriKind.Absolute);
            // 
            // gbJugador
            // 
            this.gbJugador.Controls.Add(this.tbNombre);
            this.gbJugador.Controls.Add(this.label1);
            this.gbJugador.Enabled = false;
            this.gbJugador.Location = new System.Drawing.Point(124, 16);
            this.gbJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbJugador.Name = "gbJugador";
            this.gbJugador.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbJugador.Size = new System.Drawing.Size(228, 108);
            this.gbJugador.TabIndex = 19;
            this.gbJugador.TabStop = false;
            this.gbJugador.Text = "Jugador";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(79, 46);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 22);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // gbDificultad
            // 
            this.gbDificultad.Controls.Add(this.rbIntermedio);
            this.gbDificultad.Controls.Add(this.rbExperto);
            this.gbDificultad.Controls.Add(this.rbFacil);
            this.gbDificultad.Location = new System.Drawing.Point(375, 16);
            this.gbDificultad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDificultad.Name = "gbDificultad";
            this.gbDificultad.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDificultad.Size = new System.Drawing.Size(124, 108);
            this.gbDificultad.TabIndex = 18;
            this.gbDificultad.TabStop = false;
            this.gbDificultad.Text = "Dificultad";
            // 
            // rbIntermedio
            // 
            this.rbIntermedio.AutoSize = true;
            this.rbIntermedio.Location = new System.Drawing.Point(8, 49);
            this.rbIntermedio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbIntermedio.Name = "rbIntermedio";
            this.rbIntermedio.Size = new System.Drawing.Size(91, 20);
            this.rbIntermedio.TabIndex = 7;
            this.rbIntermedio.Text = "Intermedio";
            this.rbIntermedio.UseVisualStyleBackColor = true;
            this.rbIntermedio.CheckedChanged += new System.EventHandler(this.rbIntermedio_CheckedChanged);
            // 
            // rbExperto
            // 
            this.rbExperto.AutoSize = true;
            this.rbExperto.Location = new System.Drawing.Point(8, 78);
            this.rbExperto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbExperto.Name = "rbExperto";
            this.rbExperto.Size = new System.Drawing.Size(74, 20);
            this.rbExperto.TabIndex = 8;
            this.rbExperto.Text = "Experto";
            this.rbExperto.UseVisualStyleBackColor = true;
            this.rbExperto.CheckedChanged += new System.EventHandler(this.rbExperto_CheckedChanged);
            // 
            // rbFacil
            // 
            this.rbFacil.AutoSize = true;
            this.rbFacil.Checked = true;
            this.rbFacil.Location = new System.Drawing.Point(8, 20);
            this.rbFacil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFacil.Name = "rbFacil";
            this.rbFacil.Size = new System.Drawing.Size(57, 20);
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
            this.lbMarcador.ItemHeight = 19;
            this.lbMarcador.Location = new System.Drawing.Point(16, 144);
            this.lbMarcador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbMarcador.Name = "lbMarcador";
            this.lbMarcador.Size = new System.Drawing.Size(483, 251);
            this.lbMarcador.TabIndex = 17;
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Location = new System.Drawing.Point(268, 466);
            this.btnIniciarJuego.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(196, 28);
            this.btnIniciarJuego.TabIndex = 15;
            this.btnIniciarJuego.Text = "Iniciar Juego";
            this.btnIniciarJuego.UseVisualStyleBackColor = true;
            this.btnIniciarJuego.Click += new System.EventHandler(this.btnIniciarJuego_Click);
            // 
            // rbDemo
            // 
            this.rbDemo.AutoSize = true;
            this.rbDemo.Checked = true;
            this.rbDemo.Location = new System.Drawing.Point(8, 27);
            this.rbDemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDemo.Name = "rbDemo";
            this.rbDemo.Size = new System.Drawing.Size(65, 20);
            this.rbDemo.TabIndex = 22;
            this.rbDemo.TabStop = true;
            this.rbDemo.Text = "Demo";
            this.rbDemo.UseVisualStyleBackColor = true;
            this.rbDemo.CheckedChanged += new System.EventHandler(this.rbDemo_CheckedChanged);
            // 
            // rbJugar
            // 
            this.rbJugar.AutoSize = true;
            this.rbJugar.Location = new System.Drawing.Point(8, 63);
            this.rbJugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbJugar.Name = "rbJugar";
            this.rbJugar.Size = new System.Drawing.Size(62, 20);
            this.rbJugar.TabIndex = 23;
            this.rbJugar.Text = "Jugar";
            this.rbJugar.UseVisualStyleBackColor = true;
            this.rbJugar.CheckedChanged += new System.EventHandler(this.rbJugar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDemo);
            this.groupBox1.Controls.Add(this.rbJugar);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(99, 108);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo juego";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox1.BackgroundImage = global::Tp1___Lab2___2023.Properties.Resources.Caballero_Humano;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(87, 594);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 52);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // IList
            // 
            this.IList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.IList.ImageSize = new System.Drawing.Size(16, 16);
            this.IList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1146, 747);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbVirtuales);
            this.Controls.Add(this.gbJugador);
            this.Controls.Add(this.gbDificultad);
            this.Controls.Add(this.lbMarcador);
            this.Controls.Add(this.btnIniciarJuego);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pic";
            this.gbVirtuales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadJugadores)).EndInit();
            this.gbJugador.ResumeLayout(false);
            this.gbJugador.PerformLayout();
            this.gbDificultad.ResumeLayout(false);
            this.gbDificultad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ImageList IList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

