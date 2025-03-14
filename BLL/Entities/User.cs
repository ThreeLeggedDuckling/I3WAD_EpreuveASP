using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class User
    {
        private DateTime? _disabledAt;

        public Guid User_Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDisabled {
            get { return _disabledAt is not null; }
        }
        // a changer avvec services
        //public IEnumerable<Copy> OwnedGames { get; set; }
        //public IEnumerable<Loan> LendedGames { get; set; }
        //public IEnumerable<Loan> BorrowedGames { get; set; }

        public User(Guid user_Id)
        {
            User_Id = user_Id;
        }
        public User(string email, string username, string password)
        {
            Email = email;
            Username = username;
            Password = password;
        }
        public User(Guid user_Id, string email, string username, string password, DateTime createdAt, DateTime? disabledAt) : this(email, username, password)
        {
            User_Id = user_Id;
            CreatedAt = createdAt;
            _disabledAt = disabledAt;
        }
    }
}
