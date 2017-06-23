using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Using Necessary
using System.Threading;

namespace ThreadWithUI
{
    public partial class Form1 : Form
    {

        Thread hiloRojo;
        Thread hiloAzul;
        Random aleatorio;


        public Form1()
        {
            InitializeComponent();
            aleatorio = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hiloRojo = new Thread(pintarRojo);
            hiloRojo.Start();
        }

        public void pintarRojo()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().
                    DrawEllipse(new Pen(Color.Red, 4),
                    aleatorio.Next(0, this.Width),
                    aleatorio.Next(0, this.Height), 20, 20);
                Thread.Sleep(200);
            }
        }

        public void pintarAzul()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().
                    DrawEllipse(new Pen(Color.Blue, 4),
                    aleatorio.Next(0, this.Width),
                    aleatorio.Next(0, this.Height), 20, 20);
                Thread.Sleep(200);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hiloAzul = new Thread(pintarAzul);
            hiloAzul.Start();
        }
    }
}
