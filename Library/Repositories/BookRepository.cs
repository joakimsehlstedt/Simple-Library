// Library
// Joakim Sehlstedt
// 18 Nov 2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories {

    /// <summary>
    /// Definition of the BookRepository in the repository layer 
    /// for the entity framework. Also includes implementation of 
    /// the CRUD methods from the IRepository interface.
    /// </summary>
    public class BookRepository : IRepository<Book, int> {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public IEnumerable<Book> All() {
            return _context.Books.ToList();
        }

        public void Add(Book item) {
            _context.Books.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Book item) {
            _context.Books.Remove(item);
            _context.SaveChanges();
        }

        public Book Find(int id) {
            return _context.Books.First(b => b.Id == id);
        }

        public void Edit(Book item) {
            var book = _context.Books.First(b => b.Id == item.Id);

            book.Isbn = item.Isbn;
            book.Title = item.Title;
            book.Description = item.Description;
            book.Author = item.Author;
            book.BookCopies = item.BookCopies;

            _context.SaveChanges();
        }
    }
}