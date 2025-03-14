using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface ICopyRepository<TCopy> : ICRUDRepository<TCopy, Guid>
    {
        IEnumerable<TCopy> GetByGame(Guid game);
    }
}
