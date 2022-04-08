using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPreguntas
{
    public partial class Form4_VentanaPreguntas : Form
    {

        private Pregunta[] preguntas;
        private int numPregunta;

        public Form4_VentanaPreguntas()
        {
            InitializeComponent();
            numPregunta = 0;
            cargaPreguntas();
        }

        private void Form4_VentanaPreguntas_Load(object sender, EventArgs e)
        {
            temporizadorPreguntas.Interval = 1000;
            temporizadorPreguntas.Tick += new EventHandler(temporizadorTick);
            muestraPregunta();
        }

        private void cargaPreguntas()
        {
            preguntas = new Pregunta[10];
            preguntas[0] = new Pregunta("¿Que color ves en la Imagen?", 3, "n.png", "Rojo", "Verde", "Azul", "Amarillo");
            preguntas[1] = new Pregunta("¿1?", 3, "transparent.jpg", "Rojo", "Verde", "Azul", "Amarillo");
            preguntas[2] = new Pregunta("¿2?", 3, "img.jpg", "Rojo", "Verde", "Azul", "Amarillo");
            preguntas[3] = new Pregunta("¿3?", 3, "img.jpg", "Rojo", "Verde", "Azul", "Amarillo");
            preguntas[4] = new Pregunta("¿4?", 3, "img.jpg", "Rojo", "Verde", "Azul", "Amarillo");
            preguntas[5] = new Pregunta("¿5?", 3, "img.jpg", "Rojo", "Verde", "Azul", "Amarillo");
            preguntas[6] = new Pregunta("¿6?", 3, "img.jpg", "Rojo", "Verde", "Azul", "Amarillo");
            preguntas[7] = new Pregunta("¿Que color ves en la Imagen?", 3, "img.jpg", "Rojo", "Verde", "Azul", "Amarillo");
            preguntas[8] = new Pregunta("¿Que color ves en la Imagen?", 3, "img.jpg", "Rojo", "Verde", "Azul", "Amarillo");
            preguntas[9] = new Pregunta("¿Que color ves en la Imagen?", 3, "img.jpg", "Rojo", "Verde", "Azul", "Amarillo");

        }

        private void muestraPregunta()
        {
            labelTiempo.Text = "8";
            labelPregunta.Text = preguntas[numPregunta].TxtPregunta;
            try{
                pictureboxImagen.Image = Image.FromFile(@"C:\Users\Kiko\OneDrive\Desktop\Proyecto Grupal\ProyectoPreguntas\imagenes\ImagenesPreguntas\" + preguntas[numPregunta].Img);
            }
            catch (Exception)
            {

                pictureboxImagen.Image = Image.FromFile(@"C:\Users\Kiko\OneDrive\Desktop\Proyecto Grupal\ProyectoPreguntas\imagenes\ImagenesPreguntas\transparent.jpg");
            }
            
            buttonRespuesta1.Text = preguntas[numPregunta].Respuesta1;
            buttonRespuesta2.Text = preguntas[numPregunta].Respuesta2;
            buttonRespuesta3.Text = preguntas[numPregunta].Respuesta3;
            buttonRespuesta4.Text = preguntas[numPregunta].Respuesta4;
            buttonRespuesta1.BackColor = SystemColors.Control;
            buttonRespuesta2.BackColor = SystemColors.Control;
            buttonRespuesta3.BackColor = SystemColors.Control;
            buttonRespuesta4.BackColor = SystemColors.Control;

            labelTiempo.ForeColor = Color.Black;
           
            temporizadorPreguntas.Start();

        }

        private void buttonRespuestas_Click(object sender, EventArgs e)
        {
            temporizadorPreguntas.Stop();
            Button buttonClick = (Button)sender;
            if (Int32.Parse(buttonClick.Tag.ToString()) == preguntas[numPregunta].NumCorrecto)
            {
                buttonClick.BackColor = Color.Green;
                preguntas[numPregunta].Acertada = true;
                MessageBox.Show("Respuesta Correcta");
                }
            else
            {
                buttonClick.BackColor = Color.Red;
                    switch (preguntas[numPregunta].NumCorrecto)
                    {

                        case 1:
                            buttonRespuesta1.BackColor = Color.Green;
                            break;

                        case 2:
                            buttonRespuesta2.BackColor = Color.Green;
                            break;

                        case 3:
                            buttonRespuesta3.BackColor = Color.Green;
                            break;

                        case 4:
                            buttonRespuesta4.BackColor = Color.Green;
                            break;

                    }
                    MessageBox.Show("Respuesta Incorrecta");
                }

               
            pasaPregunta();

        
        }

        private void pasaPregunta()
        {
            if (numPregunta<preguntas.Length-1)
            {
                numPregunta++;
                labelNumPregunta.Text = numPregunta + 1 + "/10";
                muestraPregunta();
            }
            else
            {

                //Abrir pantalla resultado
                this.Close();
            }
            


        }

        public void temporizadorTick(object sender, EventArgs e)
        {
            
            int num = Int32.Parse(labelTiempo.Text);

            labelTiempo.Text = (num - 1).ToString();

            if (num == 5)
            {

                labelTiempo.ForeColor = Color.Red;

            }

            if(num == 1)
            {
                tiempoAgotado();
                MessageBox.Show("Tiempo Agotado");
                pasaPregunta();
               
            }
          
        }

        public void tiempoAgotado()
        { 
            switch(preguntas[numPregunta].NumCorrecto){

                case 1:
                    buttonRespuesta1.BackColor = Color.Green;
                    buttonRespuesta2.BackColor = Color.Red;
                    buttonRespuesta3.BackColor = Color.Red;
                    buttonRespuesta4.BackColor = Color.Red;
                    break;

                case 2:
                    buttonRespuesta1.BackColor = Color.Red;
                    buttonRespuesta2.BackColor = Color.Green;
                    buttonRespuesta3.BackColor = Color.Red;
                    buttonRespuesta4.BackColor = Color.Red;
                    break;

                case 3:
                    buttonRespuesta1.BackColor = Color.Red;
                    buttonRespuesta2.BackColor = Color.Red;
                    buttonRespuesta3.BackColor = Color.Green;
                    buttonRespuesta4.BackColor = Color.Red;
                    break;

                case 4:
                    buttonRespuesta1.BackColor = Color.Red;
                    buttonRespuesta2.BackColor = Color.Red;
                    buttonRespuesta3.BackColor = Color.Red;
                    buttonRespuesta4.BackColor = Color.Green;
                    break;

            }
            temporizadorPreguntas.Stop();

        }
       
    }
}
