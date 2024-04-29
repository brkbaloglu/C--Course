using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Database;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ShipperDAL shipperDAL = new ShipperDAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string companyName = txtSirketAd.Text;
            string phone = txtTelefon.Text;
            var result = shipperDAL.Add(companyName, phone);

            if (result)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string companyName = txtSirketAd.Text;
            string phone = txtTelefon.Text;
            var result = shipperDAL.Update(companyName, phone);

            if (result)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            
            
            var result = shipperDAL.Delete(companyName, phone);

            if (result)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }
    }
}
