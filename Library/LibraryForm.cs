// Library
// Joakim Sehlstedt
// 18 Nov 2014

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

    /// <summary>
    /// Main form for the application. Contains all GUI for the entity framework
    /// based Library application.
    /// </summary>
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
            ListAllBooks();
            ListAllBookCopies();
        }

        private void myMemberService_Changed(object sender, EventArgs e) {
            ListAllMembers();
        }

        private void myLoanService_Changed(object sender, EventArgs e) {
            ListAllLoans();
            ListAllBookCopies();
        }

        private void myAuthorService_Changed(object sender, EventArgs e) {
            ListAllAuthors();
        }

        private void myBookCopyService_Changed(object sender, EventArgs e) {
            ListAllBookCopies();
        }

        private void UpdateGUI() {
            ListAllAuthors();
            ListAllBooks();
            ListAllBookCopies();
            ListAllMembers();
            ListAllLoans();
        }

        private void ListAllAuthors() {
            lbAuthors.Items.Clear();
            foreach (Author author in _authorService.All()) {
                lbAuthors.Items.Add(author);
            }
        }

        private void ListAllBooks() {
            lbBooks.Items.Clear();
            lblBooks.Text = "Books";
            foreach (Book book in _bookService.All()) {
                lbBooks.Items.Add(book);
            }
        }

        private void ListAllBookCopies() {
            lbCopies.Items.Clear();
            foreach (BookCopy bookCopy in _bookCopyService.AllAvailableCopies()) {
                lbCopies.Items.Add(bookCopy);
            }
        }

        private void ListAllMembers() {
            lbMembers.Items.Clear();
            foreach (Member member in _memberService.All()) {
                lbMembers.Items.Add(member);
            }
        }

        private void ListAllLoans() {
            lbLoans.Items.Clear();
            lblLoans.Text = "Loans";
            foreach (Loan loan in _loanService.All()) {
                lbLoans.Items.Add(loan);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e) {
            BookForm bookForm = new BookForm(_authorService);
            bookForm.ShowDialog();

            if (bookForm.DialogResult == DialogResult.OK) {
                _bookService.AddBook(bookForm.Book);
                _bookCopyService.AddBookCopy(new BookCopy() {
                    Book = bookForm.Book,
                    Available = true
                });
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
            int bookCopyId;
            if (lbCopies.SelectedItem is BookCopy) {
                bookCopyId = ((BookCopy)lbCopies.SelectedItem).Id;
            }
            else {
                MessageBox.Show("You must select a book-copy from the copies list!");
                return;
            }

            int memberId;
            if (lbMembers.SelectedItem is Member) {
                memberId = ((Member)lbMembers.SelectedItem).Id;
            }
            else {
                MessageBox.Show("You must select a member from the members list!");
                return;
            }

            _loanService.AddLoan(bookCopyId, memberId, 
                _bookCopyService, _memberService);
        }

        private void btnReturnLoan_Click(object sender, EventArgs e) {
            if (lbLoans.SelectedItem is Loan) {
                int daysOver = _loanService.ReturnLoan(((Loan)lbLoans.SelectedItem).Id);
                if (daysOver > 0) {
                    MessageBox.Show("Your fine is: " + daysOver * 10 + "kr");
                }
            }
            else {
                MessageBox.Show("You must select a loan in the loan list!");
            }
        }
        
        private void btnAddCopy_Click(object sender, EventArgs e) {
            if (lbBooks.SelectedItem is Book) {
                _bookCopyService.AddBookCopy(new BookCopy() {
                    Book = (Book)lbBooks.SelectedItem,
                    Available = true
                });
            }
            else {
                MessageBox.Show("You must select a book from the books list!");
            }
        }

        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbAuthors.SelectedItem != null) {
                lbBooks.Items.Clear();
                lblBooks.Text = "Books by Author";
                foreach (Book book in _bookService.BooksByAuthor((Author)lbAuthors.SelectedItem)) {
                    lbBooks.Items.Add(book);
                }
            }
            else {
                ListAllBooks();
            }
        }
        
        private void lbMembers_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbMembers.SelectedItem != null && lbCopies.SelectedItem == null) {
                lbLoans.Items.Clear();
                lblLoans.Text = "Loans by Member";
                foreach (Loan loan in _loanService.LoansByMember((Member)lbMembers.SelectedItem)) {
                    lbLoans.Items.Add(loan);
                }
            }
            else {
                ListAllLoans();
            }

            if (lbMembers.SelectedItem != null) {
                Member member = (Member)lbMembers.SelectedItem;
                txtDetails.Text = "Name: " + member.Name +
                    "\r\nPersonal Id: " + member.PersonalId;
            }
            else {
                txtDetails.Text = string.Empty;
            }
        }

        private void btnClearSelectionAuthor_Click(object sender, EventArgs e) {
            lbAuthors.ClearSelected();
        }

        private void btnClearSelectionMembers_Click(object sender, EventArgs e) {
            lbMembers.ClearSelected();
        }

        private void btnClearSelectionCopies_Click(object sender, EventArgs e) {
            lbCopies.ClearSelected();
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbBooks.SelectedItem != null) {
                txtDetails.Text = ((Book)lbBooks.SelectedItem).Description;
            }
            else {
                txtDetails.Text = string.Empty;
            }
        }

        private void lbLoans_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbLoans.SelectedItem != null) {
                Loan loan = (Loan)lbLoans.SelectedItem;
                string returnDate = (loan.ReturnDate != null) ? ((DateTime)loan.ReturnDate).ToShortDateString() : "Not returned";
                txtDetails.Text = "Loan date: " + loan.LoanDate.ToShortDateString() +
                    "\r\nDue date: " + loan.DueDate.ToShortDateString() +
                    "\r\nReturned: " + returnDate;
            }
            else {
                txtDetails.Text = string.Empty;
            }
        }
    }
}
