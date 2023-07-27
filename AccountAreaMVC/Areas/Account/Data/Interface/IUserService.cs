using AccountAreaMVC.Areas.Account.Models;

namespace AccountAreaMVC.Areas.Account.Data.Interface
{
    public interface IUserService
    {
        string LogIn(User user);

        string LogOut();

        string Register(User user);
    }
}
