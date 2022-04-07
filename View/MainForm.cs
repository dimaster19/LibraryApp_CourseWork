using MaterialSkin;
using MaterialSkin.Controls;
using System;
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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            if (!Status.Value) { showWorkers.Enabled = false;  }

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal300, Primary.Teal500, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void showWorkers_Click(object sender, EventArgs e)
        {
            WorkerForm workerForm = new WorkerForm();
            this.Hide();
            workerForm.ShowDialog();
            this.Show();
        }

        private void showReaders_Click(object sender, EventArgs e)
        {
            ReaderForm readerForm = new ReaderForm();
            this.Hide(); 
            readerForm.ShowDialog();
            this.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            this.Hide();
            bookForm.ShowDialog();
            this.Show();
        }
    }
    
}
