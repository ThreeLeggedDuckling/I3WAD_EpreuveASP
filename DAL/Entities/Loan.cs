﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Loan
    {
        public Guid Loan_Id { get; set; }
        public Guid Copy { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Guid Lender { get; set; }
        public byte? LenderScore { get; set; }
        public Guid Borrower { get; set; }
        public byte? BorrowerScore { get; set; }
    }
}
