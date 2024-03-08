using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int puntaje_1 = 0;
        int puntaje_2 = 0;
        byte turno = 0;
        byte bot1 = 0;
        byte bot2 = 0;
        byte bot3 = 0;
        byte bot4 = 0;
        byte bot5 = 0;
        byte bot6 = 0;
        byte bot7 = 0;
        byte bot8 = 0;
        byte bot9 = 0;

        private void x1y3_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                x1y3.BackgroundImage = Gato.Properties.Resources.Tache_azul;
                turno = 1;
                bot9 = 1;

            }
            else
            {
                x1y3.BackgroundImage = Gato.Properties.Resources.Ciculo_Rojo;
                turno = 0;
                bot9 = 2;
            }
            x1y3.Enabled = false;
            ganar();
        }

        private void x2y3_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                x2y3.BackgroundImage = Gato.Properties.Resources.Tache_azul;
                turno = 1;
                bot8 = 1;
                x2y3.Enabled = false;
                ganar();

            }
            else
            {
                x2y3.BackgroundImage = Gato.Properties.Resources.Ciculo_Rojo;
                turno = 0;
                bot8 = 2;
                x2y3.Enabled = false;
                ganar();
            }
        }

        private void x3y3_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                x3y3.BackgroundImage = Gato.Properties.Resources.Tache_azul;
                turno = 1;
                bot7 = 1;
                x3y3.Enabled = false;
                ganar();

            }
            else
            {
                x3y3.BackgroundImage = Gato.Properties.Resources.Ciculo_Rojo;
                turno = 0;
                bot7 = 2;
                x3y3.Enabled = false;
                ganar();
            }
        }

        private void x1y2_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                x1y2.BackgroundImage = Gato.Properties.Resources.Tache_azul;
                turno = 1;
                bot6 = 1;
                x1y2.Enabled = false;
                ganar();

            }
            else
            {
                x1y2.BackgroundImage = Gato.Properties.Resources.Ciculo_Rojo;
                turno = 0;
                bot6 = 2;
                x1y2.Enabled = false;
                ganar();
            }
        }

        private void x2y2_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                x2y2.BackgroundImage = Gato.Properties.Resources.Tache_azul;
                turno = 1;
                bot5 = 1;
                x2y2.Enabled = false;
                ganar();

            }
            else
            {
                x2y2.BackgroundImage = Gato.Properties.Resources.Ciculo_Rojo;
                turno = 0;
                bot5 = 2;
                x2y2.Enabled = false;
                ganar();
            }
        }

        private void x3y2_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                x3y2.BackgroundImage = Gato.Properties.Resources.Tache_azul;
                turno = 1;
                bot4 = 1;
                x3y2.Enabled = false;
                ganar();

            }
            else
            {
                x3y2.BackgroundImage = Gato.Properties.Resources.Ciculo_Rojo;
                turno = 0;
                bot4 = 2;
                x3y2.Enabled = false;
                ganar();
            }
        }

        private void x1y1_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                x1y1.BackgroundImage = Gato.Properties.Resources.Tache_azul;
                turno = 1;
                bot3 = 1;
                x1y1.Enabled = false;
                ganar();

            }
            else
            {
                x1y1.BackgroundImage = Gato.Properties.Resources.Ciculo_Rojo;
                turno = 0;
                bot3 = 2;
                x1y1.Enabled = false;
                ganar();
            }
        }

        private void x2y1_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                x2y1.BackgroundImage = Gato.Properties.Resources.Tache_azul;
                turno = 1;
                bot2 = 1;
                x2y1.Enabled = false;
                ganar();

            }
            else
            {
                x2y1.BackgroundImage = Gato.Properties.Resources.Ciculo_Rojo;
                turno = 0;
                bot2 = 2;
                x2y1.Enabled = false;
                ganar();
            }
        }

        private void x3y1_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                x3y1.BackgroundImage = Gato.Properties.Resources.Tache_azul;
                turno = 1;
                bot1 = 1;
                x3y1.Enabled = false;
                ganar();

            }
            else
            {
                x3y1.BackgroundImage = Gato.Properties.Resources.Ciculo_Rojo;
                turno = 0;
                bot1 = 2;
                x3y1.Enabled = false;
                ganar();
            }
        }

        public void ganar()
        {
            // Jugador 1
            if( bot9 == 1 && bot8 == 1 && bot7 ==1)
            {
                MessageBox.Show("Gano el jugador 1");
                puntaje_1 = puntaje_1 + 1;
                textpun1.Text = puntaje_1.ToString();
                turno = 2;
                bloc();
                button1.Enabled = true;
            }
            else if (bot6 == 1 && bot5 == 1 && bot4 == 1)
            {
                MessageBox.Show("Gano el jugador 1");
                puntaje_1 = puntaje_1 + 1;
                textpun1.Text = puntaje_1.ToString();
                turno = 2;
                bloc();
                button1.Enabled = true;
            }
            else if (bot3 == 1 && bot2 == 1 && bot1 == 1)
            {
                MessageBox.Show("Gano el jugador 1");
                puntaje_1 = puntaje_1 + 1;
                textpun1.Text = puntaje_1.ToString();
                turno = 2;
                bloc();
                button1.Enabled = true;
            }
            else if (bot9 == 1 && bot6 == 1 && bot3 == 1)
            {
                MessageBox.Show("Gano el jugador 1");
                puntaje_1 = puntaje_1 + 1;
                textpun1.Text = puntaje_1.ToString();
                turno = 2;
                bloc();
                button1.Enabled = true;
            }
            else if (bot8 == 1 && bot5 == 1 && bot2 == 1)
            {
                MessageBox.Show("Gano el jugador 1");
                puntaje_1 = puntaje_1 + 1;
                textpun1.Text = puntaje_1.ToString();
                turno = 2;
                bloc();
                button1.Enabled = true;
            }
            else if (bot7 == 1 && bot4 == 1 && bot1 == 1)
            {
                MessageBox.Show("Gano el jugador 1");
                puntaje_1 = puntaje_1 + 1;
                textpun1.Text = puntaje_1.ToString();
                turno = 2;
                bloc();
                button1.Enabled = true;
            }
            else if (bot9 == 1 && bot5 == 1 && bot1 == 1)
            {
                MessageBox.Show("Gano el jugador 1");
                puntaje_1 = puntaje_1 + 1;
                textpun1.Text = puntaje_1.ToString();
                turno = 2;
                bloc();
                button1.Enabled = true;
            }
            else if (bot7 == 1 && bot5 == 1 && bot3 == 1)
            {
                MessageBox.Show("Gano el jugador 1");
                puntaje_1 = puntaje_1 + 1;
                textpun1.Text = puntaje_1.ToString();
                turno = 2;
                bloc();
                button1.Enabled = true;
            }


            // Jugador 2
            else if (bot9 == 2 && bot8 == 2 && bot7 == 2)
            {
                MessageBox.Show("Gano el jugador 2");
                puntaje_2 = puntaje_2 + 1;
                textpun2.Text = puntaje_2.ToString();
                turno = 1;
                bloc();
                button1.Enabled = true;
            }
            else if (bot6 == 2 && bot5 == 2 && bot4 == 2)
            {
                MessageBox.Show("Gano el jugador 1");
                puntaje_2 = puntaje_2 + 1;
                textpun2.Text = puntaje_2.ToString();
                turno = 1;
                bloc();
                button1.Enabled = true;
            }
            else if (bot3 == 2 && bot2 == 2 && bot1 == 2)
            {
                MessageBox.Show("Gano el jugador 2");
                puntaje_2 = puntaje_2 + 1;
                textpun2.Text = puntaje_2.ToString();
                turno = 1;
                bloc();
                button1.Enabled = true;
            }
            else if (bot9 == 2 && bot6 == 2 && bot3 == 2)
            {
                MessageBox.Show("Gano el jugador 2");
                puntaje_2 = puntaje_2 + 1;
                textpun2.Text = puntaje_2.ToString();
                turno = 1;
                bloc();
                button1.Enabled = true;
            }
            else if (bot8 == 2 && bot5 == 2 && bot2 == 2)
            {
                MessageBox.Show("Gano el jugador 2");
                puntaje_2 = puntaje_2 + 1;
                textpun2.Text = puntaje_2.ToString();
                turno = 1;
                bloc();
                button1.Enabled = true;
            }
            else if (bot7 == 2 && bot4 == 2 && bot1 == 2)
            {
                MessageBox.Show("Gano el jugador 2");
                puntaje_2 = puntaje_2 + 1;
                textpun2.Text = puntaje_2.ToString();
                turno = 1;
                bloc();
                button1.Enabled = true;
            }
            else if (bot9 == 2 && bot5 == 2 && bot1 == 2)
            {
                MessageBox.Show("Gano el jugador 2");
                puntaje_2 = puntaje_2 + 1;
                textpun2.Text = puntaje_2.ToString();
                turno = 1;
                bloc();
                button1.Enabled = true;
            }
            else if (bot7 == 2 && bot5 == 2 && bot3 == 2)
            {
                MessageBox.Show("Gano el jugador 2");
                puntaje_2 = puntaje_2 + 1;
                textpun2.Text = puntaje_2.ToString();
                turno = 1;
                bloc();
                button1.Enabled = true;
            }

            else if (bot1 != 0 && bot2 != 0 && bot3 != 0 && bot4 != 0 && bot5 != 0 && bot6 != 0 && bot7 != 0 && bot8 != 0 && bot9 != 0)
            {
                MessageBox.Show("Empate");
                bloc();
                button1.Enabled = true;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            turno = 0;
            bot1 = 0;
            bot2 = 0;
            bot3 = 0;
            bot4 = 0;
            bot5 = 0;
            bot6 = 0;
            bot7 = 0;
            bot8 = 0;
            bot9 = 0;

            x1y3.BackgroundImage = Gato.Properties.Resources.Cuadro_negro;
            x2y3.BackgroundImage = Gato.Properties.Resources.Cuadro_negro;
            x3y3.BackgroundImage = Gato.Properties.Resources.Cuadro_negro;
            x1y2.BackgroundImage = Gato.Properties.Resources.Cuadro_negro;
            x2y2.BackgroundImage = Gato.Properties.Resources.Cuadro_negro;
            x3y2.BackgroundImage = Gato.Properties.Resources.Cuadro_negro;
            x1y1.BackgroundImage = Gato.Properties.Resources.Cuadro_negro;
            x2y1.BackgroundImage = Gato.Properties.Resources.Cuadro_negro;
            x3y1.BackgroundImage = Gato.Properties.Resources.Cuadro_negro;

            x3y3.Enabled = true;
            x2y3.Enabled = true;
            x1y3.Enabled = true;
            x3y2.Enabled = true;
            x2y2.Enabled = true;
            x1y2.Enabled = true;
            x3y1.Enabled = true;
            x2y1.Enabled = true;
            x1y1.Enabled = true;
            button1.Enabled = false;

        }

        public void bloc()
        {
            x3y3.Enabled = false;
            x2y3.Enabled = false;
            x1y3.Enabled = false;
            x3y2.Enabled = false;
            x2y2.Enabled = false;
            x1y2.Enabled = false;
            x3y1.Enabled = false;
            x2y1.Enabled = false;
            x1y1.Enabled = false;
            button1.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textpun1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
