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
    public partial class BookForm : Form {

        public Models.Book Book { get; private set; }

        public BookForm(IEnumerable<Models.Author> authors) {
            InitializeComponent();

            if (Book == null) {
                Book = new Models.Book();
            }

            cmbAuthors.Items.Clear();
            foreach (Models.Author author in authors) {
                cmbAuthors.Items.Add(author);
            }
        }

        public BookForm(IEnumerable<Models.Author> authors, Models.Book book) : this(authors) {
            Book = book;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            Book.Isbn = txtIsbn.Text;
            Book.Title = txtTitle.Text;
            Book.Description = txtDescription.Text;
            Book.Author = (Models.Author)cmbAuthors.SelectedItem;
        }


    }
}
