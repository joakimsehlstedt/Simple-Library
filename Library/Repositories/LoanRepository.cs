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
    /// Definition of the LoanRepository in the repository layer 
    /// for the entity framework. Also includes implementation of 
    /// the CRUD methods from the IRepository interface.
    /// </summary>
    public class LoanRepository : IRepository<Loan, int>{
        LibraryContext _context;

        public LoanRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public void Add(Loan item) {
            _context.Loans.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Loan item) {
            _context.Loans.Remove(item);
            _context.SaveChanges();
        }

        public Loan Find(int id) {
            return _context.Loans.First(b => b.Id == id);
        }

        public void Edit(Loan item) {
            var loan = _context.Loans.First(l => l.Id == item.Id);

            loan.BookCopy = item.BookCopy;
            loan.DueDate = item.DueDate;
            loan.LoanDate = item.LoanDate;
            loan.Member = item.Member;
            loan.ReturnDate = item.ReturnDate;

            _context.SaveChanges();
        }

        public IEnumerable<Loan> All() {
            return _context.Loans.ToList();
        }
    }
}
