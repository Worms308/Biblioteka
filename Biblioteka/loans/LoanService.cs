using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public Boolean addLoan(Loan loan)
        {
            context.Loan.Add(loan);
            return true;
        }

        public Boolean returnBook(LoanDTO loanDto)
        {
            Loan loan = context.Loan.Find(loanDto.Id);
            loan.Returned_date = DateTime.Now;
            context.SaveChanges();
            if (loan.Returned_date > loan.Return_date)
                MessageBox.Show("Książka zwrócona po terminie zwrotu!", "Zwrot książki",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            return true;
        }

    }
}
