//using Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Facade
//{
//    public class FShippers
//    {
//        public static bool Insert(EShipper shipper)
//        {
//            bool sonuc;
//            SqlConnection conn = new SqlConnection(Connection.ConnectionString);
//            SqlCommand cmd = new SqlCommand();
//            cmd.Connection = conn;
//            cmd.CommandType = System.Data.CommandType.StoredProcedure;
//            cmd.CommandText = "pr_ShipperAdd";

//            SqlParameter[] parameters =
//            {
//                new SqlParameter{ParameterName= "CompanyName", ValueTask=shipper.CompanyName},
//                new SqlParameter{ParameterName="Phone", ValueTask=shipper.Phone}
//            };

//            cmd.Parameters.AddRange(parameters);
//            try
//            {
//                if (conn.State != System.Data.ConnectionState.Open)
//                {
//                    conn.Open();
//                }
//                sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
//            }
//            catch (Exception ex) 
//            {
//                sonuc = false;
//            }
//            finally
//            {
//                if (conn.State != System.Data.ConnectionState.Closed)
//                {
//                    conn.Close();
//                }
//            }
//            return sonuc;
//        }
//    }
//}
