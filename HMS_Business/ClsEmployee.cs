using GlobalClasses;
using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsEmployee
    {
        public int? EmployeeID { get; set; }
        public int? PersonID { get; set; }
        public int? DepartmentID { get; set; }
        public bool IsActive { get; set; }

        public ClsPerson PersonInfo { get; set; }

        public enum EnMode
        {
            AddNew = 0,
            Update = 1
        }

        public EnMode Mode { get; set; }

        public ClsEmployee()
        {
            EmployeeID = null;
            PersonID = null;
            DepartmentID = null;
            IsActive = false;

            PersonInfo = new ClsPerson();

            Mode = EnMode.AddNew;
        }

        public ClsEmployee(
            int employeeID,
            int personID,
            int departmentID,
            bool isActive)
        {
            EmployeeID = employeeID;
            PersonID = personID;
            DepartmentID = departmentID;
            IsActive = isActive;

            PersonInfo = ClsPerson.Find(personID);

            Mode = EnMode.Update;
        }


        public static ClsEmployee Find(int employeeID)
        {
            int personID = 0;
            int departmentID = 0;
            bool isActive = false;
            Exception error = null;

            bool found = ClsEmployeeData.GetEmployeeInfoByID(
                employeeID,
                ref personID,
                ref departmentID,
                ref isActive,
                ref error);

            if (!found)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to get Employee Info with ID = {employeeID}",
                        error);
                }

                return null;
            }

            return new ClsEmployee(
                employeeID,
                personID,
                departmentID,
                isActive);
        }


        public static ClsEmployee FindByPersonID(int personID)
        {
            int employeeID = 0;
            int departmentID = 0;
            bool isActive = false;
            Exception error = null;

            bool found = ClsEmployeeData.GetEmployeeInfoByPersonID(
                personID,
                ref employeeID,
                ref departmentID,
                ref isActive,
                ref error);

            if (!found)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to get Employee Info for Person ID = {personID}",
                        error);
                }

                return null;
            }

            return new ClsEmployee(
                employeeID,
                personID,
                departmentID,
                isActive);
        }


        public static bool EmployeeExists(
            int employeeID,
            ref bool errorOccurred)
        {
            Exception exception = null;

            bool exists = ClsEmployeeData.EmployeeExistsByID(
                employeeID,
                ref exception);

            if (exception != null)
            {
                errorOccurred = true;

                ClsUtil.ClsLogger.LogError(
                    $"Failed to check Employee with ID = {employeeID}",
                    exception);
            }

            return exists;
        }


        public static bool EmployeeExistsForPerson(
            int personID,
            ref bool errorOccurred)
        {
            Exception exception = null;

            bool exists = ClsEmployeeData.EmployeeExistsByPersonID(
                personID,
                ref exception);

            if (exception != null)
            {
                errorOccurred = true;

                ClsUtil.ClsLogger.LogError(
                    $"Failed to check Employee for Person ID = {personID}",
                    exception);

                return false;
            }

            return exists;
        }


        public static DataTable GetAllDepartments()
        {
            Exception exception = null;
            DataTable dt= ClsEmployeeData.GetDepartmentsList(ref exception);
            if (exception!=null)
            {
                ClsUtil.ClsLogger.LogError("Failed to get depatments list", exception);
                return null;
            }
            return dt;
        }


        public bool AddNewEmployee()
        {
            Exception exception = null;

            int? newEmployeeID = ClsEmployeeData.AddNewEmployee(
                PersonID.Value,
                DepartmentID.Value,
                IsActive,
                ref exception);

            if (newEmployeeID == null)
            {
                if (exception != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        "Failed to Add New Employee",
                        exception);
                }

                return false;
            }

            EmployeeID = newEmployeeID;
            return true;
        }


        public bool UpdateEmployee()
        {
            Exception exception = null;

            bool updated = ClsEmployeeData.UpdateEmployee(
                EmployeeID.Value,
                DepartmentID.Value,
                IsActive,
                ref exception);

            if (exception != null)
            {
                ClsUtil.ClsLogger.LogError(
                    $"Failed to Update Employee with ID = {EmployeeID.Value}",
                    exception);

                return false;
            }

            return updated;
        }


        public bool DeleteEmployee()
        {
            Exception exception = null;

            bool deleted = ClsEmployeeData.DeleteEmployee(
                EmployeeID.Value,
                ref exception);

            if (!deleted)
            {
                if (exception != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to Delete Employee with ID = {EmployeeID.Value}",
                        exception);
                }

                return false;
            }

            return true;
        }


        public static DataTable GetAllEmployees()
        {
            Exception exception = null;

            DataTable dt = ClsEmployeeData.GetEmployeesList(
                ref exception);

            if (exception != null)
            {
                ClsUtil.ClsLogger.LogError(
                    "Failed to get Employees List",
                    exception);

                return null;
            }

            return dt;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:

                    if (AddNewEmployee())
                    {
                        Mode = EnMode.Update;
                        return EmployeeID != null;
                    }

                    return false;

                case EnMode.Update:

                    return UpdateEmployee();

                default:

                    return false;
            }
        }
    }
}