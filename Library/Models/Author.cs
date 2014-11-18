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
    /// Author model for use in the entity framework repository.
    /// </summary>
    public class Author {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public override string ToString() {
            return String.Format("[{0}] -- {1}", this.Id, this.Name);
        }

    }
}
