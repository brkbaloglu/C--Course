using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Business;

namespace WindowsFormsApp1.Database
{
    internal class ShipperDAL
    {
        string sql = string.Empty;
        SqlConnection sqlConnection = new SqlConnection(Database.getConnectionString);
        SqlCommand SqlCommand;
        bool result;

        public bool Add(string companyName, string phone)
        {
            sql = "INSERT INTO Shippers VALUES ('" + companyName + "', '" + phone + "')";
            SqlCommand = new SqlCommand(sql, sqlConnection);

            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                int sonuc = SqlCommand.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex) 
            {
                throw;
            }
            finally
            {
                if (sqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            return result;
        }
        public bool Update(int id, string companyName, string phone)
        {
            sql = "UPDATE Shippers SET Companyname = '"+companyName+"', Phone = '"+phone+"' WHERE ShipperId="+id;
            SqlCommand = new SqlCommand(sql, sqlConnection);

            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                int sonuc = SqlCommand.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            return result;
        }

        public bool Delete(int id)
        {
            sql = "DELETE FROM Shippers WHERE ShipperId="+id;
            SqlCommand = new SqlCommand(sql, sqlConnection);

            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                int sonuc = SqlCommand.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            return result;
        }

        public string GetCompanyNameById(int id)
        {
            sql = "SELECT CompanyName FROM Shippers WHERE ShipperId="+id;
            SqlCommand = new SqlCommand(sql, sqlConnection);
            string companyName = string.Empty;

            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                companyName = SqlCommand.ExecuteScalar().ToString();

                
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            return companyName;
        }

        public List<Shipper> GetShippers()
        {
            sql = "SELECT ShipperId, CompanyName, Phone FROM Shippers ";
            SqlCommand = new SqlCommand(sql, sqlConnection);
            List<Shipper> shippers = new List<Shipper>();
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                SqlDataReader dr = SqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    shippers.Add(new Shipper((int)dr[0],dr[1].ToString(), dr[2].ToString()));
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            return shippers;
        }
    }
}
