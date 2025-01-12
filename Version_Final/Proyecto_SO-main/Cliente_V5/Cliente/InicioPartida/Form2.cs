using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InicioPartida
{
    public partial class Form2 : Form
    {
        Socket server;
        List<string> conectados = new List<string>();
        string usuario;
        int Conectados_Cont, Jugadores_Cont;
        List<string> jugadores = new List<string>();
        Random random = new Random();
        int[] dado = new int[2];
        int[] ficha_Roja = new int[4];
        int[] ficha_Verde = new int[4];
        int[] ficha_Azul = new int[4];
        int[] ficha_Amarilla = new int[4];
        int[] score = new int[4];
        string fichas;
        int partida, turno=1;
        public Form2(Socket sock, List<string> Conectados, string Usuario, Thread Atender, List<string> Jugadores, string Fichas, int Partida)
        {
            conectados = Conectados;
            server = sock;
            usuario = Usuario;
            jugadores = Jugadores;
            fichas = Fichas;
            partida = Partida;
            InitializeComponent();
            UpdateConectadosGrid();
        }

        public void FichasRecibidas(string mensaje)
        {
            fichas = mensaje;
            Actualizar_otras_fichas(); // Actualizar la interfaz con las nuevas fichas

        }

        private void f2_Load(object sender, EventArgs e)
        {
            Tablero.BackgroundImageLayout = ImageLayout.Stretch;
            Tablero.Visible = true;
            tirardado.Visible = false;
            seleccionarficha.Visible = false;
            Dado_1.Visible = false;
            Dado_2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            cmBox_D1.Visible = false;
            cmBox_D2.Visible = false;

        }


        private void UpdateConectadosGrid()
        {
            // Limpiar el DataGridView
            conectadosGrid.Rows.Clear();
            comboBox1.Items.Clear();

            // Agregar los jugadores conectados al DataGridView
            foreach (var jugador in conectados)
            {
                conectadosGrid.Rows.Add(jugador);
                comboBox1.Items.Add(jugador);

            }
        }
        private void UpdateInvitadosGrid()
        {
            // Limpiar el DataGridView
            jugadoresGrid.Rows.Clear();

            // Agregar los jugadores conectados al DataGridView
            foreach (var jugador in jugadores)
            {
                jugadoresGrid.Rows.Add(jugador);

            }
            Nombres();
        }
        private void Nombres()
        {
            try
            {
                Jugador_1.Text = "Jugador 1: " + jugadores[0];
            }
            catch { }
            try
            {
                Jugador_2.Text = "Jugador 2: " + jugadores[1];
            }
            catch { }
            try
            {
                Jugador_3.Text = "Jugador 3: " + jugadores[2];
            }
            catch { }
            try
            {
                Jugador_4.Text = "Jugador 4: " + jugadores[3];
            }
            catch { }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (conectados.Count != Conectados_Cont)
            {
                // El número de elementos en la lista ha cambiado
                Conectados_Cont = conectados.Count;
                UpdateConectadosGrid();
            }
            if (jugadores.Count != Jugadores_Cont)
            {

                Jugadores_Cont = jugadores.Count;
                UpdateInvitadosGrid();
            }
            if (partida == 1)
            {
                inicio();
                partida = 0;
            }
        }

        private void tirardado_Click(object sender, EventArgs e)
        {
            dado[0] = random.Next(1, 7);
            dado[1] = random.Next(1, 7);
            Dado_1.Text = "Dado 1: " + Convert.ToString(dado[0]);
            Dado_2.Text = "Dado 2: " + Convert.ToString(dado[1]);
            tirardado.Visible = false;

        }
        private void seleccionarficha_Click(object sender, EventArgs e)
        {
            int elegir = 0, dado1 = 0, dado2 = 0;
            dado1 = Convert.ToInt32(cmBox_D1.Text);
            dado2 = Convert.ToInt32(cmBox_D2.Text);
            if (dado1 != 1 && dado1 != 2 && dado1 != 3 && dado1 != 4 && dado2 != 1 && dado2 != 2 && dado2 != 3 && dado2 != 4)
            {
                MessageBox.Show("Escribe un numero del 1 al 4 de la ficha que quieres mover por cada dado");
                elegir = 1;

            }
            if (elegir == 0)
            {
                int i = 0, found = 0;
                while (i < jugadores.Count && found == 0)
                {
                    if (usuario == jugadores[i])
                    {
                        found = 1;
                    }
                    i++;
                }
                i--;
                if (found == 1)
                {
                    if (i == 0)
                    {
                        ficha_Verde[dado1 - 1] = ficha_Verde[dado1 - 1] + dado[0];
                        ficha_Verde[dado2 - 1] = ficha_Verde[dado2 - 1] + dado[1];
                        if (ficha_Verde[dado1 - 1] >= 72)
                        {
                            score[i]++;
                            if (score[1] == 4) { MessageBox.Show("¡Eljugador" + i + ":" + usuario + ". Ha ganado la partida!"); }
                        }
                        if (ficha_Verde[dado2 - 1] >= 72)
                        {
                            score[i]++;
                            if (score[1] == 4) { MessageBox.Show("¡Eljugador" + i + ":" + usuario + ". Ha ganado la partida!"); }
                        }
                    }
                    if (i == 1)
                    {
                        ficha_Roja[dado1 - 1] = ficha_Roja[dado1 - 1] + dado[0];
                        ficha_Roja[dado2 - 1] = ficha_Roja[dado2 - 1] + dado[1];
                        if (ficha_Roja[dado1 - 1] >= 72)
                        {
                            score[i]++;
                            if (score[1] == 4) { MessageBox.Show("¡Eljugador" + i + ":" + usuario + ". Ha ganado la partida!"); }
                        }
                        if (ficha_Roja[dado2 - 1] >= 72)
                        {
                            score[i]++;
                            if (score[1] == 4) { MessageBox.Show("¡Eljugador" + i + ":" + usuario + ". Ha ganado la partida!"); }
                        }
                    }
                    if (i == 2)
                    {
                        ficha_Azul[dado1 - 1] = ficha_Azul[dado1 - 1] + dado[0];
                        ficha_Azul[dado2 - 1] = ficha_Azul[dado2 - 1] + dado[1];
                        if (ficha_Azul[dado1 - 1] >= 72)
                        {
                            score[i]++;
                            if (score[1] == 4) { MessageBox.Show("¡Eljugador" + i + ":" + usuario + ". Ha ganado la partida!"); }
                        }
                        if (ficha_Azul[dado2 - 1] >= 72)
                        {
                            score[i]++;
                            if (score[1] == 4) { MessageBox.Show("¡Eljugador" + i + ":" + usuario + ". Ha ganado la partida!"); }
                        }
                    }
                    if (i == 3)
                    {
                        ficha_Amarilla[dado1 - 1] = ficha_Amarilla[dado1 - 1] + dado[0];
                        ficha_Amarilla[dado2 - 1] = ficha_Amarilla[dado2 - 1] + dado[1];
                        if (ficha_Amarilla[dado1 - 1] >= 72)
                        {
                            score[i]++;
                            if (score[1] == 4) { MessageBox.Show("¡Eljugador" + i + ":" + usuario + ". Ha ganado la partida!"); }
                        }
                        if (ficha_Amarilla[dado2 - 1] >= 72)
                        {
                            score[i]++;
                            if (score[1] == 4) { MessageBox.Show("¡Eljugador" + i + ":" + usuario + ". Ha ganado la partida!"); }
                        }
                    }
                    tirardado.Visible = false;
                    seleccionarficha.Visible = false;
                    Dado_1.Visible = false;
                    Dado_2.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    cmBox_D1.Visible = false;
                    cmBox_D2.Visible = false;
                }
                NotificarTurnoAsync();
            }
        }
        private async Task NotificarTurnoAsync()
        {
            Actualizar_fichas(); // Primera función

            await Task.Delay(1000); // Espera 1 segundo

            NotificarTurno(); // Segunda función
        }
        private void NotificarTurno()
        {
            string msg1;
            msg1 = "12";
            for (int x = 0; x < jugadores.Count; x++)
            {
                if (usuario != jugadores[x].ToString())
                {
                    msg1 = msg1 + "/" + jugadores[x].ToString();
                }

            }
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(msg1);
            server.Send(msg);
        }

        private void Iniciar_Parida_Click(object sender, EventArgs e)
        {
            if (jugadores.Count == 1 || jugadores.Count == 0)
            {
                MessageBox.Show("Invita a mas jugadores");
            }
            else
            {
                Invoke(new Action(() => inicio()));
                Invoke(new Action(() => Actualizar_fichas()));
                tirardado.Visible = true;
                seleccionarficha.Visible = true;
                Dado_1.Visible = true;
                Dado_2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                cmBox_D1.Visible = true;
                cmBox_D2.Visible = true;
            }

        }

        private void Invitar_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == usuario)
            {
                MessageBox.Show("No te puedes invitar a ti mismo");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecciona a alguien al que invitar");
            }
            else
            {
                string mensaje = "6/" + usuario + "/" + comboBox1.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }

        }
        private void inicio()
        {
            string iniciar;
            iniciar = "10";
            for (int i = 0; i < jugadores.Count; i++)
            {
                if (usuario != jugadores[i].ToString())
                {
                    iniciar = iniciar + "/" + jugadores[i].ToString();
                }

            }
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(iniciar);
            server.Send(msg);
            label_invitar.Visible = false;
            Invitar.Visible = false;
            comboBox1.Visible = false;
            Iniciar_Parida.Visible = false;
            for (int i = 0; i < 3; i++)
            {
                ficha_Verde[i] = 0;
                ficha_Roja[i] = 0;
                ficha_Azul[i] = 0;
                ficha_Amarilla[i] = 0;
            }
            Actualizar_otras_fichas();
            if (jugadores.Count == 2)
            {
                Jugador_3.Visible = false;
                pictureBox3.Visible = false;
                Jugador_4.Visible = false;
                pictureBox4.Visible = false;
                Ficha_1_B.Visible = false;
                Ficha_2_B.Visible = false;
                Ficha_3_B.Visible = false;
                Ficha_4_B.Visible = false;
                Ficha_1_Y.Visible = false;
                Ficha_2_Y.Visible = false;
                Ficha_3_Y.Visible = false;
                Ficha_4_Y.Visible = false;
            }
            if (jugadores.Count == 3)
            {
                Jugador_4.Visible = false;
                pictureBox4.Visible = false;
                Ficha_1_Y.Visible = false;
                Ficha_2_Y.Visible = false;
                Ficha_3_Y.Visible = false;
                Ficha_4_Y.Visible = false;
            }

        }
        private void Actualizar_fichas() //Actualiza las fichas cuando mueves tu y las envia
        {
            //Azules
            Ficha_1_B.Text = "Ficha 1: " + Convert.ToString(ficha_Azul[0]);
            Ficha_2_B.Text = "Ficha 2: " + Convert.ToString(ficha_Azul[1]);
            Ficha_3_B.Text = "Ficha 3: " + Convert.ToString(ficha_Azul[2]);
            Ficha_4_B.Text = "Ficha 4: " + Convert.ToString(ficha_Azul[3]);
            //Verdes
            Ficha_1_G.Text = "Ficha 1: " + Convert.ToString(ficha_Verde[0]);
            Ficha_2_G.Text = "Ficha 2: " + Convert.ToString(ficha_Verde[1]);
            Ficha_3_G.Text = "Ficha 3: " + Convert.ToString(ficha_Verde[2]);
            Ficha_4_G.Text = "Ficha 4: " + Convert.ToString(ficha_Verde[3]);
            //Rojas
            Ficha_1_R.Text = "Ficha 1: " + Convert.ToString(ficha_Roja[0]);
            Ficha_2_R.Text = "Ficha 2: " + Convert.ToString(ficha_Roja[1]);
            Ficha_3_R.Text = "Ficha 3: " + Convert.ToString(ficha_Roja[2]);
            Ficha_4_R.Text = "Ficha 4: " + Convert.ToString(ficha_Roja[3]);
            //Amarillas
            Ficha_1_Y.Text = "Ficha 1: " + Convert.ToString(ficha_Amarilla[0]);
            Ficha_2_Y.Text = "Ficha 2: " + Convert.ToString(ficha_Amarilla[1]);
            Ficha_3_Y.Text = "Ficha 3: " + Convert.ToString(ficha_Amarilla[2]);
            Ficha_4_Y.Text = "Ficha 4: " + Convert.ToString(ficha_Amarilla[3]);
            string players = "";
            for (int i = 0; i < jugadores.Count; i++)
            {
                if (usuario != jugadores[i].ToString())
                {
                    players = players + jugadores[i].ToString() + "/";
                }

            }
            string fichas_enviar = "11/" + (jugadores.Count - 1) + "/" + players +

                Convert.ToString(ficha_Azul[0]) + "/" +
                Convert.ToString(ficha_Azul[1]) + "/" +
                Convert.ToString(ficha_Azul[2]) + "/" +
                Convert.ToString(ficha_Azul[3]) + "/" +

                Convert.ToString(ficha_Verde[0]) + "/" +
                Convert.ToString(ficha_Verde[1]) + "/" +
                Convert.ToString(ficha_Verde[2]) + "/" +
                Convert.ToString(ficha_Verde[3]) + "/" +

                Convert.ToString(ficha_Roja[0]) + "/" +
                Convert.ToString(ficha_Roja[1]) + "/" +
                Convert.ToString(ficha_Roja[2]) + "/" +
                Convert.ToString(ficha_Roja[3]) + "/" +

                Convert.ToString(ficha_Amarilla[0]) + "/" +
                Convert.ToString(ficha_Amarilla[1]) + "/" +
                Convert.ToString(ficha_Amarilla[2]) + "/" +
                Convert.ToString(ficha_Amarilla[3]);
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(fichas_enviar);
            server.Send(msg);
        }
        private void Actualizar_otras_fichas() //Actualiza las fichas cuando las recibe de los otros
        {
            if (fichas != null)
            {
                string[] trozos = fichas.Split('/');
                ficha_Azul[0] = Convert.ToInt32(trozos[0]);
                ficha_Azul[1] = Convert.ToInt32(trozos[1]);
                ficha_Azul[2] = Convert.ToInt32(trozos[2]);
                ficha_Azul[3] = Convert.ToInt32(trozos[3]);

                ficha_Verde[0] = Convert.ToInt32(trozos[4]);
                ficha_Verde[1] = Convert.ToInt32(trozos[5]);
                ficha_Verde[2] = Convert.ToInt32(trozos[6]);
                ficha_Verde[3] = Convert.ToInt32(trozos[7]);

                ficha_Roja[0] = Convert.ToInt32(trozos[8]);
                ficha_Roja[1] = Convert.ToInt32(trozos[9]);
                ficha_Roja[2] = Convert.ToInt32(trozos[10]);
                ficha_Roja[3] = Convert.ToInt32(trozos[11]);

                ficha_Amarilla[0] = Convert.ToInt32(trozos[12]);
                ficha_Amarilla[1] = Convert.ToInt32(trozos[13]);
                ficha_Amarilla[2] = Convert.ToInt32(trozos[14]);
                ficha_Amarilla[3] = Convert.ToInt32(trozos[15]);

                //Azules
                Ficha_1_B.Text = "Ficha 1: " + Convert.ToString(ficha_Azul[0]);
                Ficha_2_B.Text = "Ficha 2: " + Convert.ToString(ficha_Azul[1]);
                Ficha_3_B.Text = "Ficha 3: " + Convert.ToString(ficha_Azul[2]);
                Ficha_4_B.Text = "Ficha 4: " + Convert.ToString(ficha_Azul[3]);
                //Verdes
                Ficha_1_G.Text = "Ficha 1: " + Convert.ToString(ficha_Verde[0]);
                Ficha_2_G.Text = "Ficha 2: " + Convert.ToString(ficha_Verde[1]);
                Ficha_3_G.Text = "Ficha 3: " + Convert.ToString(ficha_Verde[2]);
                Ficha_4_G.Text = "Ficha 4: " + Convert.ToString(ficha_Verde[3]);
                //Rojas
                Ficha_1_R.Text = "Ficha 1: " + Convert.ToString(ficha_Roja[0]);
                Ficha_2_R.Text = "Ficha 2: " + Convert.ToString(ficha_Roja[1]);
                Ficha_3_R.Text = "Ficha 3: " + Convert.ToString(ficha_Roja[2]);
                Ficha_4_R.Text = "Ficha 4: " + Convert.ToString(ficha_Roja[3]);
                //Amarillas
                Ficha_1_Y.Text = "Ficha 1: " + Convert.ToString(ficha_Amarilla[0]);
                Ficha_2_Y.Text = "Ficha 2: " + Convert.ToString(ficha_Amarilla[1]);
                Ficha_3_Y.Text = "Ficha 3: " + Convert.ToString(ficha_Amarilla[2]);
                Ficha_4_Y.Text = "Ficha 4: " + Convert.ToString(ficha_Amarilla[3]);

            }
        }
        public void TeToca()
        {
            turno++;
            if (turno > jugadores.Count) { turno = 1; }
            tirardado.Visible = true;
            seleccionarficha.Visible = true;
            Dado_1.Visible = true;
            Dado_2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            cmBox_D1.Visible = true;
            cmBox_D2.Visible = true;
        }
    }
}



