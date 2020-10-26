using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    static class UserProcessor
    {
        public static int CreateUser(string firstName, string lastName, string emailAddress, string username)
        {
            UserModel data = new UserModel(firstName, lastName, emailAddress, username);
            string sql = @"insert into dbo.tblUsers (FirstName, LastName, EmailAddress, Username) 
                            values (@firstName, @lastName, @emailAddress, @username);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<UserModel> LoadUsers()
        {
            string sql = @"select Id, FirstName, LastName, EmailAddress, Username 
                            from dbo.tblUsers";
            return SqlDataAccess.LoadData<UserModel>(sql);
        }

        public static UserModel findByUsername(string username)
        {
            string sql = @"select Id, FirstName, LastName, EmailAddress 
                            from dbo.tblUsers
                            where Username= '@username'";
            return SqlDataAccess.GetDataEntry<UserModel>(sql);
        }
    }
}
