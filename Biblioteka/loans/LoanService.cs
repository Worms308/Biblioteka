using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.loans
{
    class LoanService
    {

        private LibraryEntities context;

        public LoanService()
        {
            context = new LibraryEntities();
        }

        public List<Loan> loanLoans()
        {
            return context.Loan.ToList();
        }

    }
}
