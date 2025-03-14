using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Common.Repositories
{
    public interface ICRUDRepository<TEntity, TId>
    {
        TId Insert(TEntity copy);
        TEntity Get(TId copy_id);
        void Update(TId copy_id, TEntity copy);
        void Delete(TId copy_id);
    }
}
