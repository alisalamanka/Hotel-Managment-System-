using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsDepartmentData
    {
        public static bool GetDepartmentInfoByID(
            int DepartmentID,
            ref string DepartmentName,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetDepartmentInfoByID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DepartmentName = dr["DepartmentName"].ToString();
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


        public static bool GetDepartmentInfoByName(
            string DepartmentName,
            ref int DepartmentID,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetDepartmentInfoByName", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DepartmentID = (int)dr["DepartmentID"];
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


        public static DataTable GetDepartmentsList(
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetDepartmentsList", cnn))
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