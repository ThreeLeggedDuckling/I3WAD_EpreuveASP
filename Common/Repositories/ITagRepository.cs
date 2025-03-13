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
        TTag Get(Guid tag_id);
    }
}
