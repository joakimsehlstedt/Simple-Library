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
    /// Definition of the MemberRepository in the repository layer 
    /// for the entity framework. Also includes implementation of 
    /// the CRUD methods from the IRepository interface.
    /// </summary>
    public class MemberRepository : IRepository<Member, int> {
        LibraryContext _context;

        public MemberRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public void Add(Member item) {
            _context.Members.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Member item) {
            _context.Members.Remove(item);
            _context.SaveChanges();
        }

        public Member Find(int id) {
            return _context.Members.First(b => b.Id == id);
        }

        public void Edit(Member item) {
            var member = _context.Members.First(m => m.Id == item.Id);

            member.Loans = item.Loans;
            member.Name = item.Name;
            member.PersonalId = item.PersonalId;

            _context.SaveChanges();
        }

        public IEnumerable<Member> All() {
            return _context.Members.ToList();
        }
    }
}
