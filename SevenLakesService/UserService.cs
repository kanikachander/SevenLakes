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
            new User(){ UserId = 1, Usr = "xyz", Pwd = "abc"},
            new User(){ UserId = 2, Usr = "xyz1", Pwd = "abc1"}
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
    }
}
