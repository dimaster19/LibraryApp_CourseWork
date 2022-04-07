using LibraryApp.Entities;
using LibraryApp.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using Serilog;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.View
{
    public partial class BookForm : MaterialForm
    {
        private readonly IBookService _bookService = new BookService();
        private ListViewItemComparer lvwItemComparer;

        public BookForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal300, Primary.Teal500, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            lvwItemComparer = new ListViewItemComparer();
            this.bookListView.ListViewItemSorter = lvwItemComparer;
            FillBookList();
        }


        private void FillBookList()
        {
            bookListView.Items.Clear();

            var books = _bookService.GetBooks();

            foreach (var book in books)
            {
                var lvi = new ListViewItem(new[]
                {
                   book.Id.ToString(),book.Author,
                   book.Name,  book.Year,
                   book.Genre,
                 
                  

                });

                bookListView.Items.Add(lvi);
            }
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            

            var newBookForm = new NewBookForm();

            if (newBookForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var newBook = newBookForm.Book;
            _bookService.AddBook(newBook);
            FillBookList();
            Log.Information($"Пользователь {Status.User} добавил запись {newBook.Id}.");

        }

        private void BookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void removeButton2_Click(object sender, EventArgs e)
        {

            if (bookListView.SelectedIndices.Count > 0)
            {

                var idx = int.Parse(bookListView.SelectedItems[0].SubItems[0].Text);
                if (MessageBox.Show($"Вы действительно хотите удалить эту запись: {idx}.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _bookService.RemoveBook(idx);
                    FillBookList();
                    Log.Information($"Пользователь {Status.User} удалил запись {idx}.");
                }

            }
            else { MessageBox.Show("Выберте запись которую хотите удалить."); }
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            if (bookListView.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(bookListView.SelectedItems[0].SubItems[0].Text);
                var Name = bookListView.SelectedItems[0].SubItems[2].Text;
                if (MessageBox.Show($"Вы действительно хотите отредактировать эту запись: {idx} - {Name}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Status.Update = true;
                    Status.ID = idx;
                    NewBookForm edit = new NewBookForm
                    {
                        Text = "Изменить книгу"
                    };
                    if (edit.ShowDialog() != DialogResult.OK)
                    {
                        Status.Update = false;
                        return;
                    }
                    var newBook = edit.Book;
                    newBook.Id = idx;
                    _bookService.UpdateBook(newBook, idx);
                    FillBookList();
                    string info = null;
                    Status.Update = false;
                    Log.Information($"Пользователь {Status.User} отредактировал запись {idx}.{Name} {info}.");
                }
            }
            else
            {
                MessageBox.Show("Выберте одну запись которую хотите отредактировать.",
                 "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bookListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
             
            if (e.Column == lvwItemComparer.SortColumn)
            {
                if (lvwItemComparer.Order == SortOrder.Ascending)
                {
                    lvwItemComparer.Order = SortOrder.Descending;
                }
                else
                {
                    lvwItemComparer.Order = SortOrder.Ascending;
                }
            }
            else
            {
                 lvwItemComparer.SortColumn = e.Column;
                 lvwItemComparer.Order = SortOrder.Ascending;
            }

            this.bookListView.Sort();
        
        }
    }
}

