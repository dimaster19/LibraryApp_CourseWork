using MaterialSkin;
using MaterialSkin.Controls;
using System;
using LibraryApp.Entities;
using LibraryApp.Services;
using System.Windows.Forms;
using System.Linq;


namespace LibraryApp.View
{
    partial class NewBookForm : MaterialForm
    {
        IBookService _bookService = new BookService();
        public Book Book { get; set; }
        public NewBookForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal300, Primary.Teal500, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            var id = _bookService.GetMaxId();
            Book = new Book
            {
                Id = id + 1,
                Name = nameTextBox.Text,
                Author = authorTextBox.Text,
                Year = yearTextBox.Text,
                Genre =  genreTextBox.Text


            };
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}
