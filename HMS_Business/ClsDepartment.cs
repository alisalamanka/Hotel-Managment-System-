using GlobalClasses;
using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsDepartment
    {
        public int? DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public ClsDepartment()
        {
            DepartmentID = null;
            DepartmentName = string.Empty;
        }

        public ClsDepartment(int departmentID, string departmentName)
        {
            DepartmentID = departmentID;
            DepartmentName = departmentName;
        }

        public static ClsDepartment Find(int DepartmentID)
        {
            string DepartmentName = string.Empty;
            Exception error = null;

            bool Found = ClsDepartmentData.GetDepartmentInfoByID(
                DepartmentID,
                ref DepartmentName,
                ref error);

            if (!Found)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to get Department Info with ID = {DepartmentID}",
                        error);
                }

                return null;
            }

            return new ClsDepartment(
                DepartmentID,
                DepartmentName);
        }

        public static ClsDepartment Find(string DepartmentName)
        {
            int DepartmentID = 0;
            Exception error = null;

            bool Found = ClsDepartmentData.GetDepartmentInfoByName(
                DepartmentName,
                ref DepartmentID,
                ref error);

            if (!Found)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to get Department Info with Name = {DepartmentName}",
                        error);
                }

                return null;
            }

            return new ClsDepartment(
                DepartmentID,
                DepartmentName);
        }

        public static DataTable GetAllDepartments()
        {
            Exception error = null;

            DataTable dt = ClsDepartmentData.GetDepartmentsList(
                ref error);

            if (error != null)
            {
                ClsUtil.ClsLogger.LogError(
                    "Failed to get Departments List",
                    error);

                return null;
            }

            return dt;
        }
    }
}