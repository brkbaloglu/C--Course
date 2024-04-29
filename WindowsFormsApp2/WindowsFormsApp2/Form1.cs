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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=.; Initial Catalog=testDB; Integrated Security=SSPI");

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                if (sqlConnection.State == ConnectionState.Open)
                {
                    //lblAlert.Text = "Bağlantı açık";                    
                }else if (sqlConnection.State == ConnectionState.Closed)
                {
                    //lblAlert.Text = "Bağlantı kapalı";                    
                }
                else
                {
                    //lblAlert.Text = "Bağlantıda sorun var";                    
                }
            }
            catch(SqlException ex)
            {
                //lblAlert.Text = "SQL Error"+ex.Message;                    

            }
        }

        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            //lblAlert.Text = sqlConnection.State.ToString();
        }
        private void btnOpenConn_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            //lblAlert.Text = sqlConnection.State.ToString();
        }
    }
}
