using ClsGlobalClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsServicesData
    {
        public static bool GetServiceInfoByID(int serviceID, ref string serviceName, ref string status)
        {
            bool isFound = false;
            try
            {
                string connString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_FindServiceByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ServiceID", serviceID);
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                isFound = true;
                                serviceName = dr["ServiceName"].ToString();
                                status = dr["Status"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                ClsUtil.ClsLogger.LogError($"Failed to get service with id = {serviceID}", ex);
            }

            return isFound;
        }

        public static DataTable GetAllServices()
        {
            DataTable dt = new DataTable();
            try
            {
                string connString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetAllServices", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClsUtil.ClsLogger.LogError("Failed to get all services", ex);
            }

            return dt;
        }

        public static int? AddNewService(string serviceName, string status)
        {
            int? serviceID = null;
            try
            {
                string connString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_AddNewService", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ServiceName", serviceName);
                        cmd.Parameters.AddWithValue("@Status", status);

                        conn.Open();
                        serviceID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                serviceID = null;
                ClsUtil.ClsLogger.LogError($"Failed to add new service = {serviceName}", ex);
            }

            return serviceID;
        }

        public static bool UpdateService(int serviceID, string serviceName, string status)
        {
            bool isUpdated = false;
            try
            {
                string connString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_UpdateService", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ServiceID", serviceID);
                        cmd.Parameters.AddWithValue("@ServiceName", serviceName);
                        cmd.Parameters.AddWithValue("@Status", status);

                        conn.Open();
                        isUpdated =Convert.ToInt16(cmd.ExecuteScalar())  == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                isUpdated = false;
                ClsUtil.ClsLogger.LogError($"Failed to update service with id = {serviceID}", ex);
            }

            return isUpdated;
        }

        public static bool DeleteService(int serviceID)
        {
            bool Deleted = false;
            try
            {
                string connString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_DeleteService", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ServiceID", serviceID);


                        conn.Open();
                        Deleted = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
    {
                Deleted = false;
                ClsUtil.ClsLogger.LogError($"Failed to Delete service with id = {serviceID}", ex);
            }

            return Deleted;

        }
    }
}
