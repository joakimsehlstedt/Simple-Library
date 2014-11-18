// Library
// Joakim Sehlstedt
// 18 Nov 2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library {

    /// <summary>
    /// Form for user data-input of a new member.
    /// </summary>
    public partial class MemberForm : Form {

        public Models.Member Member { get; private set; }

        public MemberForm() {
            InitializeComponent();
            if (Member == null) {
                Member = new Models.Member();
            }
        }

        public MemberForm(Models.Member member) : this() {
            Member = member;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            Member.Name = txtName.Text;
            Member.PersonalId = txtPersId.Text;
        }
    }
}
