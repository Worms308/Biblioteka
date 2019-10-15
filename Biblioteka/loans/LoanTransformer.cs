using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.loans
{
    static class LoanTransformer
    {
        public static LoanDTO createDto(Loan loan)
        {
            LoanDTO dto = new LoanDTO();
            dto.Id = loan.Id;
            dto.Loan_date = loan.Loan_date;
            dto.Return_date = loan.Return_date;
            dto.Returned_date = loan.Returned_date;
            dto.User = loan.User.Name + " " + loan.User.Surname;
            dto.Book = loan.Book.Id + " " + loan.Book.Title;
            dto.Admin = loan.Admin.Name + " " + loan.Admin.Surname;

            return dto;
        }
    }
}
