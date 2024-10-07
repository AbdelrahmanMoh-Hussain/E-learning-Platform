using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_learning_Platform.Models.ViewModels
{
    public class UserLoginViewModel
    {
        [EmailAddress]
        [UIHint("Email Address")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [PasswordPropertyText]
        [UIHint("Password")]
        public string Password { get; set; }
    }
}
