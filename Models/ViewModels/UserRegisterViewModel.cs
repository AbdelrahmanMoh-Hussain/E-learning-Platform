using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_learning_Platform.Models.ViewModels
{
	public class UserRegisterViewModel
	{
        public string UserName { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		[PasswordPropertyText]
		public string Password { get; set; }
		[PasswordPropertyText]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }
		public IEnumerable<SelectListItem> Roles { get; set; }
    }
}
