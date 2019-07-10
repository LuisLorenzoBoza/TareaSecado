using System;
using System.Windows.Forms;

namespace TareaDeSecado
{
    public partial class Form1 : Form
    {
        //  el secado del cafe 45 y 50 grados centigrados
        //  entre 25 y 30 horas
        //  El tiempo de secado sera 5 min como prueba el tiempo real son 25 a 30 horas

        public Form1()
        {
            InitializeComponent();
        }


        public void btnInicio_Click(object sender, EventArgs e)   /*inicio*/
        {
            timer1.Enabled = true;
            timer1.Start();

            int j = 0;
            int m = 0;
            Random rdn = new Random();
            int a = rdn.Next(1, 5);
            int x = 45;
            j = x + a;
            m = j;
            tbtemperatura.Text = Convert.ToString(m);

            //if (m > 45)
            //{
            //    do
            //    {
            //        compuerta(m);
            //    }
            //    while (m > 45);

            //}
            //else
            ////{
            //    tbtemperatura.Text = Convert.ToString(j);
            //}

        }

        public void compuerta(int j)
        {
            for (int i = 0; i <= j; i--)
                j--;
            tbtemperatura.Text = Convert.ToString(value: j);
        }






        private void Form1_Load(object sender, EventArgs e)
        { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cont = 0;
            do
            {
                pictureBox5.Left = pictureBox5.Left + 4;

                if (pictureBox5.Location.X == 740)
                {
                    pictureBox5.Left = 0;
                    cont++;
                    timer2.Enabled = true;
                }

            }
            while (cont == 1);
        }

        private void btnCafe_Click(object sender, EventArgs e)    /*cafe*/
        {
            pictureBox3.Image = Properties.Resources.grain_de_café_png;
            int x = 45;
            tbtemperatura.Text = Convert.ToString(x);
            int y = 5000;
            tbtiemposecado.Text = Convert.ToString(y);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int a = 0;
            for (int i = 0; i <= 5; i++)
            {
                timer2.Interval += 10;
                if (timer2.Interval == 50)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        a += 15;
                        label7.Text = String.Empty;
                        label7.Text = a.ToString();
                    }
                }
            }

            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int a = 60;
            for (int i = 0; i <= 5; i++)
            {
                timer3.Interval += 10;
                if (timer3.Interval == 50)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        a -= 5;
                        pictureBox7.Image = Properties.Resources.Fuego;
                        label7.Text = String.Empty;
                        label7.Text = a.ToString();
                    }
                }
            }
        }
    }
}
