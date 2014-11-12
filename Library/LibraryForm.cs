using Library.Models;
using Library.Repositories;
using Library.Services;
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
    public partial class LibraryForm : Form {

        private BookService _bookService;
        private MemberService _memberService;
        private LoanService _loanService;
        private AuthorService _authorService;
        private BookCopyService _bookCopyService;

        public LibraryForm() {
            InitializeComponent();

            RepositoryFactory repoFactory = new RepositoryFactory();

            _bookService = new BookService(repoFactory);
            _memberService = new MemberService(repoFactory);
            _loanService = new LoanService(repoFactory);
            _authorService = new AuthorService(repoFactory);
            _bookCopyService = new BookCopyService(repoFactory);

            _bookService.Updated += myBookService_Changed;
            _memberService.Updated += myMemberService_Changed;
            _loanService.Updated += myLoanService_Changed;
            _authorService.Updated += myAuthorService_Changed;
            _bookCopyService.Updated += myBookCopyService_Changed;

            UpdateGUI();
        }

        private void myBookService_Changed(object sender, EventArgs e) {
            if (!chbAvailableOnly.Checked) {
                ListAllBooks();
            } 
            else {
                ListAllBookCopies();
            }
        }

        private void myMemberService_Changed(object sender, EventArgs e) {
            ListAllMembers();
        }

        private void myLoanService_Changed(object sender, EventArgs e) {
            UpdateGUI();
        }

        private void myAuthorService_Changed(object sender, EventArgs e) {
            ListAllAuthors();
        }

        private void myBookCopyService_Changed(object sender, EventArgs e) {
            if (chbAvailableOnly.Checked) {
                ListAllBookCopies();
            }
            else {
                ListAllBooks();
            }
        }

        private void UpdateGUI() {
            ListAllAuthors();
            ListAllBooks();
            ListAllMembers();
        }

        private void ListAllAuthors() {
            lbAuthors.Items.Clear();
            foreach (Author author in _authorService.All()) {
                lbAuthors.Items.Add(author);
            }
        }

        private void ListAllBooks() {
            lbBooks.Items.Clear();
            foreach (Book book in _bookService.All()) {
                lbBooks.Items.Add(book);
            }
        }

        private void ListAllBookCopies() {
            lbBooks.Items.Clear();
            foreach (BookCopy bookCopy in _bookCopyService.All()) {
                lbBooks.Items.Add(bookCopy);
            }
        }

        private void ListAllMembers() {
            lbMembers.Items.Clear();
            foreach (Member member in _memberService.All()) {
                lbMembers.Items.Add(member);
            }
        }

        private void chbAvailableOnly_CheckedChanged(object sender, EventArgs e) {
            if (chbAvailableOnly.Checked) {
                ListAllBookCopies();
            }
            else {
                ListAllBooks();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e) {
            BookForm bookForm = new BookForm(_authorService.All());
            bookForm.ShowDialog();

            if (bookForm.DialogResult == DialogResult.OK) {
                _bookService.AddBook(bookForm.Book);
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e) {
            MemberForm memberForm = new MemberForm();
            memberForm.ShowDialog();

            if (memberForm.DialogResult == DialogResult.OK) {
                _memberService.AddMember(memberForm.Member);
            }
        }

        private void btnAddLoan_Click(object sender, EventArgs e) {

        }


    }
}
