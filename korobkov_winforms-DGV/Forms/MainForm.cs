using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace korobkov_winforms_DGV
{
    public partial class MainForm : Form
    {
        BindingSource bindingSource;
        private List<Tour> tourList = new List<Tour>();

        public MainForm()
        {
            InitializeComponent();

            bindingSource = new BindingSource();
            bindingSource.DataSource = tourList;

            toursDGV.AutoGenerateColumns = false;
            toursDGV.DataSource = bindingSource;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAddNewTour_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var newTour = addForm.currentTour;

                // Добавить новый тур в список
                tourList.Add(newTour);

                // Обновить источник данных
                bindingSource.ResetBindings(false);
            }
        }

        private void BtnEditTour_Click(object sender, EventArgs e)
        {
            if (tourList.Count > 0)
            {
                var tour = new Tour();
                var editForm = new AddEditForm();
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    tourList[toursDGV.CurrentCell.RowIndex] = editForm.EditableTour;
                }
            }

            //UpdateOutputData();
        }

        private void BtnRemoveTour_Click(object sender, EventArgs e)
        {

        }
    }
}
