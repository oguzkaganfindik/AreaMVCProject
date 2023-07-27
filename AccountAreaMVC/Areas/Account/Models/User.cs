using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountAreaMVC.Areas.Account.Models
{
    public class User
    {
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [DisplayName("Şifre")]
        public string Password { get; set; }
    }
}
