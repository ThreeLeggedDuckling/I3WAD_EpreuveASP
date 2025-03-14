using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface ITagRepository<TTag>
    {
        Guid Insert(TTag tag_id);
        IEnumerable<TTag> Get();
        TTag Get(string tag_id);
    }
}
