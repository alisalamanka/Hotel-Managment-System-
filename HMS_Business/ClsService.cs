using ClsGlobalClasses;
using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsService
    {
        public int? ServiceID { get; set; }
        public string ServiceName { get; set; }
        public bool Status { get; set; }

        public enum EnMode
        {
            AddNew = 0,
            Update = 1
        }

        public EnMode Mode { get; set; }

        public ClsService()
        {
            ServiceID = null;
            ServiceName = string.Empty;
            Status = true; 
            Mode = EnMode.AddNew;
        }

        public ClsService(int serviceID, string serviceName, bool status)
        {
            ServiceID = serviceID;
            ServiceName = serviceName;
            Status = status;
            Mode = EnMode.Update;
        }

        public static ClsService Find(int serviceID)
        {
            string serviceName = string.Empty;
            bool status = false;

            bool found = ClsServicesData.GetServiceInfoByID(serviceID, ref serviceName, ref status);

            if (found)
            {
                return new ClsService(serviceID, serviceName, status);
            }

            return null;
        }

        private bool _AddNewService()
        {
            int? newID = ClsServicesData.AddNewService(ServiceName, Status);

            if (newID.HasValue)
            {
                ServiceID = newID.Value;
                return true;
            }

            return false;
        }

        private bool _UpdateService()
        {
            return ClsServicesData.UpdateService(ServiceID.Value, ServiceName, Status);
        }

        public static bool DeleteService(int serviceID)
        {
            return ClsServicesData.DeleteService(serviceID);
        }

        public static DataTable GetAllServices()
        {
            return ClsServicesData.GetAllServices();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (_AddNewService())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return _UpdateService();

                default:
                    return false;
            }
        }
    }
}