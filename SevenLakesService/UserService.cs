using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenLakesService
{
    public class UserService: IUserService
    {
        private List<User> UserList = new List<User>() {
            new User(){ UserId = 1, Usr = "xyz", Pwd = "abc", Name = "Robert"},
            new User(){ UserId = 2, Usr = "xyz1", Pwd = "abc1", Name = "Michael"}
        };

        public string Login(User user)
        {
            var userRecord = UserList.Where(i => i.Usr == user.Usr).FirstOrDefault();
            if (userRecord == null)
                return AppConstant.UserNotFound;
            if (userRecord.Pwd == user.Pwd)
                return AppConstant.LoginSuccessful;
            else return AppConstant.LoginUnsuccessful;
        }

        public string ResetPassword(User user)
        {
            var userRecord = UserList.Where(i => i.Usr == user.Usr).FirstOrDefault();
            if (userRecord == null)
                return AppConstant.UserNotFound;
            UserList.Where(i => i.Usr == user.Usr).FirstOrDefault().Pwd = user.Pwd;
            return AppConstant.PasswordChangedSuccessfully;
        }

        public User GetUser(string username)
        {
            return UserList.Where(i => i.Usr == username).FirstOrDefault();
        }
    }
}
