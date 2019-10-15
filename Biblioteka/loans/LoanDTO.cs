using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.loans
{
    class LoanDTO
    {
        public int Id { get; set; }
        public System.DateTime Loan_date { get; set; }
        public System.DateTime Return_date { get; set; }
        public Nullable<System.DateTime> Returned_date { get; set; }
        public string User { get; set; }
        public string Book { get; set; }
        public string Admin { get; set; }
    }
}
