﻿namespace InicioPartida
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Tablero = new System.Windows.Forms.GroupBox();
            this.lbl_Turno = new System.Windows.Forms.Label();
            this.tirardado = new System.Windows.Forms.Button();
            this.seleccionarficha = new System.Windows.Forms.Button();
            this.conectadosGrid = new System.Windows.Forms.DataGridView();
            this.conected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invitar = new System.Windows.Forms.Button();
            this.label_invitar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Jugador_1 = new System.Windows.Forms.Label();
            this.Ficha_1_G = new System.Windows.Forms.Label();
            this.Ficha_2_G = new System.Windows.Forms.Label();
            this.Ficha_4_G = new System.Windows.Forms.Label();
            this.Ficha_3_G = new System.Windows.Forms.Label();
            this.Ficha_4_R = new System.Windows.Forms.Label();
            this.Ficha_3_R = new System.Windows.Forms.Label();
            this.Ficha_2_R = new System.Windows.Forms.Label();
            this.Ficha_1_R = new System.Windows.Forms.Label();
            this.Jugador_2 = new System.Windows.Forms.Label();
            this.Jugador_3 = new System.Windows.Forms.Label();
            this.Ficha_4_B = new System.Windows.Forms.Label();
            this.Ficha_3_B = new System.Windows.Forms.Label();
            this.Ficha_2_B = new System.Windows.Forms.Label();
            this.Ficha_1_B = new System.Windows.Forms.Label();
            this.Jugador_4 = new System.Windows.Forms.Label();
            this.Ficha_4_Y = new System.Windows.Forms.Label();
            this.Ficha_3_Y = new System.Windows.Forms.Label();
            this.Ficha_2_Y = new System.Windows.Forms.Label();
            this.Ficha_1_Y = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.jugadoresGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dado_1 = new System.Windows.Forms.Label();
            this.Dado_2 = new System.Windows.Forms.Label();
            this.Iniciar_Parida = new System.Windows.Forms.Button();
            this.cmBox_D1 = new System.Windows.Forms.ComboBox();
            this.cmBox_D2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tablero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conectadosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablero
            // 
            this.Tablero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tablero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tablero.BackgroundImage")));
            this.Tablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tablero.Controls.Add(this.lbl_Turno);
            this.Tablero.Location = new System.Drawing.Point(273, 12);
            this.Tablero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tablero.Name = "Tablero";
            this.Tablero.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tablero.Size = new System.Drawing.Size(867, 577);
            this.Tablero.TabIndex = 0;
            this.Tablero.TabStop = false;
            this.Tablero.Text = "Tablero";
            // 
            // lbl_Turno
            // 
            this.lbl_Turno.AutoSize = true;
            this.lbl_Turno.Location = new System.Drawing.Point(27, 47);
            this.lbl_Turno.Name = "lbl_Turno";
            this.lbl_Turno.Size = new System.Drawing.Size(42, 16);
            this.lbl_Turno.TabIndex = 0;
            this.lbl_Turno.Text = "Turno";
            // 
            // tirardado
            // 
            this.tirardado.Location = new System.Drawing.Point(12, 462);
            this.tirardado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tirardado.Name = "tirardado";
            this.tirardado.Size = new System.Drawing.Size(93, 48);
            this.tirardado.TabIndex = 4;
            this.tirardado.Text = "Tirar Dado";
            this.tirardado.UseVisualStyleBackColor = true;
            this.tirardado.Click += new System.EventHandler(this.tirardado_Click);
            // 
            // seleccionarficha
            // 
            this.seleccionarficha.Location = new System.Drawing.Point(112, 462);
            this.seleccionarficha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seleccionarficha.Name = "seleccionarficha";
            this.seleccionarficha.Size = new System.Drawing.Size(149, 48);
            this.seleccionarficha.TabIndex = 1;
            this.seleccionarficha.Text = "Seleccionar Ficha";
            this.seleccionarficha.UseVisualStyleBackColor = true;
            this.seleccionarficha.Click += new System.EventHandler(this.seleccionarficha_Click);
            // 
            // conectadosGrid
            // 
            this.conectadosGrid.AllowUserToAddRows = false;
            this.conectadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.conectadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conectadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conected});
            this.conectadosGrid.Enabled = false;
            this.conectadosGrid.Location = new System.Drawing.Point(21, 31);
            this.conectadosGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conectadosGrid.Name = "conectadosGrid";
            this.conectadosGrid.RowHeadersWidth = 51;
            this.conectadosGrid.RowTemplate.Height = 24;
            this.conectadosGrid.Size = new System.Drawing.Size(229, 220);
            this.conectadosGrid.TabIndex = 16;
            // 
            // conected
            // 
            this.conected.HeaderText = "Conectados";
            this.conected.MinimumWidth = 6;
            this.conected.Name = "conected";
            // 
            // Invitar
            // 
            this.Invitar.Location = new System.Drawing.Point(511, 604);
            this.Invitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Invitar.Name = "Invitar";
            this.Invitar.Size = new System.Drawing.Size(133, 49);
            this.Invitar.TabIndex = 21;
            this.Invitar.Text = "Invitar";
            this.Invitar.UseVisualStyleBackColor = true;
            this.Invitar.Click += new System.EventHandler(this.Invitar_Click_1);
            // 
            // label_invitar
            // 
            this.label_invitar.AutoSize = true;
            this.label_invitar.Location = new System.Drawing.Point(270, 625);
            this.label_invitar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invitar.Name = "label_invitar";
            this.label_invitar.Size = new System.Drawing.Size(45, 16);
            this.label_invitar.TabIndex = 20;
            this.label_invitar.Text = "Invitar:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(323, 617);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(1212, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(1212, 185);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox3.Location = new System.Drawing.Point(1212, 338);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 49);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(1212, 492);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 49);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // Jugador_1
            // 
            this.Jugador_1.AutoSize = true;
            this.Jugador_1.Location = new System.Drawing.Point(1208, 12);
            this.Jugador_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jugador_1.Name = "Jugador_1";
            this.Jugador_1.Size = new System.Drawing.Size(70, 16);
            this.Jugador_1.TabIndex = 26;
            this.Jugador_1.Text = "Jugador 1:";
            // 
            // Ficha_1_G
            // 
            this.Ficha_1_G.AutoSize = true;
            this.Ficha_1_G.Location = new System.Drawing.Point(1273, 31);
            this.Ficha_1_G.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_1_G.Name = "Ficha_1_G";
            this.Ficha_1_G.Size = new System.Drawing.Size(53, 16);
            this.Ficha_1_G.TabIndex = 27;
            this.Ficha_1_G.Text = "Ficha 1:";
            // 
            // Ficha_2_G
            // 
            this.Ficha_2_G.AutoSize = true;
            this.Ficha_2_G.Location = new System.Drawing.Point(1404, 31);
            this.Ficha_2_G.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_2_G.Name = "Ficha_2_G";
            this.Ficha_2_G.Size = new System.Drawing.Size(53, 16);
            this.Ficha_2_G.TabIndex = 28;
            this.Ficha_2_G.Text = "Ficha 2:";
            // 
            // Ficha_4_G
            // 
            this.Ficha_4_G.AutoSize = true;
            this.Ficha_4_G.Location = new System.Drawing.Point(1404, 64);
            this.Ficha_4_G.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_4_G.Name = "Ficha_4_G";
            this.Ficha_4_G.Size = new System.Drawing.Size(53, 16);
            this.Ficha_4_G.TabIndex = 30;
            this.Ficha_4_G.Text = "Ficha 4:";
            // 
            // Ficha_3_G
            // 
            this.Ficha_3_G.AutoSize = true;
            this.Ficha_3_G.Location = new System.Drawing.Point(1273, 64);
            this.Ficha_3_G.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_3_G.Name = "Ficha_3_G";
            this.Ficha_3_G.Size = new System.Drawing.Size(53, 16);
            this.Ficha_3_G.TabIndex = 29;
            this.Ficha_3_G.Text = "Ficha 3:";
            // 
            // Ficha_4_R
            // 
            this.Ficha_4_R.AutoSize = true;
            this.Ficha_4_R.Location = new System.Drawing.Point(1404, 218);
            this.Ficha_4_R.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_4_R.Name = "Ficha_4_R";
            this.Ficha_4_R.Size = new System.Drawing.Size(53, 16);
            this.Ficha_4_R.TabIndex = 35;
            this.Ficha_4_R.Text = "Ficha 4:";
            // 
            // Ficha_3_R
            // 
            this.Ficha_3_R.AutoSize = true;
            this.Ficha_3_R.Location = new System.Drawing.Point(1273, 218);
            this.Ficha_3_R.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_3_R.Name = "Ficha_3_R";
            this.Ficha_3_R.Size = new System.Drawing.Size(53, 16);
            this.Ficha_3_R.TabIndex = 34;
            this.Ficha_3_R.Text = "Ficha 3:";
            // 
            // Ficha_2_R
            // 
            this.Ficha_2_R.AutoSize = true;
            this.Ficha_2_R.Location = new System.Drawing.Point(1404, 185);
            this.Ficha_2_R.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_2_R.Name = "Ficha_2_R";
            this.Ficha_2_R.Size = new System.Drawing.Size(53, 16);
            this.Ficha_2_R.TabIndex = 33;
            this.Ficha_2_R.Text = "Ficha 2:";
            // 
            // Ficha_1_R
            // 
            this.Ficha_1_R.AutoSize = true;
            this.Ficha_1_R.Location = new System.Drawing.Point(1273, 185);
            this.Ficha_1_R.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_1_R.Name = "Ficha_1_R";
            this.Ficha_1_R.Size = new System.Drawing.Size(53, 16);
            this.Ficha_1_R.TabIndex = 32;
            this.Ficha_1_R.Text = "Ficha 1:";
            // 
            // Jugador_2
            // 
            this.Jugador_2.AutoSize = true;
            this.Jugador_2.Location = new System.Drawing.Point(1208, 165);
            this.Jugador_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jugador_2.Name = "Jugador_2";
            this.Jugador_2.Size = new System.Drawing.Size(70, 16);
            this.Jugador_2.TabIndex = 31;
            this.Jugador_2.Text = "Jugador 2:";
            // 
            // Jugador_3
            // 
            this.Jugador_3.AutoSize = true;
            this.Jugador_3.Location = new System.Drawing.Point(1208, 319);
            this.Jugador_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jugador_3.Name = "Jugador_3";
            this.Jugador_3.Size = new System.Drawing.Size(70, 16);
            this.Jugador_3.TabIndex = 36;
            this.Jugador_3.Text = "Jugador 3:";
            // 
            // Ficha_4_B
            // 
            this.Ficha_4_B.AutoSize = true;
            this.Ficha_4_B.Location = new System.Drawing.Point(1404, 372);
            this.Ficha_4_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_4_B.Name = "Ficha_4_B";
            this.Ficha_4_B.Size = new System.Drawing.Size(53, 16);
            this.Ficha_4_B.TabIndex = 40;
            this.Ficha_4_B.Text = "Ficha 4:";
            // 
            // Ficha_3_B
            // 
            this.Ficha_3_B.AutoSize = true;
            this.Ficha_3_B.Location = new System.Drawing.Point(1273, 372);
            this.Ficha_3_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_3_B.Name = "Ficha_3_B";
            this.Ficha_3_B.Size = new System.Drawing.Size(53, 16);
            this.Ficha_3_B.TabIndex = 39;
            this.Ficha_3_B.Text = "Ficha 3:";
            // 
            // Ficha_2_B
            // 
            this.Ficha_2_B.AutoSize = true;
            this.Ficha_2_B.Location = new System.Drawing.Point(1404, 338);
            this.Ficha_2_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_2_B.Name = "Ficha_2_B";
            this.Ficha_2_B.Size = new System.Drawing.Size(53, 16);
            this.Ficha_2_B.TabIndex = 38;
            this.Ficha_2_B.Text = "Ficha 2:";
            // 
            // Ficha_1_B
            // 
            this.Ficha_1_B.AutoSize = true;
            this.Ficha_1_B.Location = new System.Drawing.Point(1273, 338);
            this.Ficha_1_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_1_B.Name = "Ficha_1_B";
            this.Ficha_1_B.Size = new System.Drawing.Size(53, 16);
            this.Ficha_1_B.TabIndex = 37;
            this.Ficha_1_B.Text = "Ficha 1:";
            // 
            // Jugador_4
            // 
            this.Jugador_4.AutoSize = true;
            this.Jugador_4.Location = new System.Drawing.Point(1208, 473);
            this.Jugador_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jugador_4.Name = "Jugador_4";
            this.Jugador_4.Size = new System.Drawing.Size(70, 16);
            this.Jugador_4.TabIndex = 41;
            this.Jugador_4.Text = "Jugador 4:";
            // 
            // Ficha_4_Y
            // 
            this.Ficha_4_Y.AutoSize = true;
            this.Ficha_4_Y.Location = new System.Drawing.Point(1404, 526);
            this.Ficha_4_Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_4_Y.Name = "Ficha_4_Y";
            this.Ficha_4_Y.Size = new System.Drawing.Size(53, 16);
            this.Ficha_4_Y.TabIndex = 45;
            this.Ficha_4_Y.Text = "Ficha 4:";
            // 
            // Ficha_3_Y
            // 
            this.Ficha_3_Y.AutoSize = true;
            this.Ficha_3_Y.Location = new System.Drawing.Point(1273, 526);
            this.Ficha_3_Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_3_Y.Name = "Ficha_3_Y";
            this.Ficha_3_Y.Size = new System.Drawing.Size(53, 16);
            this.Ficha_3_Y.TabIndex = 44;
            this.Ficha_3_Y.Text = "Ficha 3:";
            // 
            // Ficha_2_Y
            // 
            this.Ficha_2_Y.AutoSize = true;
            this.Ficha_2_Y.Location = new System.Drawing.Point(1404, 492);
            this.Ficha_2_Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_2_Y.Name = "Ficha_2_Y";
            this.Ficha_2_Y.Size = new System.Drawing.Size(53, 16);
            this.Ficha_2_Y.TabIndex = 43;
            this.Ficha_2_Y.Text = "Ficha 2:";
            // 
            // Ficha_1_Y
            // 
            this.Ficha_1_Y.AutoSize = true;
            this.Ficha_1_Y.Location = new System.Drawing.Point(1273, 492);
            this.Ficha_1_Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ficha_1_Y.Name = "Ficha_1_Y";
            this.Ficha_1_Y.Size = new System.Drawing.Size(53, 16);
            this.Ficha_1_Y.TabIndex = 42;
            this.Ficha_1_Y.Text = "Ficha 1:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // jugadoresGrid
            // 
            this.jugadoresGrid.AllowUserToAddRows = false;
            this.jugadoresGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jugadoresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jugadoresGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.jugadoresGrid.Enabled = false;
            this.jugadoresGrid.Location = new System.Drawing.Point(21, 277);
            this.jugadoresGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jugadoresGrid.Name = "jugadoresGrid";
            this.jugadoresGrid.RowHeadersWidth = 51;
            this.jugadoresGrid.RowTemplate.Height = 24;
            this.jugadoresGrid.Size = new System.Drawing.Size(229, 154);
            this.jugadoresGrid.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Jugadores";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Dado_1
            // 
            this.Dado_1.AutoSize = true;
            this.Dado_1.Location = new System.Drawing.Point(18, 525);
            this.Dado_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dado_1.Name = "Dado_1";
            this.Dado_1.Size = new System.Drawing.Size(54, 16);
            this.Dado_1.TabIndex = 47;
            this.Dado_1.Text = "Dado 1:";
            // 
            // Dado_2
            // 
            this.Dado_2.AutoSize = true;
            this.Dado_2.Location = new System.Drawing.Point(135, 525);
            this.Dado_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dado_2.Name = "Dado_2";
            this.Dado_2.Size = new System.Drawing.Size(54, 16);
            this.Dado_2.TabIndex = 48;
            this.Dado_2.Text = "Dado 2:";
            // 
            // Iniciar_Parida
            // 
            this.Iniciar_Parida.Location = new System.Drawing.Point(650, 604);
            this.Iniciar_Parida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Iniciar_Parida.Name = "Iniciar_Parida";
            this.Iniciar_Parida.Size = new System.Drawing.Size(133, 49);
            this.Iniciar_Parida.TabIndex = 49;
            this.Iniciar_Parida.Text = "Iniciar";
            this.Iniciar_Parida.UseVisualStyleBackColor = true;
            this.Iniciar_Parida.Click += new System.EventHandler(this.Iniciar_Parida_Click);
            // 
            // cmBox_D1
            // 
            this.cmBox_D1.FormattingEnabled = true;
            this.cmBox_D1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmBox_D1.Location = new System.Drawing.Point(21, 588);
            this.cmBox_D1.Name = "cmBox_D1";
            this.cmBox_D1.Size = new System.Drawing.Size(84, 24);
            this.cmBox_D1.TabIndex = 50;
            // 
            // cmBox_D2
            // 
            this.cmBox_D2.FormattingEnabled = true;
            this.cmBox_D2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmBox_D2.Location = new System.Drawing.Point(138, 588);
            this.cmBox_D2.Name = "cmBox_D2";
            this.cmBox_D2.Size = new System.Drawing.Size(84, 24);
            this.cmBox_D2.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ficha a mover";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ficha a mover";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 664);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBox_D2);
            this.Controls.Add(this.cmBox_D1);
            this.Controls.Add(this.Iniciar_Parida);
            this.Controls.Add(this.Dado_2);
            this.Controls.Add(this.Dado_1);
            this.Controls.Add(this.jugadoresGrid);
            this.Controls.Add(this.Ficha_4_Y);
            this.Controls.Add(this.Ficha_3_Y);
            this.Controls.Add(this.Ficha_2_Y);
            this.Controls.Add(this.Ficha_1_Y);
            this.Controls.Add(this.Jugador_4);
            this.Controls.Add(this.Ficha_4_B);
            this.Controls.Add(this.Ficha_3_B);
            this.Controls.Add(this.Ficha_2_B);
            this.Controls.Add(this.Ficha_1_B);
            this.Controls.Add(this.Jugador_3);
            this.Controls.Add(this.Ficha_4_R);
            this.Controls.Add(this.Ficha_3_R);
            this.Controls.Add(this.Ficha_2_R);
            this.Controls.Add(this.Ficha_1_R);
            this.Controls.Add(this.Jugador_2);
            this.Controls.Add(this.Ficha_4_G);
            this.Controls.Add(this.Ficha_3_G);
            this.Controls.Add(this.Ficha_2_G);
            this.Controls.Add(this.Ficha_1_G);
            this.Controls.Add(this.Jugador_1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Invitar);
            this.Controls.Add(this.label_invitar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.conectadosGrid);
            this.Controls.Add(this.seleccionarficha);
            this.Controls.Add(this.tirardado);
            this.Controls.Add(this.Tablero);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.f2_Load);
            this.Tablero.ResumeLayout(false);
            this.Tablero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conectadosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Tablero;
        private System.Windows.Forms.Label lbl_Turno;
        private System.Windows.Forms.Button tirardado;
        private System.Windows.Forms.Button seleccionarficha;
        private System.Windows.Forms.DataGridView conectadosGrid;
        private System.Windows.Forms.Button Invitar;
        private System.Windows.Forms.Label label_invitar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Jugador_1;
        private System.Windows.Forms.Label Ficha_1_G;
        private System.Windows.Forms.Label Ficha_2_G;
        private System.Windows.Forms.Label Ficha_4_G;
        private System.Windows.Forms.Label Ficha_3_G;
        private System.Windows.Forms.Label Ficha_4_R;
        private System.Windows.Forms.Label Ficha_3_R;
        private System.Windows.Forms.Label Ficha_2_R;
        private System.Windows.Forms.Label Ficha_1_R;
        private System.Windows.Forms.Label Jugador_2;
        private System.Windows.Forms.Label Jugador_3;
        private System.Windows.Forms.Label Ficha_4_B;
        private System.Windows.Forms.Label Ficha_3_B;
        private System.Windows.Forms.Label Ficha_2_B;
        private System.Windows.Forms.Label Ficha_1_B;
        private System.Windows.Forms.Label Jugador_4;
        private System.Windows.Forms.Label Ficha_4_Y;
        private System.Windows.Forms.Label Ficha_3_Y;
        private System.Windows.Forms.Label Ficha_2_Y;
        private System.Windows.Forms.Label Ficha_1_Y;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView jugadoresGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn conected;
        private System.Windows.Forms.Label Dado_1;
        private System.Windows.Forms.Label Dado_2;
        private System.Windows.Forms.Button Iniciar_Parida;
        private System.Windows.Forms.ComboBox cmBox_D1;
        private System.Windows.Forms.ComboBox cmBox_D2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

