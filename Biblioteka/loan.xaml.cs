using Biblioteka.loans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy loan.xaml
    /// </summary>
    public partial class loan : Page
    {
        private LoanService loanService;
        public loan()
        {
            InitializeComponent();
            this.loanService = new LoanService();
            this.loadLoans();
        }

        public void loadLoans()
        {
            List<Loan> loans = loanService.loanLoans();
            List<LoanDTO> loanDTOs = new List<LoanDTO>();
            foreach(Loan it in loans)
            {
                loanDTOs.Add(LoanTransformer.createDto(it));
            }

            loanTable.ItemsSource = loanDTOs;
        }
    }
}
