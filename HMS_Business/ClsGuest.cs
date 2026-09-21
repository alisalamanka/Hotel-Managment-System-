using GlobalClasses;
using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsGuest
    {
        public int? GuestID { get; set; }
        public int? PersonID { get; set; }
        public bool IsActive { get; set; }

        public ClsPerson PersonInfo { get; set; }

        public enum EnMode
        {
            AddNew = 0,
            Update = 1
        }

        public EnMode Mode { get; set; }


        public ClsGuest()
        {
            GuestID = null;
            PersonID = null;
            IsActive = false;

            PersonInfo = new ClsPerson();

            Mode = EnMode.AddNew;
        }


        public ClsGuest(
            int guestID,
            int personID,
            bool isActive)
        {
            GuestID = guestID;
            PersonID = personID;
            IsActive = isActive;

            PersonInfo = ClsPerson.Find(personID);

            Mode = EnMode.Update;
        }


        public static ClsGuest Find(int GuestID)
        {
            int personID = 0;
            bool isActive = false;
            Exception error = null;

            bool Found = ClsGuestData.GetGuestInfoByID(
                GuestID,
                ref personID,
                ref isActive,
                ref error);

            if (!Found)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to get Guest Info with ID = {GuestID}",
                        error);
                }

                return null;
            }

            return new ClsGuest(
                GuestID,
                personID,
                isActive);
        }


        public static ClsGuest FindByPersonID(int PersonID)
        {
            int guestID = 0;
            bool isActive = false;
            Exception error = null;

            bool Found = ClsGuestData.GetGuestInfoByPersonID(
                PersonID,
                ref guestID,
                ref isActive,
                ref error);

            if (!Found)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to get Guest Info for Person ID = {PersonID}",
                        error);
                }

                return null;
            }

            return new ClsGuest(
                guestID,
                PersonID,
                isActive);
        }


        public static bool GuestExistsByID(
            int GuestID,
            ref bool ErrorOccurred)
        {
            Exception exception = null;

            bool Exists = ClsGuestData.GuestExistsByID(
                GuestID,
                ref exception);

            if (exception != null)
            {
                ErrorOccurred = true;

                ClsUtil.ClsLogger.LogError(
                    $"Failed to check Guest with ID = {GuestID}",
                    exception);
            }

            return Exists;
        }


        public static bool GuestExistsByPersonID(
            int PersonID,
            ref bool ErrorOccurred)
        {
            Exception exception = null;

            bool Exists = ClsGuestData.GuestExistsByPersonID(
                PersonID,
                ref exception);

            if (exception != null)
            {
                ErrorOccurred = true;

                ClsUtil.ClsLogger.LogError(
                    $"Failed to check Guest for Person ID = {PersonID}",
                    exception);

                return false;
            }

            return Exists;
        }


        public bool AddNewGuest()
        {
            Exception exception = null;

            int? NewGuestID = ClsGuestData.AddNewGuest(
                PersonID.Value,
                IsActive,
                ref exception);

            if (NewGuestID == null)
            {
                if (exception != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        "Failed to Add New Guest",
                        exception);
                }

                return false;
            }

            GuestID = NewGuestID;

            return true;
        }


        public bool UpdateGuest()
        {
            Exception exception = null;

            bool Updated = ClsGuestData.UpdateGuest(
                GuestID.Value,
                PersonID.Value,

                PersonInfo.FirstName,
                PersonInfo.LastName,
                PersonInfo.DateOfBirth,
                PersonInfo.Phone,
                PersonInfo.Email,
                PersonInfo.NationalNumber,
                PersonInfo.CountryID,
                PersonInfo.Gendor,
                PersonInfo.ImagePath,

                IsActive,

                ref exception);

            if (exception != null)
            {
                ClsUtil.ClsLogger.LogError(
                    $"Failed to Update Guest with ID = {GuestID.Value}",
                    exception);

                return false;
            }

            return Updated;
        }


        public bool DeleteGuest()
        {
            Exception exception = null;

            bool Deleted = ClsGuestData.DeleteGuest(
                GuestID.Value,
                ref exception);

            if (!Deleted)
            {
                if (exception != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to Delete Guest with ID = {GuestID.Value}",
                        exception);
                }

                return false;
            }

            return true;
        }


        public static DataTable GetAllGuests()
        {
            Exception exception = null;

            DataTable dt = ClsGuestData.GetGuestsList(
                ref exception);

            if (exception != null)
            {
                ClsUtil.ClsLogger.LogError(
                    "Failed to get Guests List",
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

                    if (AddNewGuest())
                    {
                        Mode = EnMode.Update;

                        return GuestID != null;
                    }

                    return false;


                case EnMode.Update:

                    return UpdateGuest();


                default:

                    return false;
            }
        }
    }
}