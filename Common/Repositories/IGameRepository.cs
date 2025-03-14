using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface IGameRepository<TGame>
    {
        Guid Insert(TGame game);
        IEnumerable<TGame> Get();
        TGame Get(Guid game_id);
        IEnumerable<TGame> GetByName(string name);
        IEnumerable<TGame> GetByTag(string tag_id);
        IEnumerable<TGame> GetNPopular(int nb_results = 10);
        string AddTag(Guid game, string tag);
    }
}
