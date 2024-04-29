using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        delegate int Del(int x);
        delegate void Yaz(string metin);
        public Form1()
        {
            InitializeComponent();

            //this.Load += Form1_Load;
            //this.DoubleClick += Form1_DoubleClick;

            //Del myDelegate = x => x * x;
            //int y = myDelegate(3);
            //MessageBox.Show(y.ToString());

            //Yaz yaz = x => MessageBox.Show(x);
            //yaz("Merhaba3");

            //this.Click += Form1_Click;
            //this.Click += (s,e) =>
            //{
            //    MessageBox.Show(((MouseEventArgs)e).Location.ToString());
            //};


            Button btn = new Button();
            btn.Text = "Tıkla";
            btn.Name = "btnTikla";
            btn.Width = 200;
            btn.Height = 50;
            btn.Left = btn.Width + 5;
            btn.Click += delegate (object sender, EventArgs e) 
            {
                string mesaj = (sender as Button).Text;
                MessageBox.Show(mesaj);
            };
            this.Controls.Add(btn);
        }

        //private void Form1_Click(object sender, EventArgs e)
        //{
        //}

        //private void Form1_DoubleClick(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Merhaba2");
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Merhaba");
        //}
    }
}
