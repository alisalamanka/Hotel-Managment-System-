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
            Mode = EnMode.Update;
        }
        public static Clsuser Find(int userID)
        {
            int personID = 0;
            string username = string.Empty;
            string password = string.Empty;
            bool isActive = false;
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

            return new Clsuser(userID, username, password, personID, isActive == true);
        }

        public static Clsuser Find(string Username, string Password)
        {
            int personID = 0;
            byte isActive = 0;
            int UserID = 0;
            Exception error = null;
            string HashedPassword = ClsUtil.GetHashstring(Password);
            bool UserFounded = ClsUserData.GetUserInfoBynameAndPasssword(Username, Password, ref UserID, ref personID, ref isActive, ref error);

            if (!UserFounded)
            {
            if (error != null)
            {
                ClsUtil.ClsLogger.LogError($"Failed to get User Info  ", error);
                }
                return null;
            }

            return new Clsuser(UserID, Username, HashedPassword, personID, isActive == 1);
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
            string HashedPassword = ClsUtil.GetHashstring(password);
            int? NewUserID = ClsUserData.AddNewUser(Username, HashedPassword, PersonID, isActive, ref exception);
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

        public bool PasswordChanged(string NewPassword,ref bool ErrorOccoured)
        {
            Exception exception = null;
            string HashedPassword = ClsUtil.GetHashstring(NewPassword);
            bool Changed = ClsUserData.PasswordChanged(UserID.Value, HashedPassword, ref exception);
            if (exception != null)
            {
                ClsUtil.ClsLogger.LogError("Failed to Change User Password", exception);
                ErrorOccoured = true;
                return false;
            }
            else
            {
                return Changed;
            }
        }

        public bool UpdateUserInfo()
        {
            Exception exception = null;
            string HashedPassword = ClsUtil.GetHashstring(Password);
            bool Updated = ClsUserData.UpdateUserInfo(PersonInfo.Id.Value, PersonInfo.FirstName, PersonInfo.LastName, PersonInfo.NationalNumber, PersonInfo.DateOfBirth,
                PersonInfo.Phone, PersonInfo.Email, PersonInfo.Gendor, PersonInfo.ImagePath, PersonInfo.CountryID, Username, HashedPassword, isActive,UserID.Value, ref exception);
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
        public static bool UserNameUsed(string UsernName,ref bool ErrorOccured)
        {
            Exception ex= null;
            bool Used = ClsUserData.UserNameUsed(UsernName, ref ex);
            if (ex!=null)
            {
                ErrorOccured = true;
            }
           return Used;

        }

        public static bool PersonHasAUser(int PersonID, ref bool ErrorOccured)
        {
            Exception ex = null;
            bool Used = ClsUserData.PersonUsed(PersonID, ref ex);
            if (ex != null)
            {
                ErrorOccured = true;
                return false;
            }
            return Used;

        }

    }
}
    