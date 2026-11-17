using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsInvoice
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public enum enInvoiceStatus
        {
            Unpaid = 1,
            PartiallyPaid = 2,
            Paid = 3,
            Canceled = 4
        }

        public int InvoiceID { get; set; }
        public int StayID { get; set; }
        public int UserID { get; set; }
        public enInvoiceStatus Status { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public ClsStay StayInfo { get; set; }

        public ClsInvoice()
        {
            this.InvoiceID = -1;
            this.StayID = -1;
            this.UserID = -1;
            this.Status = enInvoiceStatus.Unpaid;
            this.IssueDate = DateTime.Now;
            this.TotalAmount = 0m;
            this.RemainingAmount = 0m;

            Mode = enMode.AddNew;
        }

        private ClsInvoice(int invoiceID, int stayID, int userID, enInvoiceStatus status,
            DateTime issueDate, decimal totalAmount, decimal remainingAmount)
        {
            this.InvoiceID = invoiceID;
            this.StayID = stayID;
            this.UserID = userID;
            this.Status = status;
            this.IssueDate = issueDate;
            this.TotalAmount = totalAmount;
            this.RemainingAmount = remainingAmount;

            // جلب معلومات الإقامة أوتوماتيكياً إيلا بغيتي تعرضها في واجهة الفاتورة
            this.StayInfo = ClsStay.Find(stayID);

            Mode = enMode.Update;
        }

        private bool _AddNewInvoice()
        {
            this.InvoiceID = ClsInvoiceData.AddNewInvoice(
                this.StayID,
                this.UserID,
                (short)this.Status,
                this.IssueDate,
                this.TotalAmount,
                this.RemainingAmount
            );

            return (this.InvoiceID != -1);
        }

        private bool _UpdateInvoice()
        {
            return ClsInvoiceData.UpdateInvoice(
                this.InvoiceID,
                this.StayID,
                this.UserID,
                (short)this.Status,
                this.IssueDate,
                this.TotalAmount,
                this.RemainingAmount
            );
        }

        public static ClsInvoice Find(int invoiceID)
        {
            int stayID = -1;
            int userID = -1;
            short status = 1;
            DateTime issueDate = DateTime.Now;
            decimal totalAmount = 0m;
            decimal remainingAmount = 0m;

            bool isFound = ClsInvoiceData.GetInvoiceInfoByID(
                invoiceID,
                ref stayID,
                ref userID,
                ref status,
                ref issueDate,
                ref totalAmount,
                ref remainingAmount
            );

            if (isFound)
            {
                return new ClsInvoice(
                    invoiceID,
                    stayID,
                    userID,
                    (enInvoiceStatus)status,
                    issueDate,
                    totalAmount,
                    remainingAmount
                );
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInvoice())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateInvoice();
            }

            return false;
        }

        public static bool DeleteInvoice(int invoiceID)
        {
            return ClsInvoiceData.DeleteInvoice(invoiceID);
        }

        public static bool IsInvoiceExist(int invoiceID)
        {
            return ClsInvoiceData.IsInvoiceExist(invoiceID);
        }

        public static DataTable GetAllInvoices()
        {
            return ClsInvoiceData.GetAllInvoices();
        }

        public static string GetStatusString(enInvoiceStatus status)
        {
            switch (status)
            {
                case enInvoiceStatus.Unpaid:
                    return "Unpaid";
                case enInvoiceStatus.PartiallyPaid:
                    return "Partially Paid";
                case enInvoiceStatus.Paid:
                    return "Paid";
                case enInvoiceStatus.Canceled:
                    return "Canceled";
                default:
                    return "Unknown";
            }
        }
    }
}