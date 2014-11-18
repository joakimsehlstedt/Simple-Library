using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);


            // Create some author objects
            Author alex = new Author() {
                Name = "Alexandre Dumas"
            };
            Author tolkien = new Author() {
                Name = "J. R. R. Tolkien"
            };
            context.Authors.Add(alex);
            context.Authors.Add(tolkien);


            // Create some book objects
            Book monteCristo = new Book() {
                Title = "The Count of Monte Cristo",
                Author = alex
            };
            Book lotr = new Book() {
                Title = "The Lord of the Rings",
                Author = tolkien
            };
            context.Books.Add(monteCristo);
            context.Books.Add(lotr);

         
            // Create some bookcopy objects
            BookCopy monteCristo_1 = new BookCopy() {
                Book = monteCristo,
                Available = true
            };
            BookCopy lotr_1 = new BookCopy() {
                Book = lotr,
                Available = false
            };
            context.BookCopies.Add(monteCristo_1);
            context.BookCopies.Add(lotr_1);


            // Create some member objects
            Member lars = new Member() {
                PersonalId = "551014-5656",
                Name = "Lars Larsson"
            };
            Member sven = new Member() {
                PersonalId = "771124-1122",
                Name = "Sven Svensson"
            };
            context.Members.Add(lars);
            context.Members.Add(sven);


            // Create some loans
            Loan loan1 = new Loan() {
                LoanDate = DateTime.Today,
                DueDate = DateTime.Today.AddDays(15),
                Member = lars
            };
            loan1.BookCopy = lotr_1;

            //Loan loan2 = new Loan() {
            //    LoanDate = DateTime.Today.AddDays(-30),
            //    DueDate = DateTime.Today.AddDays(-15),
            //    BookCopy = monteCristo_1,
            //    Member = sven
            //};
            //context.Loans.Add(loan1);
            //context.Loans.Add(loan2);


            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
