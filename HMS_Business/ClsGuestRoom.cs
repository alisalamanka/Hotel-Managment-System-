using GlobalClasses;
using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsGuestRoom
    {
        public int? GuestRoomID { get; set; }
        public int? RoomTypeID { get; set; }
        public decimal PricePerNight { get; set; }
        public int RoomNumber { get; set; }
        public short Status { get; set; }


        public enum EnMode
        {
            AddNew = 0,
            Update = 1
        }

        public EnMode Mode { get; set; }


        public ClsGuestRoom()
        {
            GuestRoomID = null;
            RoomTypeID = null;
            PricePerNight = 0;
            RoomNumber = 0;
            Status = 1;

            Mode = EnMode.AddNew;
        }


        public ClsGuestRoom(
            int GuestRoomID,
            int RoomTypeID,
            decimal PricePerNight,
            int RoomNumber,
            short Status)
        {
            this.GuestRoomID = GuestRoomID;
            this.RoomTypeID = RoomTypeID;
            this.PricePerNight = PricePerNight;
            this.RoomNumber = RoomNumber;
            this.Status = Status;

            Mode = EnMode.Update;
        }


        public static ClsGuestRoom Find(int GuestRoomID)
        {
            int RoomTypeID = 0;
            decimal PricePerNight = 0;
            int RoomNumber = 0;
            short Status = 0;

            Exception error = null;

            bool Found =
                ClsGuestRoomData.GetRoomInfoByID(
                    GuestRoomID,
                    ref RoomTypeID,
                    ref PricePerNight,
                    ref RoomNumber,
                    ref Status,
                    ref error);

            if (!Found)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to get Room Info with ID = {GuestRoomID}",
                        error);
                }

                return null;
            }

            return new ClsGuestRoom(
                GuestRoomID,
                RoomTypeID,
                PricePerNight,
                RoomNumber,
                Status);
        }


        public static ClsGuestRoom FindByRoomNumber(int RoomNumber)
        {
            int GuestRoomID = 0;
            int RoomTypeID = 0;
            decimal PricePerNight = 0;
            short Status = 0;

            Exception error = null;

            bool Found =
                ClsGuestRoomData.GetRoomInfoByNumber(
                    RoomNumber,
                    ref GuestRoomID,
                    ref RoomTypeID,
                    ref PricePerNight,
                    ref Status,
                    ref error);

            if (!Found)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to get Room Info with Number = {RoomNumber}",
                        error);
                }

                return null;
            }

            return new ClsGuestRoom(
                GuestRoomID,
                RoomTypeID,
                PricePerNight,
                RoomNumber,
                Status);
        }


        public static DataTable GetAllRooms()
        {
            Exception error = null;

            DataTable dt =
                ClsGuestRoomData.GetRoomsList(ref error);

            if (error != null)
            {
                ClsUtil.ClsLogger.LogError(
                    "Failed to get Rooms List",
                    error);

                return null;
            }

            return dt;
        }


        public static bool RoomExistsByNumber(
            int RoomNumber,
            ref bool ErrorOccurred)
        {
            Exception error = null;

            bool Exists =
                ClsGuestRoomData.RoomExistsByNumber(
                    RoomNumber,
                    ref error);

            if (error != null)
            {
                ErrorOccurred = true;

                ClsUtil.ClsLogger.LogError(
                    $"Failed to check Room with Number = {RoomNumber}",
                    error);
            }

            return Exists;
        }


        public bool AddNewRoom()
        {
            Exception error = null;

            int? NewRoomID =
                ClsGuestRoomData.AddNewRoom(
                    RoomTypeID.Value,
                    PricePerNight,
                    RoomNumber,
                    Status,
                    ref error);

            if (NewRoomID == null)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        "Failed to Add New Room",
                        error);
                }

                return false;
            }

            GuestRoomID = NewRoomID;

            return true;
        }


        public bool UpdateRoom()
        {
            Exception error = null;

            bool Updated =
                ClsGuestRoomData.UpdateRoom(
                    GuestRoomID.Value,
                    RoomTypeID.Value,
                    PricePerNight,
                    RoomNumber,
                    Status,
                    ref error);

            if (error != null)
            {
                ClsUtil.ClsLogger.LogError(
                    $"Failed to Update Room with ID = {GuestRoomID.Value}",
                    error);

                return false;
            }

            return Updated;
        }


        public bool UpdateStatus(short NewStatus)
        {
            Exception error = null;

            bool Updated =
                ClsGuestRoomData.UpdateRoomStatus(
                    GuestRoomID.Value,
                    NewStatus,
                    ref error);

            if (error != null)
            {
                ClsUtil.ClsLogger.LogError(
                    $"Failed to Update Room Status with ID = {GuestRoomID.Value}",
                    error);

                return false;
            }

            if (Updated)
                Status = NewStatus;

            return Updated;
        }



        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:

                    if (AddNewRoom())
                    {
                        Mode = EnMode.Update;

                        return GuestRoomID != null;
                    }

                    return false;


                case EnMode.Update:

                    return UpdateRoom();


                default:

                    return false;
            }
        }
    }
}