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
            this.gbTipoJuego = new System.Windows.Forms.GroupBox();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lBoxLog = new System.Windows.Forms.ListBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.timerRonda = new System.Windows.Forms.Timer(this.components);
            this.gbVirtuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadJugadores)).BeginInit();
            this.gbJugador.SuspendLayout();
            this.gbDificultad.SuspendLayout();
            this.gbTipoJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVirtuales
            // 
            this.gbVirtuales.Controls.Add(this.nuCantidadJugadores);
            this.gbVirtuales.Location = new System.Drawing.Point(327, 13);
            this.gbVirtuales.Name = "gbVirtuales";
            this.gbVirtuales.Size = new System.Drawing.Size(130, 88);
            this.gbVirtuales.TabIndex = 21;
            this.gbVirtuales.TabStop = false;
            this.gbVirtuales.Text = "Jugadores Virtuales";
            // 
            // nuCantidadJugadores
            // 
            this.nuCantidadJugadores.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuCantidadJugadores.Location = new System.Drawing.Point(6, 34);
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
            this.webBrowser1.Location = new System.Drawing.Point(472, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(375, 335);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://127.0.0.1:5500/", System.UriKind.Absolute);
            // 
            // gbJugador
            // 
            this.gbJugador.Controls.Add(this.tbNombre);
            this.gbJugador.Controls.Add(this.label1);
            this.gbJugador.Enabled = false;
            this.gbJugador.Location = new System.Drawing.Point(93, 13);
            this.gbJugador.Name = "gbJugador";
            this.gbJugador.Size = new System.Drawing.Size(129, 88);
            this.gbJugador.TabIndex = 19;
            this.gbJugador.TabStop = false;
            this.gbJugador.Text = "Jugador";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(16, 50);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextChanged += new System.EventHandler(this.CambioNombre);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
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
            this.gbDificultad.Location = new System.Drawing.Point(228, 13);
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
            this.rbIntermedio.CheckedChanged += new System.EventHandler(this.CambiarDificultad);
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
            this.rbExperto.CheckedChanged += new System.EventHandler(this.CambiarDificultad);
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
            this.rbFacil.CheckedChanged += new System.EventHandler(this.CambiarDificultad);
            // 
            // lbMarcador
            // 
            this.lbMarcador.Enabled = false;
            this.lbMarcador.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcador.FormattingEnabled = true;
            this.lbMarcador.ItemHeight = 15;
            this.lbMarcador.Location = new System.Drawing.Point(12, 117);
            this.lbMarcador.Name = "lbMarcador";
            this.lbMarcador.Size = new System.Drawing.Size(454, 64);
            this.lbMarcador.TabIndex = 17;
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Location = new System.Drawing.Point(541, 393);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(253, 98);
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
            this.rbDemo.CheckedChanged += new System.EventHandler(this.TipoJuego);
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
            this.rbJugar.CheckedChanged += new System.EventHandler(this.TipoJuego);
            // 
            // gbTipoJuego
            // 
            this.gbTipoJuego.Controls.Add(this.rbDemo);
            this.gbTipoJuego.Controls.Add(this.rbJugar);
            this.gbTipoJuego.Location = new System.Drawing.Point(13, 13);
            this.gbTipoJuego.Name = "gbTipoJuego";
            this.gbTipoJuego.Size = new System.Drawing.Size(74, 88);
            this.gbTipoJuego.TabIndex = 24;
            this.gbTipoJuego.TabStop = false;
            this.gbTipoJuego.Text = "Tipo juego";
            // 
            // pictureBox0
            // 
            this.pictureBox0.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox0.BackgroundImage = global::Tp1___Lab2___2023.Properties.Resources.Caballero_Humano;
            this.pictureBox0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox0.Enabled = false;
            this.pictureBox0.Location = new System.Drawing.Point(87, 566);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(42, 42);
            this.pictureBox0.TabIndex = 27;
            this.pictureBox0.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(135, 566);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(231, 566);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 42);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(279, 566);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 42);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Location = new System.Drawing.Point(59, 614);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(42, 42);
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Location = new System.Drawing.Point(107, 614);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(42, 42);
            this.pictureBox7.TabIndex = 33;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Enabled = false;
            this.pictureBox8.Location = new System.Drawing.Point(156, 614);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(42, 42);
            this.pictureBox8.TabIndex = 32;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Enabled = false;
            this.pictureBox9.Location = new System.Drawing.Point(204, 614);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(42, 42);
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Enabled = false;
            this.pictureBox10.Location = new System.Drawing.Point(252, 614);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(42, 42);
            this.pictureBox10.TabIndex = 36;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Enabled = false;
            this.pictureBox11.Location = new System.Drawing.Point(300, 614);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(42, 42);
            this.pictureBox11.TabIndex = 35;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(183, 566);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(327, 566);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 42);
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Enabled = false;
            this.pictureBox12.Location = new System.Drawing.Point(348, 614);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(42, 42);
            this.pictureBox12.TabIndex = 39;
            this.pictureBox12.TabStop = false;
            // 
            // lBoxLog
            // 
            this.lBoxLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxLog.FormattingEnabled = true;
            this.lBoxLog.ItemHeight = 15;
            this.lBoxLog.Location = new System.Drawing.Point(12, 194);
            this.lBoxLog.Name = "lBoxLog";
            this.lBoxLog.ScrollAlwaysVisible = true;
            this.lBoxLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lBoxLog.Size = new System.Drawing.Size(454, 334);
            this.lBoxLog.TabIndex = 40;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.BackgroundImage")));
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Enabled = false;
            this.pictureBox13.Location = new System.Drawing.Point(532, 614);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(42, 42);
            this.pictureBox13.TabIndex = 41;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox14.BackgroundImage")));
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Enabled = false;
            this.pictureBox14.Location = new System.Drawing.Point(580, 614);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(42, 42);
            this.pictureBox14.TabIndex = 42;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox15.BackgroundImage")));
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Enabled = false;
            this.pictureBox15.Location = new System.Drawing.Point(628, 614);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(42, 42);
            this.pictureBox15.TabIndex = 43;
            this.pictureBox15.TabStop = false;
            // 
            // timerRonda
            // 
            this.timerRonda.Tick += new System.EventHandler(this.timerRonda_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(859, 685);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.lBoxLog);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox0);
            this.Controls.Add(this.gbTipoJuego);
            this.Controls.Add(this.gbVirtuales);
            this.Controls.Add(this.gbJugador);
            this.Controls.Add(this.gbDificultad);
            this.Controls.Add(this.lbMarcador);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.webBrowser1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbVirtuales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadJugadores)).EndInit();
            this.gbJugador.ResumeLayout(false);
            this.gbJugador.PerformLayout();
            this.gbDificultad.ResumeLayout(false);
            this.gbDificultad.PerformLayout();
            this.gbTipoJuego.ResumeLayout(false);
            this.gbTipoJuego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
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
        private System.Windows.Forms.GroupBox gbTipoJuego;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.ListBox lBoxLog;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Timer timerRonda;
    }
}

