using LibraryApp.Data;
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
    public partial class WorkerForm : MaterialForm
    {
        private readonly IWorkerService _workerService = new WorkerService();
        private ListViewItemComparer lvwItemComparer;
        public WorkerForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal300, Primary.Teal500, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            lvwItemComparer = new ListViewItemComparer();
            this.workerListView1.ListViewItemSorter = lvwItemComparer;
            FillWorkerList();
        }


        private void FillWorkerList()
        {
            workerListView1.Items.Clear();

            var workers = _workerService.GetWorkers();

            foreach (var worker in workers)
            {
                var lvi = new ListViewItem(new[]
                {
                    worker.Id.ToString(),
                    worker.FirstName, worker.LastName,
                    worker.ExpYears, worker.Address
                });

                workerListView1.Items.Add(lvi);
            }
        }

        private void WorkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newWorkerForm = new NewWorkerForm();



            if (newWorkerForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var newWorker = newWorkerForm.Worker;
            _workerService.AddWorker(newWorker);
            FillWorkerList();
            Log.Information($"Пользователь {Status.User} добавил запись {newWorker.Id}.");
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

            //if (workerListView1.SelectedIndices.Count == 0)
            //{

            //    return;
            //}
            //var idx = workerListView1.SelectedIndices[0];
            //var workerId = _workerService.GetWorkers().ElementAt(idx).Id;
            //_workerService.RemoveWorker(workerId);
            //FillWorkerList();
            //Log.Information($"Пользователь {Status.User} удалил запись {idx}.");

            if (workerListView1.SelectedIndices.Count > 0)
            {

                var idx = int.Parse(workerListView1.SelectedItems[0].SubItems[0].Text);
                if (MessageBox.Show($"Вы действительно хотите удалить эту запись: {idx}.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _workerService.RemoveWorker(idx);
                    FillWorkerList();
                    Log.Information($"Пользователь {Status.User} удалил запись {idx}.");
                }

            }
            else { MessageBox.Show("Выберте запись которую хотите удалить."); }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (workerListView1.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(workerListView1.SelectedItems[0].SubItems[0].Text);
                var Name = workerListView1.SelectedItems[0].SubItems[1].Text + " " + workerListView1.SelectedItems[0].SubItems[2].Text;
                if (MessageBox.Show($"Вы действительно хотите отредактировать эту запись: {idx} - {Name}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Status.Update = true;
                    Status.ID = idx;
                    NewWorkerForm edit = new NewWorkerForm
                    {
                        Text = "Изменить сотрудника"
                    };
                    if (edit.ShowDialog() != DialogResult.OK)
                    {
                        Status.Update = false;
                        return;
                    }
                    var newWorker = edit.Worker;
                    newWorker.Id = idx;
                    _workerService.UpdateWorker(newWorker, idx);
                    FillWorkerList();
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

        private void workerListView1_ColumnClick(object sender, ColumnClickEventArgs e)
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

            this.workerListView1.Sort();
        }
    }
}
