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
    /// Book copy model for use in the entity framework repository.
    /// Used to store information about actual copies of book-titles.
    /// </summary>
    public class BookCopy {
        [Key]
        public int Id { get; set; }
        [Required]
        public Book Book { get; set; }
        [Required]
        public bool Available { get; set; }

        public override string ToString() {
            return String.Format("[{0}] -- {1}", this.Id, this.Book.Title);
        }
    }
}
