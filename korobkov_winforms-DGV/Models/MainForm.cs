using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGV.Standart.Contracts.Models;
using DGV.Standart.Manager;
using korobkov_winforms_DGV.Classes;
using korobkov_winforms_DGV.Models;

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

            //toursDGV.AutoGenerateColumns = false;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = await tourManager.GetAllToursAsync();
            toursDGV.Columns["Id"].Visible = false;
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
                await tourManager.AddTourAsync(ChangeTypeTour.TourValidation(addForm.EditableTour));
                bindingSource.DataSource = await tourManager.GetAllToursAsync();
                bindingSource.ResetBindings(false);
                await SetStats();
            }
        }

        private async void BtnEditTour_Click(object sender, EventArgs e)
        {
            if (toursDGV.SelectedRows.Count > 0)
            {
                var data = (Tour)toursDGV.Rows[toursDGV.SelectedRows[0].Index].DataBoundItem;
                var editForm = new AddEditForm(ChangeTypeTour.TourValidation(data));
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    await tourManager.EditTourAsync(ChangeTypeTour.TourValidation(editForm.EditableTour));
                    bindingSource.DataSource = await tourManager.GetAllToursAsync();
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
                    bindingSource.DataSource = await tourManager.GetAllToursAsync();
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
