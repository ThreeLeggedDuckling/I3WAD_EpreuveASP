using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.Auth
{
    public class AuthLoginForm
    {
        [DisplayName("Email : ")]
        [Required(ErrorMessage = "'Email' field is required")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Password : ")]
        [Required(ErrorMessage = "'Password' field is required")]
        [MinLength(8, ErrorMessage = "Invalid password")]
        [MaxLength(32, ErrorMessage = "Invalid password")]
        [RegularExpression(@"^.*(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\-_+=\.()\[\]$µ£\\/*§?@{}!&#%]).*", ErrorMessage = "Invalid password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
