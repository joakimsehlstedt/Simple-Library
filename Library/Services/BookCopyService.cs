using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {
    public class BookCopyService : IService {

        private BookCopyRepository _bookCopyRepository;
        private EventArgs myEventArgs;

        public event EventHandler Updated;

        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
        }

        protected virtual void OnUpdated(EventArgs e) {
            EventHandler handler = Updated;
            handler(this, e);
        }

        public IEnumerable<BookCopy> All()
        {
            return _bookCopyRepository.All();
        }

        public void AddBookCopy(BookCopy bookCopy) {
            myEventArgs = new EventArgs();
            _bookCopyRepository.Add(bookCopy);
            OnUpdated(myEventArgs);
        }
    }
}
