using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_learning_Platform.Models.ViewModels
{
	public class UserRegisterViewModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		[DataType(DataType.Password)]
		[PasswordPropertyText]
		public string Password { get; set; }
        [DataType(DataType.Password)]
        [PasswordPropertyText]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> Roles { get; set; }
    }
}
