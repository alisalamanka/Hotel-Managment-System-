using ClsGlobalClasses;
using HMS_DataAccess;
using System;
using System.Data;

namespace HMS_Business
{
    public class ClsOrderType
    {
        public int? OrderTypeID { get; set; }
        public string OrderTypeName { get; set; }
        public ClsOrderType(int ID, string orderTypeName)
        {
            OrderTypeID = ID;
            OrderTypeName = orderTypeName;
        }
        public ClsOrderType()
        {
            OrderTypeID = null;
            OrderTypeName = "";
        }

        public static ClsOrderType Find(int ID)
        {
            Exception e = null;
            string OrderTypeName = "";
            bool Found = ClsOrderTypeData.GetOrderTypeInfoByID(ID, ref OrderTypeName, ref e);
            if (!Found)
            {
                if (e != null)
                {
                    ClsUtil.ClsLogger.LogError($"Failed to get Order Type Info with ID = {ID}");
                }

                return null;

            }

            return new ClsOrderType(ID, OrderTypeName);
        }

        public static DataTable OrderTypesList()
        {
            Exception e = null;
            DataTable dt = ClsOrderTypeData.GetOrderTypesList(ref e);
            if (dt == null)
            {
                if (e != null)
                {
                    ClsUtil.ClsLogger.LogError("Failed To Get order Types list");
                }
                return null;
            }
            return dt;
        }
    }
}
