using AccountAreaMVC.Areas.Account.Data.Interface;
using AccountAreaMVC.Areas.Account.Models;

namespace AccountAreaMVC.Areas.Account.Data.Concrete
{
    public class UserService : IUserService
    {
        public string LogIn(User user)
        {
            User user1 = new User { Email = "test1@test.com", UserName = "test1", Password = "1234" };
            User user2 = new User { Email = "test2@test.com", UserName = "test2", Password = "1234" };
            User user3 = new User { Email = "test3@test.com", UserName = "test3", Password = "1234" };
            User user4 = new User { Email = "test4@test.com", UserName = "test4", Password = "1234" };
            User user5 = new User { Email = "test5@test.com", UserName = "test5", Password = "1234" };

            List<User> users = new List<User> { user1, user2, user3, user4, user5 };

            foreach (var item in users)
            {
                if (user.UserName == item.UserName && user.Password == item.Password)
                {
                    return $"{user.UserName} hoşgeldiniz!!";
                }
            }
            return $"Kullanıcı bulunamadı!!";

        }

        public string LogOut()
        {
            return $"Çıkış yaptı!!";
        }

        public string Register(User user)
        {
            return "Kayıt Yapıldı!!";
        }
    }
}
