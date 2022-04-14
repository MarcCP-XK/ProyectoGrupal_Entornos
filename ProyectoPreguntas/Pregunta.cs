using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPreguntas
{
    class Pregunta
    {
       
        String txtPregunta;
        int numCorrecto;
        String img;
        String respuesta1;
        String respuesta2;
        String respuesta3;
        String respuesta4;
        Boolean acertada;

        public Pregunta(string txtPregunta, int numCorrecto, string img, string respuesta1, string respuesta2, string respuesta3, string respuesta4)
        {
            this.TxtPregunta = txtPregunta;
            this.NumCorrecto = numCorrecto;
            this.Img = img;
            this.Respuesta1 = respuesta1;
            this.Respuesta2 = respuesta2;
            this.Respuesta3 = respuesta3;
            this.Respuesta4 = respuesta4;
            this.Acertada = false;
        }

       
        public string TxtPregunta { get => txtPregunta; set => txtPregunta = value; }
        public int NumCorrecto { get => numCorrecto; set => numCorrecto = value; }
        public string Img { get => img; set => img = value; }
        public string Respuesta1 { get => respuesta1; set => respuesta1 = value; }
        public string Respuesta2 { get => respuesta2; set => respuesta2 = value; }
        public string Respuesta3 { get => respuesta3; set => respuesta3 = value; }
        public string Respuesta4 { get => respuesta4; set => respuesta4 = value; }
        public bool Acertada { get => acertada; set => acertada = value; }
    }
}
