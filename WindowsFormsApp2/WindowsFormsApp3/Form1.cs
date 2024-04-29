using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        //SqlConnection sqlConnection = new SqlConnection();
        //SqlCommand command;
        //public void KategorileriDoldur()
        //{
        //    DataTable dataTable = new DataTable();
        //    //command = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories", sqlConnection);
        //    try
        //    {
        //        if (sqlConnection.State != ConnectionState.Open)
        //        {
        //            sqlConnection.Open();
        //        }
        //        dataTable.Load(command.ExecuteReader());
        //        comboBoxKategoriler.DataSource = dataTable;
        //        comboBoxKategoriler.DisplayMember = "CategoryName";
        //        comboBoxKategoriler.ValueMember = "CategoryID";


        //    }
        //}
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Load += Form1_Load1;
        }

        private void Form1_Load1(object sender, EventArgs e)
        {
            //KategorileriDoldur();
        }
    }
}
