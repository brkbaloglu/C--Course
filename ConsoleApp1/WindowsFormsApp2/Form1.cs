//using ClassLibrary1;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace WindowsFormsApp2
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//            this.Load += Form1_Load1;
//        }
//        List<Plug> myList = null;
//        private void Form1_Load1(object sender, EventArgs e)
//        {
//            myList = Kit.getAllPlugins(Application.StartupPath + "//plugins");
//            foreach (Plug p in myList )
//            {
//                Button b = new Button();
//                b.Text = p.Name;
//                b.Click += B_Click;
//                flowLayoutPanel1.Controls.Add(b);
//            }
//        }

//        private void B_Click(object sender, EventArgs e)
//        {
//            foreach (Plug p in myList)
//            {
//                if (p.pName == (sender as Button).Text)
//                {
//                    run(p);
//                }
//            }
//        }

//        private void run(Plug p)
//        {
//            IPlugin obj = (IPlugin)Kit.CreateObject(p);
//            textBox1.Text = obj.action(textBox1.Text);
//        }
//    }
//}
