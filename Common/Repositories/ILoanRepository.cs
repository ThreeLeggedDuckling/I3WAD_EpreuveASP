using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface ILoanRepository<TLoan>
    {
        Guid Insert(Guid user_id, TLoan loan);
        TLoan Get(Guid loan_id);
        IEnumerable<TLoan> GetByLender(Guid lender_id);
        IEnumerable<TLoan> GetByBorrower(Guid borrower_id);
        void Update(Guid loan_id, TLoan loan);
    }
}
