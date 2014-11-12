using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories {
    public class BookCopyRepository : IRepository<BookCopy, int> {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public void Add(BookCopy item) {
            _context.BookCopies.Add(item);
            _context.SaveChanges();
        }

        public void Remove(BookCopy item) {
            _context.BookCopies.Remove(item);
            _context.SaveChanges();
        }

        public BookCopy Find(int id) {
            return _context.BookCopies.First(b => b.Id == id);
        }

        public void Edit(BookCopy item) {
            var bookCopy = _context.BookCopies.First(bc => bc.Id == item.Id);

            bookCopy.Book = item.Book;

            _context.SaveChanges();
        }

        public IEnumerable<BookCopy> All() {
            return _context.BookCopies.ToList();
        }
    }
}
