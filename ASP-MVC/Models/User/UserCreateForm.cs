using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.User
{
    public class UserCreateForm
    {
        [DisplayName("Username : ")]
        [Required(ErrorMessage = "'Username' field is required")]
        [MinLength(2, ErrorMessage = "'Username' must contains at least 2 characters")]
        [MaxLength(64, ErrorMessage = "'Username' lengtht can't exceed 64 characters")]
        public string Username { get; set; }

        [DisplayName("Email : ")]
        [Required(ErrorMessage = "'Email' field is required")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Password : ")]
        [Required(ErrorMessage = "'Password' field is required")]
        [MinLength(8, ErrorMessage = "'Password' must contains at least 8 characters")]
        [MaxLength(32, ErrorMessage = "'Password' lengtht can't exceed 32 characters")]
        [RegularExpression(@"^.*(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\-_+=\.()\[\]$µ£\\/*§?@{}!&#%]).*", ErrorMessage = "'Password' field must contains at least 1 of each following characters : lower case, upper case, numeric, special")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Please confirm password : ")]
        [Required(ErrorMessage = "'Password' confirmation field is required")]
        [Compare(nameof(Password), ErrorMessage = "'Password' confirmation doesn't match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [DisplayName("I have read and accepted the Terms and Conditions")]
        public bool Consent { get; set; }
    }
}
