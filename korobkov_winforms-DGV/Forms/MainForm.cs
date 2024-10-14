using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGV.Contracts;
using DGV.Contracts.Models;
using DGV.Tour.Manager;

namespace korobkov_winforms_DGV
{
    public partial class MainForm : Form
    {
        BindingSource bindingSource;
        private TourManager tourManager;

        public MainForm(TourManager tourManager)
        {
            InitializeComponent();
            this.tourManager = tourManager;

            bindingSource = new BindingSource();

            toursDGV.DataSource = bindingSource;
            toursDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            toursDGV.AutoGenerateColumns = false;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = await tourManager.GetAllToursAsync();
            await SetStats();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void BtnAddNewTour_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                await tourManager.AddTourAsync(addForm.EditableTour);
                bindingSource.ResetBindings(false);
                await SetStats();
            }
        }

        private async void BtnEditTour_Click(object sender, EventArgs e)
        {
            if (toursDGV.SelectedRows.Count > 0)
            {
                var data = (Tour)toursDGV.Rows[toursDGV.SelectedRows[0].Index].DataBoundItem;
                var editForm = new AddEditForm(data);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    await tourManager.EditTourAsync(editForm.EditableTour);
                    bindingSource.ResetBindings(false);
                    await SetStats();
                }
            }
        }

        private async void BtnRemoveTour_Click(object sender, EventArgs e)
        {
            if (toursDGV.SelectedRows.Count > 0)
            {
                var data = (Tour)toursDGV.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"Удалить {data.Destination} запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    await tourManager.DeleteTourAsync(data.Id);
                    bindingSource.ResetBindings(false);
                    await SetStats();
                };
            }
        }

        private void toursDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (toursDGV.Columns[e.ColumnIndex].Name == "WiFi")
            {
                var data = (Tour)toursDGV.Rows[e.RowIndex].DataBoundItem;
                e.Value = data.HasWiFi ? "Да" : "Нет";
            }
            if (toursDGV.Columns[e.ColumnIndex].Name == "Destination")
            {
                var data = (Tour)toursDGV.Rows[e.RowIndex].DataBoundItem;
                e.Value = data.Destination.GetDisplayValue();
            }
        }

        public async Task SetStats()
        {
            var result = await tourManager.GetStatsAsync();
            toolStripStatusTotalCount.Text = $"Общее кол-во туров: {result.TotalCountTours}";
            toolStripStatusTotalSum.Text = $"Общая сумма за все туры: {result.TotalSumTours}";
            toolStripStatusTotalSumDop.Text = $"Общая сумма доплат: {result.TotalSumDop}";
            toolStripStatusCountDop.Text = $"Количество туров с доплатами: {result.CountToursWithDop}";
        }
    }
}
