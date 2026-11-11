
using ClsGlobalClasses;
using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsOrder
    {
        public int? OrderID { get; set; }
        public int? OrderTypeID { get; set; }
        public ClsOrderType orderTypeInfo { get; set; }
        public int? UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public short Status { get; set; }


        public enum EnOrderStatus
        {
            Pending = 1,
            Completed = 2,
            Cancelled = 3
        }

        public EnOrderStatus OrderStatus { get; set; }


        public enum EnMode
        {
            AddNew = 0,
            Update = 1
        }

        public EnMode Mode { get; set; }


        public ClsOrder()
        {
            OrderID = null;
            OrderTypeID = null;
            UserID = null;
            OrderDate = DateTime.Now;
            Status = (short)EnOrderStatus.Pending;

            Mode = EnMode.AddNew;
        }

        public static string GetStatusString(int StatusNumber)
        {
            switch (StatusNumber)
            {
                case 1:
                    return "Pending";
                case 2:
                    return "Completed";
                case 3:
                    return "Canceled";
                default:
                    return "Pending";

            }
        }

        public ClsOrder(
            int OrderID,
            int OrderTypeID,
            int UserID,
            DateTime OrderDate,
            short Status)
        {
            this.OrderID = OrderID;
            this.OrderTypeID = OrderTypeID;
            orderTypeInfo = ClsOrderType.Find(OrderTypeID);
            this.UserID = UserID;
            this.OrderDate = OrderDate;
            this.Status = Status;

            Mode = EnMode.Update;
        }


        public static string GetStatusString(EnOrderStatus status)
        {
            switch (status)
            {
                case EnOrderStatus.Pending:
                    return "Pending";

                case EnOrderStatus.Completed:
                    return "Completed";

                case EnOrderStatus.Cancelled:
                    return "Cancelled";

                default:
                    return "Pending";
            }
        }


        public static ClsOrder Find(int OrderID)
        {
            int OrderTypeID = 0;
            int UserID = 0;
            DateTime OrderDate = DateTime.MinValue;
            int Status = 0;

            Exception error = null;

            bool Found =
                ClsOrderData.GetOrderInfoByID(
                    OrderID,
                    ref OrderTypeID,
                    ref UserID,
                    ref OrderDate,
                    ref Status,
                    ref error);

            if (!Found)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        $"Failed to get Order Info with ID = {OrderID}",
                        error);
                }

                return null;
            }

            return new ClsOrder(
                OrderID,
                OrderTypeID,
                UserID,
                OrderDate,
                (short)Status);
        }


        public static DataTable GetAllOrders()
        {
            Exception error = null;

            DataTable dt =
                ClsOrderData.GetOrdersList(ref error);

            if (error != null)
            {
                ClsUtil.ClsLogger.LogError(
                    "Failed to get Orders List",
                    error);

                return null;
            }

            return dt;
        }

        public static DataTable GetOrdersPerPage(short pageNumber, short PageSize)
        {

            Exception error = null;

            DataTable dt =
                ClsOrderData.GetOrdersListPerPage(pageNumber, PageSize, ref error);

            if (error != null)
            {
                ClsUtil.ClsLogger.LogError(
                    "Failed to get Orders List",
                    error);

                return null;
            }

            return dt;
        }

        public bool AddNewOrder()
        {
            Exception error = null;

            int NewOrderID =
                ClsOrderData.AddNewOrder(
                    OrderTypeID.Value,
                    UserID.Value,
                    ref error);

            if (NewOrderID == -1)
            {
                if (error != null)
                {
                    ClsUtil.ClsLogger.LogError(
                        "Failed to Add New Order",
                        error);
                }

                return false;
            }

            OrderID = NewOrderID;

            return true;
        }


        public bool UpdateOrder()
        {
            Exception error = null;

            bool Updated =
                ClsOrderData.UpdateOrder(
                    OrderID.Value,
                    OrderTypeID.Value,
                    Status,
                    UserID.Value,
                    ref error);

            if (error != null)
            {
                ClsUtil.ClsLogger.LogError(
                    $"Failed to Update Order with ID = {OrderID.Value}",
                    error);

                return false;
            }

            return Updated;
        }


        public bool CancelOrder()
        {
            Exception error = null;

            bool Cancelled =
                ClsOrderData.CancelOrder(
                    OrderID.Value,
                    ref error);

            if (error != null)
            {
                ClsUtil.ClsLogger.LogError(
                    $"Failed to Cancel Order with ID = {OrderID.Value}",
                    error);

                return false;
            }

            if (Cancelled)
            {
                Status = (short)EnOrderStatus.Cancelled;
            }

            return Cancelled;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:

                    if (AddNewOrder())
                    {
                        Mode = EnMode.Update;

                        return OrderID != null;
                    }

                    return false;


                case EnMode.Update:

                    return UpdateOrder();


                default:

                    return false;
            }
        }
    }
}
