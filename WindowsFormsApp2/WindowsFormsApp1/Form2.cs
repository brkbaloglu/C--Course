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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGetAllShippers_Click(object sender, EventArgs e)
        {
            ShipperDAL shipperDAL = new ShipperDAL();
            dataGridView1.DataSource= shipperDAL.GetShippers();
        }
    }
}
