using BLL.Entities;
using D = DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    internal static class UserMapper
    {
        public static User ToBLL(this D.User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            return new User(
                user.User_Id,
                user.Email,
                user.Username,
                user.Password,
                user.CreatedAt,
                user.DisabledAt
                );
        }

        public static D.User ToDAL(this User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            return new D.User()
            {
                User_Id = user.User_Id,
                Email = user.Email,
                Username = user.Username,
                Password = user.Password,
                CreatedAt = user.CreatedAt,
                DisabledAt = user.IsDisabled ? new DateTime() : null
            };
        }
    }
}
