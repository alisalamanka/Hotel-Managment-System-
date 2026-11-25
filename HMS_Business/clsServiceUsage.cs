using ClsGlobalClasses;
using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class clsServiceUsage
    {
        public int? ServiceUsageID { get; set; }
        public int? StayID { get; set; }
        public ClsStay StayInfo { get; set; }
        public int? ServiceID { get; set; }
        public ClsService ServiceInfo { get; set; }
        public int? EmployeeID { get; set; }
        public int? ApplicationID { get; set; }
        public decimal Price { get; set; }
        public int? CreatedByUserID { get; set; }
        public string Notes { get; set; }
        public short Status { get; set; }

        private enum EnServiceUsageStatus
        {
            Active = 1,
            Cancelled = 2
        }

        private EnServiceUsageStatus ServiceUsageStatus { get; set; }

        public enum EnMode
        {
            AddNew = 0,
            Update = 1
        }

        public EnMode Mode { get; set; }

        public clsServiceUsage()
        {
            ServiceUsageID = null;
            StayID = null;
            ServiceID = null;
            EmployeeID = null;
            ApplicationID = null;
            Price = 0;
            CreatedByUserID = null;
            Notes = string.Empty;
            Status = (short)EnServiceUsageStatus.Active;

            Mode = EnMode.AddNew;
        }

        public clsServiceUsage(
            int serviceUsageID,
            int stayID,
            int serviceID,
            int employeeID,
            int applicationID,
            decimal price,
            int createdByUserID,
            string notes,
            short status)
        {
            ServiceUsageID = serviceUsageID;
            StayID = stayID;
            StayInfo = ClsStay.Find(stayID);
            ServiceID = serviceID;
            ServiceInfo = ClsService.Find(serviceID);
            EmployeeID = employeeID;
            ApplicationID = applicationID;
            Price = price;
            CreatedByUserID = createdByUserID;
            Notes = notes;
            Status = status;
            ServiceUsageStatus = (EnServiceUsageStatus)status;

            Mode = EnMode.Update;
        }

        public static string GetStatusString(short statusNumber)
        {
            switch (statusNumber)
            {
                case 1: return "Active";
                case 2: return "Cancelled";
                default: return "Unknown";
            }
        }

        public static clsServiceUsage Find(int serviceUsageID)
        {
            int stayID = 0;
            int serviceID = 0;
            int employeeID = 0;
            int applicationID = 0;
            decimal price = 0;
            int createdByUserID = 0;
            string notes = string.Empty;
            short status = 0;
            Exception error = null;

            bool found = clsServiceUsageData.GetServiceUsageInfoByID(
                serviceUsageID,
                ref stayID,
                ref serviceID,
                ref employeeID,
                ref applicationID,
                ref price,
                ref createdByUserID,
                ref notes,
                ref status,
                ref error
            );
            if (error != null)
            {
                ClsUtil.ClsLogger.LogError($"Failed To Get Service Usage Info With ID = {serviceUsageID}", error);

            }
            if (!found)
                return null;

            return new clsServiceUsage(
                serviceUsageID,
                stayID,
                serviceID,
                employeeID,
                applicationID,
                price,
                createdByUserID,
                notes,
                (short)status
            );
        }

        private bool _AddNewServiceUsage()
        {
            Exception error = null;
            int? newID = clsServiceUsageData.AddNewServiceUsage(
                StayID.Value,
                ServiceID.Value,
                EmployeeID.Value,
                ApplicationID.Value,
                Price,
                CreatedByUserID.Value,
                Notes,
                ref error
            );
            if (error != null || newID == null)
            {
                ClsUtil.ClsLogger.LogError("Failed to add service Usage", error ?? error);
            }
            else
            {
                ServiceUsageID = newID.Value;
                return true;
            }
            return false;
        }

        private bool _UpdateServiceUsage()
        {
            Exception error = null;
            return clsServiceUsageData.UpdateServiceUsage(
                ServiceUsageID.Value,
                StayID.Value,
                ServiceID.Value,
                EmployeeID ?? 0,
                ApplicationID ?? 0,
                Price,
                Notes,
                Status,
                ref error
            );
        }

        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (_AddNewServiceUsage())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return _UpdateServiceUsage();

                default:
                    return false;
            }
        }

        public static DataTable GetAllServiceUsages()
        {
            Exception error = null;
            return clsServiceUsageData.GetServiceUsagesList(ref error);
        }

        public bool CancelServiceUsage()
        {
            Exception error = null;
            bool canceled = clsServiceUsageData.CancelServiceUsage(ServiceUsageID.Value, ref error);
            if (canceled)
            {
                Status = (short)EnServiceUsageStatus.Cancelled;
                ServiceUsageStatus = EnServiceUsageStatus.Cancelled;
            }
            else if (error != null)
            {
                ClsUtil.ClsLogger.LogError($"Failed to cancel ServiceUsage with ID {ServiceUsageID.Value}");
            }
            return canceled;
        }
    }
}