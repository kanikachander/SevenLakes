using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenLakesService
{
    public interface IUserService
    {
        string Login(User user);
        string ResetPassword(User user);
    }
}
