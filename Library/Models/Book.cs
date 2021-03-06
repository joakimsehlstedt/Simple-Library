﻿// Library
// Joakim Sehlstedt
// 18 Nov 2014

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {

    /// <summary>
    /// Book model for use in the entity framework repository.
    /// </summary>
    public class Book {
        [Key]
        public int Id { get; set; }
        public string Isbn { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public Author Author { get; set; }
        public virtual ICollection<BookCopy> BookCopies { get; set; }
         
        public override string ToString() {
            return String.Format("[{0}] -- {1}", this.Id, this.Title);
        }
    }
}