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
            // Add the author to the DbSet of authors.
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
            // Add the book to the DbSet of books.
            context.Books.Add(monteCristo);
            context.Books.Add(lotr);

            // Persist changes to the database
            //context.SaveChanges();
         
            // Create some bookcopy objects
            BookCopy monteCristo_1 = new BookCopy() {
                Book = monteCristo
            };
            BookCopy lotr_1 = new BookCopy() {
                Book = lotr
            };
            // Add the book to the DbSet of books.
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
            // Add the author to the DbSet of authors.
            context.Members.Add(lars);
            context.Members.Add(sven);


            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
