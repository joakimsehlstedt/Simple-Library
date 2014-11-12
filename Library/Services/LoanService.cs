using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {
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

        public void AddLoan(Loan loan) {
            myEventArgs = new EventArgs();
            _loanRepository.Add(loan);
            OnUpdated(myEventArgs);
        }
    }
}
