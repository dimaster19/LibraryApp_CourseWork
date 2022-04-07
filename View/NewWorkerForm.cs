using MaterialSkin;
using MaterialSkin.Controls;
using System;
using LibraryApp.Entities;
using LibraryApp.Services;
using System.Windows.Forms;
using System.Linq;

namespace LibraryApp.View
{
    partial class NewWorkerForm : MaterialForm
    {
        IWorkerService _workerService = new WorkerService();
        public Worker Worker { get; set; }

        public NewWorkerForm()
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal300, Primary.Teal500, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);


        }


      

        private void savelButton_Click(object sender, EventArgs e)
        {
            var id = _workerService.GetMaxId();
            Worker = new Worker
            {
                Id = id + 1,
                FirstName = nameTextBox.Text,
                LastName = surnameTextBox.Text,
                ExpYears = expYearsTextBox.Text,
                Address = addressTextBox.Text


            };
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

