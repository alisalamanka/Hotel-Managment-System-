using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsStay
    {
        public int? StayID { get; set; }

        public int? GuestID { get; set; }

        public ClsGuest GuestInfo { set; get; }

        public int? RoomID { get; set; }

        public ClsRoom RoomInfo { get; set; }

        public int? ReservationID { get; set; }

        public ClsResevation ReservationInfo { get; set; }

        public int? UserID { get; set; }

        public Clsuser UserInfo { set; get; }

        public DateTime ActualCheckIn { get; set; }

        public DateTime? ActualCheckOut { get; set; }

        public short Status { get; set; }

        public string Notes { get; set; }


        public enum EnStayStatus
        {
            Active = 1,
            Completed = 2,
            Cancelled = 3
        }

        public EnStayStatus StayStatus { get; set; }


        public enum EnMode
        {
            AddNew = 0,
            Update = 1
        }

        public EnMode Mode { get; set; }


        public ClsStay()
        {
            StayID = null;
            GuestID = null;
            RoomID = null;
            ReservationID = null;
            UserID = null;

            ActualCheckIn = DateTime.Now;
            ActualCheckOut = null;

            Status = (short)EnStayStatus.Active;

            Notes = string.Empty;

            Mode = EnMode.AddNew;
        }


        public static string GetStatusString(int StatusNumber)
        {
            switch (StatusNumber)
            {
                case 1:
                    return "Active";

                case 2:
                    return "Completed";

                case 3:
                    return "Cancelled";

                default:
                    return "Unknown";
            }
        }


        public static string GetStatusString(EnStayStatus status)
        {
            switch (status)
            {
                case EnStayStatus.Active:
                    return "Active";

                case EnStayStatus.Completed:
                    return "Completed";

                case EnStayStatus.Cancelled:
                    return "Cancelled";

                default:
                    return "Unknown";
            }
        }


        public ClsStay(
            int StayID,
            int GuestID,
            int RoomID,
            int ReservationID,
            int UserID,
            DateTime ActualCheckIn,
            DateTime? ActualCheckOut,
            short Status,
            string Notes)
        {
            this.StayID = StayID;

            this.GuestID = GuestID;

            this.RoomID = RoomID;
            RoomInfo = ClsRoom.Find(RoomID);

            this.ReservationID = ReservationID;
            ReservationInfo = ClsResevation.Find(ReservationID);

            this.UserID = UserID;

            this.ActualCheckIn = ActualCheckIn;
            this.ActualCheckOut = ActualCheckOut;

            this.Status = Status;
            this.StayStatus = (EnStayStatus)Status;

            this.Notes = Notes;

            Mode = EnMode.Update;
        }


        public static ClsStay Find(int StayID)
        {
            int GuestID = 0;
            int RoomID = 0;
            int ReservationID = 0;
            int UserID = 0;

            DateTime ActualCheckIn = DateTime.MinValue;
            DateTime ActualCheckOut = DateTime.MinValue;

            string Status = string.Empty;
            string Notes = string.Empty;

            bool Found =
                ClsStayData.GetStayInfoByID(
                    StayID,
                    ref GuestID,
                    ref RoomID,
                    ref ReservationID,
                    ref UserID,
                    ref ActualCheckIn,
                    ref ActualCheckOut,
                    ref Status,
                    ref Notes);

            if (!Found)
                return null;

            short StatusNumber = 0;

            switch (Status)
            {
                case "Active":
                    StatusNumber = (short)EnStayStatus.Active;
                    break;

                case "Completed":
                    StatusNumber = (short)EnStayStatus.Completed;
                    break;

                case "Cancelled":
                    StatusNumber = (short)EnStayStatus.Cancelled;
                    break;
            }

            return new ClsStay(
                StayID,
                GuestID,
                RoomID,
                ReservationID,
                UserID,
                ActualCheckIn,
                ActualCheckOut,
                StatusNumber,
                Notes);
        }


        public static DataTable GetAllStays()
        {
            DataTable dt = ClsStayData.GetAllStays();

            return dt;
        }


        public bool AddNewStay()
        {
            int? NewStayID =
                ClsStayData.AddNewStay(
                    GuestID.Value,
                    RoomID.Value,
                    ReservationID.Value,
                    UserID.Value,
                    ActualCheckIn,
                    ActualCheckOut,
                    Status,
                    Notes);

            if (NewStayID == null)
                return false;

            StayID = NewStayID;

            return true;
        }


        public bool UpdateStay()
        {
            return ClsStayData.UpdateStay(
                StayID.Value,
                GuestID.Value,
                RoomID.Value,
                ReservationID.Value,
                UserID.Value,
                ActualCheckIn,
                ActualCheckOut,
                Status,
                Notes);
        }


        public bool DeleteStay()
        {
            bool Deleted = ClsStayData.DeleteStay(StayID.Value);

            if (Deleted)
            {
                Status = (short)EnStayStatus.Cancelled;
                StayStatus = EnStayStatus.Cancelled;
            }

            return Deleted;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:

                    if (AddNewStay())
                    {
                        Mode = EnMode.Update;

                        return StayID != null;
                    }

                    return false;


                case EnMode.Update:

                    return UpdateStay();


                default:

                    return false;
            }
        }
    }
}
