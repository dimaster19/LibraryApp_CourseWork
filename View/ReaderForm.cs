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
    public partial class ReaderForm : MaterialForm
       
    {
        private readonly IReaderService _readerService = new ReaderService();
        private ListViewItemComparer lvwItemComparer;
        public ReaderForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal300, Primary.Teal500, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            lvwItemComparer = new ListViewItemComparer();
            this.readerListView.ListViewItemSorter = lvwItemComparer;
            FillReaderList();
        }


        private void FillReaderList()
        {
            readerListView.Items.Clear();

            var readers = _readerService.GetReaders();

            foreach (var reader in readers)
            {
                var lvi = new ListViewItem(new[]
                {
                    reader.Id.ToString(),
                    reader.FirstName,
                    reader.LastName,
                    reader.Book,
                    reader.Telephone
                });

                readerListView.Items.Add(lvi);
            }
        }

        private void addButton1_Click(object sender, EventArgs e)
        {

            var newReaderForm = new NewReaderForm();

            if (newReaderForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var newReader = newReaderForm.Reader;
            _readerService.AddReader(newReader);
            FillReaderList();
            Log.Information($"Пользователь {Status.User} добавил запись {newReader.Id}.");
            

        }

        private void ReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void removeButton2_Click(object sender, EventArgs e)
        {
            //if (readerListView.SelectedIndices.Count == 0)
            //{
            //    MessageBox.Show("Выберте одну запись которую хотите удалить.",
            //        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //var idx = readerListView.SelectedIndices[0];
            //var readerId = _readerService.GetReaders().ElementAt(idx).Id;
            //_readerService.RemoveReader(readerId);
            //FillReaderList();
            //Log.Information($"Пользователь {Status.User} удалил запись {idx}.");



            if (readerListView.SelectedIndices.Count > 0)
            {
                
                    var idx = int.Parse(readerListView.SelectedItems[0].SubItems[0].Text);
                    if (MessageBox.Show($"Вы действительно хотите удалить эту запись: {idx}.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _readerService.RemoveReader(idx);
                        FillReaderList();
                        Log.Information($"Пользователь {Status.User} удалил запись {idx}.");
                    }

            }
            else { MessageBox.Show("Выберте запись которую хотите удалить."); }
        }

        private void editButton1_Click(object sender, EventArgs e)
        {

            if (readerListView.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(readerListView.SelectedItems[0].SubItems[0].Text);
                var Name = readerListView.SelectedItems[0].SubItems[1].Text + " " + readerListView.SelectedItems[0].SubItems[2].Text;
                if (MessageBox.Show($"Вы действительно хотите отредактировать эту запись: {idx} - {Name}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Status.Update = true;
                    Status.ID = idx;
                    NewReaderForm edit = new NewReaderForm
                    {
                        Text = "Изменить читателя"
                    };
                    if (edit.ShowDialog() != DialogResult.OK)
                    {
                        Status.Update = false;
                        return;
                    }
                    var newReader = edit.Reader;
                    newReader.Id = idx;
                    _readerService.UpdateReader(newReader, idx);
                    FillReaderList();
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

        private void readerListView_ColumnClick(object sender, ColumnClickEventArgs e)
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

            this.readerListView.Sort();
        }
    }
}
