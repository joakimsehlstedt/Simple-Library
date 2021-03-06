﻿// Library
// Joakim Sehlstedt
// 18 Nov 2014

using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {

    /// <summary>
    /// MemberService class for use in the servicelayer of the entity framework.
    /// Handles member data and operations between the repository and the GUI.
    /// </summary>
    public class MemberService : IService {

        private MemberRepository _memberRepository;
        private EventArgs myEventArgs;

        public event EventHandler Updated;

        public MemberService(RepositoryFactory repoFactory) {
            _memberRepository = repoFactory.GetMemberRepository();
        }

        protected virtual void OnUpdated(EventArgs e) {
            EventHandler handler = Updated;
            handler(this, e);
        }

        public IEnumerable<Member> All() {
            return _memberRepository.All();
        }

        public void AddMember(Member member) {
            myEventArgs = new EventArgs();
            _memberRepository.Add(member);
            OnUpdated(myEventArgs);
        }

        public Member GetMember(int id) {
            return _memberRepository.Find(id);
        }

    }
}
