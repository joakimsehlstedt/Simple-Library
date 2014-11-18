// Library
// Joakim Sehlstedt
// 18 Nov 2014

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {

    /// <summary>
    /// Loan model for use in the entity framework repository.
    /// Stores information about the loan, the dates and the person.
    /// </summary>
    public class Loan {     
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        [Required]
        public BookCopy BookCopy { get; set; }
        [Required]
        public Member Member { get; set; }
        public int LoanStatus {
            get {
                if (ReturnDate != null) { return 1; }
                else if (DueDate < DateTime.Today) { return 2; }
                else { return 0; }
            }
        }

        public override string ToString() {
            string loanStatusToString = string.Empty;
            switch (this.LoanStatus) {
                case 1:
                    loanStatusToString = "RETURNED ";
                    break;
                case 2:
                    loanStatusToString = "OVERDUE ";
                    break;
            }
            return String.Format("[{0}] {1}-- {2} | {3} ",
                this.Id, loanStatusToString, this.BookCopy.Book.Title, this.Member.Name);
        }
    }
}
