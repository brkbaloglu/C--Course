using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Random rnd;
        Thread th1, th2, th3;
        public Form1()
        {
            InitializeComponent();
            buttonBlue.Click += ButtonBlue_Click;
            buttonRed.Click += ButtonRed_Click;
            buttonYellow.Click += ButtonYellow_Click;
        }

        private void ButtonYellow_Click(object sender, EventArgs e)
        {
            th1 = new Thread(metot1);
            th1.Start();
        }

        private void ButtonRed_Click(object sender, EventArgs e)
        {
            th3 = new Thread(metot3);
            th3.Start();
        }

        private void ButtonBlue_Click(object sender, EventArgs e)
        {
            th2 = new Thread(metot2);
            th2.Start();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }
        public void metot1()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Yellow, 4),
                    new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 30, 30)
                    );
                Thread.Sleep(100);
            }
        }
        public void metot2()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Blue, 4),
                    new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 30, 30)
                    );
                Thread.Sleep(100);
            }
        }
        public void metot3()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Red, 4),
                    new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 30, 30)
                    );
                Thread.Sleep(100);
            }
        }
    }
}
