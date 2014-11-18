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
        private Services.AuthorService authorService;

        public BookForm(Services.AuthorService authorService) {

            InitializeComponent();
            this.authorService = authorService;
                
            if (Book == null) {
                Book = new Models.Book();
            }

            UpdateGUI();
        }

        private void UpdateGUI() {
            cmbAuthors.Items.Clear();
            foreach (Models.Author author in authorService.All()) {
                cmbAuthors.Items.Add(author);
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            Book.Isbn = txtIsbn.Text;
            Book.Title = txtTitle.Text;
            Book.Description = txtDescription.Text;
            Book.Author = (Models.Author)cmbAuthors.SelectedItem;
        }

        private void btnNewAuthor_Click(object sender, EventArgs e) {
            AuthorForm form = new AuthorForm();

            if (form.ShowDialog(this) == DialogResult.OK) {
                Models.Author newAuthor = new Models.Author() {
                    Name = form.NameAuthor
                };
                authorService.AddAuthor(newAuthor);
                UpdateGUI();
            }
        }


    }
}
