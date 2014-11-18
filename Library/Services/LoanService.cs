// Library
// Joakim Sehlstedt
// 18 Nov 2014

using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {

    /// <summary>
    /// LoanService class for use in the servicelayer of the entity framework.
    /// Handles loan data and operations between the repository and the GUI.
    /// </summary>
    public class LoanService : IService {

        private LoanRepository _loanRepository;
        private EventArgs myEventArgs;

        public event EventHandler Updated;

        public LoanService(RepositoryFactory repoFactory) {
            _loanRepository = repoFactory.GetLoanRepository();
        }

        protected virtual void OnUpdated(EventArgs e) {
            EventHandler handler = Updated;
            handler(this, e);
        }

        public IEnumerable<Loan> All() {
            return _loanRepository.All();
        }

        public IEnumerable<Loan> NotReturnedLoans() {
            return _loanRepository.All()
                .Where(l => l.ReturnDate == null);
        }

        public IEnumerable<Loan> LoansByMember(Member member) {
            return _loanRepository.All()
                .Where(l => l.Member == member);
        }

        public void AddLoan(int bookCopyId, int memberId, 
            BookCopyService bookCopyService, MemberService memberService) {

            Loan loan = new Loan();

            loan.BookCopy = bookCopyService.GetBookCopy(bookCopyId);
            loan.BookCopy.Available = false;
            loan.Member = memberService.GetMember(memberId);
            loan.LoanDate = DateTime.Today;
            loan.DueDate = DateTime.Today.AddDays(15);

            _loanRepository.Add(loan);
            myEventArgs = new EventArgs();
            OnUpdated(myEventArgs);
        }

        public int ReturnLoan(int loanId) {
            Loan loan = _loanRepository.Find(loanId);
            loan.ReturnDate = DateTime.Today;
            loan.BookCopy.Available = true;

            _loanRepository.Edit(loan);
            myEventArgs = new EventArgs();
            OnUpdated(myEventArgs);

            if (loan.ReturnDate > loan.DueDate) {          
                return loan.ReturnDate.Value.Subtract(loan.DueDate).Days;
            }
            else {
                return 0;
            }
        }
    }
}
