﻿// Library
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
    /// BookCopyService class for use in the servicelayer of the entity framework.
    /// Handles book-copy data and operations between the repository and the GUI.
    /// </summary>
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

        public IEnumerable<BookCopy> AllAvailableCopies() {
            return _bookCopyRepository.All()
                .Where(bc => bc.Available == true);
        }

        public void AddBookCopy(BookCopy bookCopy) {
            myEventArgs = new EventArgs();
            _bookCopyRepository.Add(bookCopy);
            OnUpdated(myEventArgs);
        }

        public BookCopy GetBookCopy(int id) {
            return _bookCopyRepository.Find(id);
        }
    }
}
