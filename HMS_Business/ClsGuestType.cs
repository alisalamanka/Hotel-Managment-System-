using GlobalClasses;
using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsGuestType
    {
        public int? GuestTypeID { get; set; }
        public string GuestTypeName { get; set; }

        public enum EnMode
        {
            AddNew = 0,
            Update = 1
        }

        public EnMode Mode { get; set; }

        public ClsGuestType()
        {
            GuestTypeID = null;
            GuestTypeName = "";

            Mode = EnMode.AddNew;
        }

        private ClsGuestType(
            int GuestTypeID,
            string GuestTypeName)
        {
            this.GuestTypeID = GuestTypeID;
            this.GuestTypeName = GuestTypeName;

            Mode = EnMode.Update;
        }

        public static ClsGuestType Find(int GuestTypeID)
        {
            string GuestTypeName = "";
            Exception ErrorOccurred = null;

            bool Found =
                ClsGuestTypeData.GetGuestTypeInfoByID(
                    GuestTypeID,
                    ref GuestTypeName,
                    ref ErrorOccurred);

            if (ErrorOccurred != null)
            {
                ClsUtil.ClsLogger.LogError(
                    ErrorOccurred.ToString());
            }

            if (Found)
            {
                return new ClsGuestType(
                    GuestTypeID,
                    GuestTypeName);
            }

            return null;
        }

        public static ClsGuestType Find(string GuestTypeName)
        {
            int GuestTypeID = 0;
            Exception ErrorOccurred = null;

            bool Found =
                ClsGuestTypeData.GetGuestTypeInfoByName(
                    GuestTypeName,
                    ref GuestTypeID,
                    ref ErrorOccurred);

            if (ErrorOccurred != null)
            {
                ClsUtil.ClsLogger.LogError(
                    ErrorOccurred.ToString());
            }

            if (Found)
            {
                return new ClsGuestType(
                    GuestTypeID,
                    GuestTypeName);
            }

            return null;
        }

        public static DataTable GetAllGuestTypes()
        {
            Exception ErrorOccurred = null;

            DataTable dt =
                ClsGuestTypeData.GetGuestTypesList(
                    ref ErrorOccurred);

            if (ErrorOccurred != null)
            {
                ClsUtil.ClsLogger.LogError(
                    ErrorOccurred.ToString());
            }

            return dt;
        }

        private bool _AddNewGuestType()
        {
            Exception ErrorOccurred = null;

            int? NewID =
                ClsGuestTypeData.AddNewGuestType(
                    GuestTypeName,
                    ref ErrorOccurred);

            if (ErrorOccurred != null)
            {
                ClsUtil.ClsLogger.LogError(
                    ErrorOccurred.ToString());
            }

            if (NewID.HasValue)
            {
                GuestTypeID = NewID.Value;
                Mode = EnMode.Update;

                return true;
            }

            return false;
        }

        private bool _UpdateGuestTypeName()
        {
            if (!GuestTypeID.HasValue)
                return false;

            Exception ErrorOccurred = null;

            bool Updated =
                ClsGuestTypeData.UpdateGuestTypeName(
                    GuestTypeID.Value,
                    GuestTypeName,
                    ref ErrorOccurred);

            if (ErrorOccurred != null)
            {
                ClsUtil.ClsLogger.LogError(
                    ErrorOccurred.ToString());
            }

            return Updated;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    return _AddNewGuestType();

                case EnMode.Update:
                    return _UpdateGuestTypeName();

                default:
                    return false;
            }
        }
    }
}