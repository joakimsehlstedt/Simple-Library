using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Loan {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime LoanDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
        [Required]
        public BookCopy BookCopy { get; set; }
        [Required]
        public int MemberId { get; set; }

        public override string ToString() {
            return String.Format("[{0}] -- {1} | {2} | {3} | {4} | {5}",
                this.Id, this.BookCopy, this.MemberId, this.LoanDate,
                this.DueDate, this.ReturnDate);
        }
    }
}
