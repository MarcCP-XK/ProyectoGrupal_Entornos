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
    public partial class Form2 : Form
    {

        String usuario = "Admin";
        String password = "1234";

        public Form2()
        {
            InitializeComponent();


        }

        private void b_start_Click(object sender, EventArgs e)
        {
            if (txtb_usuario.Text == usuario & txtb_password.Text == password)
            {

                //Form1 f1 = new Form1();
                //f1.Show();

                //Hide();

            }
            else
            {
                txtb_usuario.BackColor = Color.Red;
                txtb_password.BackColor = Color.Red;
                pictureBox1.Image = Image.FromFile(@"..\..\..\imagenes\noPuedesPasar.jpg");
                timerForm2.Start();
                timerForm2.Tick += new EventHandler(TimerEventProcessor);


            }
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\imagenes\usuarioInterrogante.jpg");
            txtb_usuario.BackColor = SystemColors.Window;
            txtb_password.BackColor = SystemColors.Window;

            timerForm2.Stop();
        }
    }
}
