using GlobalClasses;
using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class ClsResevation
    {
       public int? ReservationID { get; set; }
        public int? UserID { get; set; }

        public Clsuser UserInfo;
        public int? GuestID { get; set; }
        public ClsGuest GuestInfo;
        public int? RoomID { get; set; }
        public ClsGuest RoomInfo;
        public int? GuestTypeID { get; set; }
        public ClsGuestType GuestTypeInfo;
        public int NumberOfGuests { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime PlannedCheckin { get; set; }
        public DateTime PlannedCheckOut { get; set; }

        public decimal PricePerNight { get; set; }
        public decimal TotalAmount { get; set; }
        public int? Status { get; set; }
        public string Notes { get; set; }
        public enum EnMode
        {
            AddNew=0,Update=1
        }
        public EnMode Mode { get; set; }

        public enum EnStatus
        {
            Pending=1,Confirmed=2,
            Cancelled=3,CheckedIn=4,
            CheckedOut=5, NoShow = 6
        }

        public ClsResevation()
        {
            ReservationID = null;
            UserID = null;
            GuestID = null;
            RoomID = null;
            GuestTypeID = null;
            NumberOfGuests = 0;
            ReservationDate = DateTime.Now;
            PlannedCheckin = DateTime.Now;
            PlannedCheckOut = DateTime.Now;

            PricePerNight = 0;
            TotalAmount = 0;
            Status = null;
            Notes = string.Empty;

            Mode = EnMode.AddNew;
        }

        public ClsResevation(
            int ReservationID,
            int UserID,
            int GuestID,
            int RoomID,
            int GuestTypeID,
            int NumberOfGuests,
            DateTime ReservationDate,
            DateTime PlannedCheckin,
            DateTime PlannedCheckOut,

            decimal PricePerNight,
            decimal TotalAmount,
            int Status,
            string Notes)
        {
            this.ReservationID = ReservationID;
            this.UserID = UserID;
            this.GuestID = GuestID;
            this.RoomID = RoomID;
            this.GuestTypeID = GuestTypeID;
            this.NumberOfGuests = NumberOfGuests;
            this.ReservationDate = ReservationDate;
            this.PlannedCheckin = PlannedCheckin;
            this.PlannedCheckOut = PlannedCheckOut;

            this.PricePerNight = PricePerNight;
            this.TotalAmount = TotalAmount;
            this.Status = Status;
            this.Notes = Notes;

        }

        public  string GetStatusString()
        {
            switch(Status)
            {
                case (int)EnStatus.Pending:
                    return "Pending";
                case (int)EnStatus.Confirmed:
                    return "Confirmed";
                case (int)EnStatus.Cancelled:
                    return "Cancelled";
                case (int)EnStatus.CheckedIn:
                    return "Checked In";
                case (int)EnStatus.CheckedOut:
                    return "Checked Out";
                case (int)EnStatus.NoShow:
                    return "No Show";
                default:
                    return "Pending";
            }
        }
        public int? AddNewReseration()
        {
            Exception e = null;
            int?ID = ClsReservationData.AddNewReservation(UserID.Value,GuestID.Value,RoomID.Value,GuestTypeID.Value,NumberOfGuests,PlannedCheckin,
               PlannedCheckOut,ReservationDate,PricePerNight,TotalAmount,Status.Value,Notes,ref e);
              if (e != null)
            {
                ClsUtil.ClsLogger.LogError("Falied To Add This Reservation",e);
                return null;
            }
           
           
           return ID;
        }

        public bool UpdateReservation()
        {
            Exception e = null;
            bool Updated = ClsReservationData.UpdateReservation(ReservationID.Value,UserID.Value,GuestID.Value, RoomID.Value, GuestTypeID.Value, NumberOfGuests, PlannedCheckin,
               PlannedCheckOut,PricePerNight, TotalAmount, Status.Value, Notes, ref e);
            if (e != null)
            {
                ClsUtil.ClsLogger.LogError("Falied To Update This Reservation",e);
                return false;
            }
            return Updated;
        }

        public static DataTable ReservationList()
        {
            Exception e = null;
            DataTable dt = new DataTable();
            dt = ClsReservationData.GetReservationsList(ref e);
            if (e!=null)
            {
                ClsUtil.ClsLogger.LogError("Failed To get ReservationsList", e);
                return null;
            }
            return dt;
        }

        public static ClsResevation Find(int reservationID)
        {
            int UserID=-1, GuestID=-1, RoomID=-1,numberOfGuests=-1, GuestTypeID=-1, Status=-1;
            string Notes="";
            decimal PricePerNight=0, TotalAmount=0;
            Exception e = null;
            DateTime ReservationDate=DateTime.Now, PlannedCheckin=DateTime.Now, PlannedCheckOut = DateTime.Now;
            bool Found=ClsReservationData.GetReservationInfoByID(reservationID,ref UserID, ref GuestID,
                ref RoomID, ref GuestTypeID,ref numberOfGuests, 
                 ref ReservationDate, ref PlannedCheckin, ref PlannedCheckOut, ref PricePerNight, ref TotalAmount, ref Status, ref Notes,ref e );
            if (e!=null)
            {
                ClsUtil.ClsLogger.LogError("An Error Occoured", e);
                return null;
            }
            else if(Found)
            {
                return new ClsResevation(reservationID, UserID, GuestID, RoomID, GuestTypeID, numberOfGuests, ReservationDate, PlannedCheckin, PlannedCheckOut, PricePerNight, TotalAmount, Status, Notes);
            }
            return null;
        }

        public bool Cancel()
        {
            Exception e = null;
            bool Canceled = false;
            Canceled = ClsReservationData.CancelResrvation(ReservationID.Value,RoomID.Value, ref e);
            if (e!=null)
            {
                ClsUtil.ClsLogger.LogError("Failed To Cancel This Reservation!",e);
                return false;
            }
            else if(Canceled) 
            {
                return true;
            }
            return false;
        }

        public bool Save()
        {
            switch(Mode)
            {
                case EnMode.AddNew:
                {
                    bool added= AddNewReseration()!=null;
                        if (added)
                        {
                            Mode = EnMode.Update;
                            return true;
                        }
                        return false;

                    }

                case EnMode.Update:
                    {
                        return UpdateReservation();
                    }
                default:
                    {
                        return false;
                    }
            }
          
        }



    }
}
