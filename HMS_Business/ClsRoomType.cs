using GlobalClasses;
using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsRoomType
    {
        public int? RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }

        public ClsRoomType()
        {
            RoomTypeID = null;
            RoomTypeName = string.Empty;
        }

        public ClsRoomType(
            int RoomTypeID,
            string RoomTypeName)
        {
            this.RoomTypeID = RoomTypeID;
            this.RoomTypeName = RoomTypeName;
        }


        public static ClsRoomType Find(int RoomTypeID)
        {
            string RoomTypeName = string.Empty;
            Exception error = null;

            bool Found =
                ClsRoomTypeData.GetRoomTypeInfoByID(
                    RoomTypeID,
                    ref RoomTypeName,
                    ref error);

            if (!Found)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to get Room Type Info with ID = {RoomTypeID}",
                        error);
                }

                return null;
            }

            return new ClsRoomType(
                RoomTypeID,
                RoomTypeName);
        }


        public static DataTable GetAllRoomTypes()
        {
            Exception error = null;

            DataTable dt =
                ClsRoomTypeData.GetRoomTypesList(
                    ref error);

            if (error != null)
            {
                ClsUtil.ClsLogger.LogError(
                    "Failed to get Room Types List",
                    error);

                return null;
            }

            return dt;
        }


        public bool UpdateRoomType()
        {
            Exception error = null;

            bool Updated =
                ClsRoomTypeData.UpdateRoomType(
                    RoomTypeID.Value,
                    RoomTypeName,
                    ref error);

            if (error != null)
            {
                ClsUtil.ClsLogger.LogError(
                    $"Failed to Update Room Type with ID = {RoomTypeID.Value}",
                    error);

                return false;
            }

            return Updated;
        }
    }
}