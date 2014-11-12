using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {
    public class BookService : IService {

        private BookRepository _bookRepository;
        private EventArgs myEventArgs;

        public event EventHandler Updated;

        public BookService(RepositoryFactory repoFactory) {
            _bookRepository = repoFactory.GetBookRepository();
        }

        protected virtual void OnUpdated(EventArgs e) {
            EventHandler handler = Updated;
            handler(this, e);
        }

        public IEnumerable<Book> All() {
            return _bookRepository.All();
        }

        public void AddBook(Book book) {
            myEventArgs = new EventArgs();
            _bookRepository.Add(book);
            OnUpdated(myEventArgs);
        }
    }
}
