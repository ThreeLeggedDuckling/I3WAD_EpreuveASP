using Common.Repositories;
using D = DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using BLL.Mappers;

namespace BLL.Services
{
    public class UserService : IUserRepository<User>
    {
        private IUserRepository<D.User> _userService;
        // service game
        // servie loan

        public UserService(IUserRepository<D.User> userService)
        {
            _userService = userService;
        }

        public Guid CheckPassword(string email, string password)
        {
            return _userService.CheckPassword(email, password);
        }

        public void Delete(Guid user_id)
        {
            _userService.Delete(user_id);
        }

        public User Get(Guid user_id)
        {
            User user = _userService.Get(user_id).ToBLL();
            //user.Games = ...
            //user.LendedGames = ...
            //user.BorrowedGames = ...

            return user;
        }

        public Guid Insert(User user)
        {
            return _userService.Insert(user.ToDAL());
        }

        public void Update(Guid user_id, User user)
        {
            _userService.Update(user_id, user.ToDAL());
        }
    }
}
