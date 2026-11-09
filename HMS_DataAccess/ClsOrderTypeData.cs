using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsOrderTypeData
    {

        public static bool GetOrderTypeInfoByID(
     int OrderTypeID,
     ref string OrderTypeName,

     ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetOrderTypeInfoByID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@OrderTypeID", OrderTypeID);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            OrderTypeID =
                                Convert.ToInt32(dr["OrderTypeID"]);

                            OrderTypeName =
                                Convert.ToString(dr["OrderTypeName"]);

                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }

        public static DataTable GetOrderTypesList(
             ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetOrderTypesList", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();

                        dt.Load(dr);

                        return dt;
                    }
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return null;
            }
        }

    }
}
