using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories {
    public class AuthorRepository : IRepository<Author, int> {
        LibraryContext _context;

        public AuthorRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public void Add(Author item) {
            _context.Authors.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Author item) {
            _context.Authors.Remove(item);
            _context.SaveChanges();
        }

        public Author Find(int id) {
            return _context.Authors.First(b => b.Id == id);
        }

        public void Edit(Author item) {
            var author = _context.Authors.First(a => a.Id == item.Id);

            author.Name = item.Name;
            author.Books = item.Books;

            _context.SaveChanges();
        }

        public IEnumerable<Author> All() {
            return _context.Authors.ToList();
        }
    }
}
