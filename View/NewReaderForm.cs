
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using LibraryApp.Entities;
using LibraryApp.Services;
using LibraryApp.Data;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;



namespace LibraryApp.View
{
    partial class NewReaderForm : MaterialForm
    {
      
        IReaderService _readerService = new ReaderService();
        IBookService _bookService = new BookService();
        private List<Book> _books = new List<Book>();

        public Reader Reader { get; set; }
       
        public NewReaderForm()
        {
         
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal300, Primary.Teal500, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);

            LoadComboBoxItems();

            

        }

        private void LoadComboBoxItems()
        {
            var books = _bookService.GetBooks();
            foreach (var item in books)
            {
                bookComboBox.Items.Add(item.Name + " | " + item.Author + " | " + item.Year);
            }
            //using (var f = File.OpenText("booksData.json"))
            //{
            //    var json = f.ReadToEnd();
            //    _books = JsonConvert.DeserializeObject<Book[]>(json,
            //        new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
             
            //}
            //foreach (var item in _books)
            //{
            //    bookComboBox.Items.Add(item.Name + " | " + item.Author + " | " + item.Year);
            //}



        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
           
            var id = _readerService.GetMaxId();
            Reader = new Reader
            {
                Id = id + 1,
                FirstName = materialTextBox1.Text,
                LastName = materialTextBox2.Text,
                Telephone = materialTextBox3.Text,
                Book = bookComboBox.Text
  
            };
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

       
    }
}
