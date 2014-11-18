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
    /// Member model for use in the entity framework repository.
    /// Stores information about a person, the member and the loans they hold.
    /// </summary>
    public class Member {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PersonalId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }

        public override string ToString() {
            return String.Format("[{0}] -- {1}", this.Id, this.Name);
        }
    }
}
