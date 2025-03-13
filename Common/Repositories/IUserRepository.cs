using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface IUserRepository<TUser>
    {
        Guid Insert(TUser user);
        TUser Get(Guid user_id);
        void Update(Guid user_id, TUser user);
        void Delete(Guid user_id);
        Guid CheckPassword(string email, string password);
    }
}
