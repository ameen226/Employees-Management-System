using System.ComponentModel.DataAnnotations;

namespace PL.ViewModels
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "First Name is Required")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Last Name is Required")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Email is Required")]
		[EmailAddress(ErrorMessage = "Invalid Email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is Required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Confirm Passowrd is Required")]
		[Compare("Password", ErrorMessage = "Password Does not Match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

		public bool IsAgree { get; set; }
	}
}
