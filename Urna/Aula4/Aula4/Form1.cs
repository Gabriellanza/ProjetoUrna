using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4
{
    public partial class Form1 : Form
    {

        //declarar variaveis globais
        int totalvotoscandidato1 = 0;
        int totalvotoscandidato2 = 0;
        int totalvotoscandidato3 = 0;
        int totalvotoscandidato4 = 0;
        int totalvotosbranco = 0;


        public Form1()
        {
            InitializeComponent();
        }

     
 

        private void txtnumero_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtnumero1.Text.Length == 1)
            {
                txtnumero2.Focus();
            }
        }
        private void txtnumero2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtnumero2.Text.Length == 1)
            {
                txtnumero3.Focus();
            }
        }
        private void txtnumero3_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtnumero3.Text.Length == 1)
            {
                txtnumero4.Focus();
            }
        }
        private void txtnumero4_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtnumero4.Text.Length == 1)
            {
                txtnumero5.Focus();
            }
        }

        private void txtnumero5_KeyUp(object sender, KeyEventArgs e)
        {
            string numero_voto = txtnumero1.Text + txtnumero2.Text + txtnumero3.Text + txtnumero4.Text + txtnumero5.Text;



            switch (numero_voto)
            {
                case "22265":
                    lblNome.Text = "Goku";
                    pictureBox1.ImageLocation = AppContext.BaseDirectory.Replace(@"bin\Debug\", "") + @"Images\goku3.jpg";

                    break;
                case "78787":
                    lblNome.Text = "Naruto";
                    pictureBox1.ImageLocation = AppContext.BaseDirectory.Replace(@"bin\Debug\", "") + @"Images\naruto.jpg";
                    break;
                case "11122":
                    lblNome.Text = "Saitama";
                    pictureBox1.ImageLocation = AppContext.BaseDirectory.Replace(@"bin\Debug\", "") + @"Images\saitama.png";
                    break;
                case "55511":
                    lblNome.Text = "Meliodas";
                    pictureBox1.ImageLocation = AppContext.BaseDirectory.Replace(@"bin\Debug\", "") + @"Images\meliodas.jpg";
                    break;
                default:
                    lblNome.Text = "Não encontrado";
                    break;
            }
        }
        private void btnvotar_Click(object sender, EventArgs e)
        {
            string numero_voto = txtnumero1.Text + txtnumero2.Text + txtnumero3.Text + txtnumero4.Text + txtnumero5.Text;
            switch (numero_voto)
            {
                case "22265":
                    totalvotoscandidato1++;
                    lblNome.Text = "";
                    txtnumero1.Text = "";
                    txtnumero2.Text = "";
                    txtnumero3.Text = "";
                    txtnumero4.Text = "";
                    txtnumero5.Text = "";
                    pictureBox1.ImageLocation = "";
                    break;
                case "78787":
                    totalvotoscandidato2++;
                    lblNome.Text = "";
                    txtnumero1.Text = "";
                    txtnumero2.Text = "";
                    txtnumero3.Text = "";
                    txtnumero4.Text = "";
                    txtnumero5.Text = "";
                    pictureBox1.ImageLocation = "";
                    break;
                case "11122":
                    totalvotoscandidato3++;
                    lblNome.Text = "";
                    txtnumero1.Text = "";
                    txtnumero2.Text = "";
                    txtnumero3.Text = "";
                    txtnumero4.Text = "";
                    txtnumero5.Text = "";
                    pictureBox1.ImageLocation = "";
                    break;
                case "55511":
                    totalvotoscandidato4++;
                    lblNome.Text = "";
                    txtnumero1.Text = "";
                    txtnumero2.Text = "";
                    txtnumero3.Text = "";
                    txtnumero4.Text = "";
                    txtnumero5.Text = "";
                    pictureBox1.ImageLocation = "";
                    break;
                default:
                    break;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            gbOpcoes.Visible = false;
            resultgoku.Text = totalvotoscandidato1.ToString();
            resultnaruto.Text = totalvotoscandidato2.ToString();
            resultsaitama.Text = totalvotoscandidato3.ToString();
            resultmeliodas.Text = totalvotoscandidato4.ToString();
            resultbranco.Text = totalvotosbranco.ToString();

            if (totalvotoscandidato1>totalvotoscandidato2)
            {
                if (totalvotoscandidato1 > totalvotoscandidato3)
                {
                    if (totalvotoscandidato1 > totalvotoscandidato4)
                    {
                        ganhador.Text = "Goku";
                    }
                }
            }
            if (totalvotoscandidato2 > totalvotoscandidato1)
            {
                if (totalvotoscandidato2 > totalvotoscandidato3)
                {
                    if (totalvotoscandidato2 > totalvotoscandidato4)
                    {
                        ganhador.Text = "Naruto";
                    }
                }
            }
            if (totalvotoscandidato3 > totalvotoscandidato1)
            {
                if (totalvotoscandidato3 > totalvotoscandidato2)
                {
                    if (totalvotoscandidato3 > totalvotoscandidato4)
                    {
                        ganhador.Text = "Saitama";
                    }
                }
            }
            if (totalvotoscandidato4 > totalvotoscandidato1)
            {
                if (totalvotoscandidato4 > totalvotoscandidato2)
                {
                    if (totalvotoscandidato4 > totalvotoscandidato3)
                    {
                        ganhador.Text = "Meliodas";
                    }
                }
            }



        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            lblNome.Text = "";
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtnumero3.Text = "";
            txtnumero4.Text = "";
            txtnumero5.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void btnbranco_Click(object sender, EventArgs e)
        {
            totalvotosbranco++;
            lblNome.Text = "";
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtnumero3.Text = "";
            txtnumero4.Text = "";
            txtnumero5.Text = "";
            pictureBox1.ImageLocation = "";
        }









        /* 
           int numero = int.Parse(txtnumero.Text);

           switch (numero)
           {
               case 12345:
                   totalvotoscandidato1++;

                   break;
               case 54321:
                   totalvotoscandidato2++;
                   break;
               default:
                   lblNome.Text = "Não encontrado";
                   break;*/
    }
        }

