using ASP_MVC.Models.Copy;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.User
{
    public class UserDetails
    {
        [ScaffoldColumn(false)]
        public Guid User_Id { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Username")]
        public string Username { get; set; }

        [DisplayName("Registration date")]
        [DataType(DataType.Date)]
        public DateOnly CreatedAt { get; set; }

        //[DisplayName("Owned games")]
        //public IEnumerable<CopyListItem> OwnedGames { get; set; }
    }
}
