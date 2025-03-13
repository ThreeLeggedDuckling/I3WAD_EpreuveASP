using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    interface ICopyRepository<TCopy>
    {
        Guid Insert(TCopy copy);
        TCopy Get(Guid copy_id);
        void Update(Guid copy_id, TCopy copy);
        void Delete(Guid copy_id);
    }
}
