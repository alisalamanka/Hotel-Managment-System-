using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GlobalClasses;
using HMS_DataAccess;

namespace HMS_Business
{
    public class Clsuser
    {
        public int? UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int? PersonID { get; set; }

        public bool isActive { get; set; }

        public enum EnMode
        {
            AddNew = 0, Update = 1
        }
        public EnMode Mode { get; set; }
        public ClsPerson PersonInfo { get; set; }

        public Clsuser()
        {
            UserID = null;
            Username = string.Empty;
            Password = string.Empty;
            PersonID = null;
            PersonInfo = new ClsPerson();
        }
        public Clsuser(int? userID, string username, string password, int? personID, bool isActive)
        {
            UserID = userID;
            Username = username;
            Password = password;
            PersonID = personID;
            this.isActive = isActive;
            PersonInfo = ClsPerson.Find(personID.Value);
        }
        public static Clsuser Find(int userID)
        {
            int personID = 0;
            string username = string.Empty;
            string password = string.Empty;
            byte isActive = 0;
            Exception error = null;

           bool Found= ClsUserData.GetUserInfoByID(userID, ref personID, ref username, ref password, ref isActive, ref error);

            if (!Found)
            {
            if (error != null)
            {
                ClsUtil.ClsLogger.LogError($"Failed to get User Info with ID {userID} ", error);
            }
                return null;

            }

            return new Clsuser(userID, username, password, personID, isActive == 1);
        }

        public static Clsuser Find(string Username, string Password)
        {
            int personID = 0;
            byte isActive = 0;
            int UserID = 0;
            Exception error = null;

            bool UserFounded = ClsUserData.GetUserInfoBynameAndPasssword(Username, Password, ref UserID, ref personID, ref isActive, ref error);

            if (!UserFounded)
            {
            if (error != null)
            {
                ClsUtil.ClsLogger.LogError($"Failed to get User Info  ", error);
                }
                return null;
            }

            return new Clsuser(UserID, Username, Password, personID, isActive == 1);
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            Exception exception = null;
            dt = ClsUserData.GetUsersList(ref exception);
            if (exception != null)
            {
                ClsUtil.ClsLogger.LogError("Failed to get UsersList", exception);
                return null;
            }
            return dt;
        }

        public bool AddNewUser(string Username, string password, int PersonID, bool isActive)
        {
            Exception exception = null;
            int? NewUserID = ClsUserData.AddNewUser(Username, password, PersonID, isActive, ref exception);
            if (NewUserID==null)
            {
            if (exception != null)
            {
                ClsUtil.ClsLogger.LogError("Failed to Add New User", exception);
                }
                return false;
            }
            else
            {
                UserID = NewUserID;
                return true;
            }

        }

        public bool UpdateUserInfo()
        {
            Exception exception = null;
        
            bool Updated = ClsUserData.UpdateUserInfo(PersonInfo.Id.Value, PersonInfo.FirstName, PersonInfo.LastName, PersonInfo.NationalNumber, PersonInfo.DateOfBirth,
                PersonInfo.Phone, PersonInfo.Email, PersonInfo.Gendor, PersonInfo.ImagePath, PersonInfo.CountryID, Username, Password, isActive,UserID.Value, ref exception);
            if (exception != null)
            {
                ClsUtil.ClsLogger.LogError("Failed to Update User Info", exception);
                return false;
            }
            else
            {
                return Updated;
            }
        }

        public bool DeleteUserInfo()
        {
            Exception exception = null;
           bool deleted= ClsUserData.DeleteUser(UserID.Value, ref exception);
            if (!deleted)
            {
            if (exception != null)
            {
                ClsUtil.ClsLogger.LogError($"Failed to Delete User with ID = {UserID.Value}", exception);
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    {
                        if (AddNewUser(Username, Password, PersonID.Value, isActive))
                        {
                            Mode = EnMode.Update;
                            return UserID!=null;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case EnMode.Update:
                    {
                        return UpdateUserInfo();

                    }
                default:
                    return false;

            }
        }
    }
}
    