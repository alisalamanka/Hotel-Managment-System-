using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsEmployeeData
    {
        public static bool GetEmployeeInfoByID(
            int EmployeeID,
            ref int PersonID,
            ref int DepartmentID,
            ref bool IsActive,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetEmployeeInfoByID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            PersonID = (int)dr["PersonID"];
                            DepartmentID = (int)dr["DepartmentID"];
                            IsActive = (bool)dr["IsActive"];

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


        public static bool GetEmployeeInfoByPersonID(
            int PersonID,
            ref int EmployeeID,
            ref int DepartmentID,
            ref bool IsActive,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetEmployeeInfoByPersonID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            EmployeeID = (int)dr["EmployeeID"];
                            DepartmentID = (int)dr["DepartmentID"];
                            IsActive = (bool)dr["IsActive"];

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


        public static int? AddNewEmployee(
            int PersonID,
            int DepartmentID,
            bool IsActive,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_AddNewEmployee", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);

                    cnn.Open();

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return null;
            }
        }


        public static bool UpdateEmployee(
            int EmployeeID,
            int DepartmentID,
            bool IsActive,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_UpdateEmployee", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);

                    cnn.Open();

                    int RowsAffected = Convert.ToInt32(
                        cmd.ExecuteScalar());

                    return RowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }


        public static bool DeleteEmployee(
            int EmployeeID,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_DeleteEmployee", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    cnn.Open();

                    int RowsAffected = Convert.ToInt32(
                        cmd.ExecuteScalar());

                    return RowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }


        public static DataTable GetEmployeesList(
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_EmployeesList", cnn))
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


        public static bool EmployeeExistsByID(
            int EmployeeID,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_EmployeeExistsByID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    cnn.Open();

                    return Convert.ToInt32(
                        cmd.ExecuteScalar()) > 0;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }


        public static bool EmployeeExistsByPersonID(
            int PersonID,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_EmployeeExistsByPersonID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);

                    cnn.Open();

                    return Convert.ToInt32(
                        cmd.ExecuteScalar()) > 0;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }
    }
}