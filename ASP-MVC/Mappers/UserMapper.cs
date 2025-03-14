using ASP_MVC.Models.User;
using BLL.Entities;

namespace ASP_MVC.Mappers
{
    internal static class UserMapper
    {
        public static UserDetails ToDetails(this User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            return new UserDetails()
            {
                User_Id = user.User_Id,
                Email = user.Email,
                Username = user.Username,
                CreatedAt = DateOnly.FromDateTime(user.CreatedAt),
                //OwnedGames = user.OwnedGames.Select(bll => bll.ToListItem())
            };
        }

        public static User ToBLL(this UserCreateForm user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            return new User(user.Email, user.Username, user.Password);
        }

    }
}
