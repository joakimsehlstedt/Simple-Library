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
    /// AuthorService class for use in the servicelayer of the entity framework.
    /// Handles author data and operations between the repository and the GUI.
    /// </summary>
    public class AuthorService : IService {

        private AuthorRepository _authorRepository;
        private EventArgs myEventArgs;

        public event EventHandler Updated;

        public AuthorService(RepositoryFactory repoFactory) {
            _authorRepository = repoFactory.GetAuthorRepository();
        }

        protected virtual void OnUpdated(EventArgs e) {
            EventHandler handler = Updated;
            handler(this, e);
        }

        public IEnumerable<Author> All() {
            return _authorRepository.All();
        }

        public void AddAuthor(Author author) {
            myEventArgs = new EventArgs();
            _authorRepository.Add(author);
            OnUpdated(myEventArgs);
        }

        public Author GetAuthor(int id) {
            return _authorRepository.Find(id);
        }
    }
}
