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
    public partial class AddEditForm : Form
    {
        private bool isEditMode;
        public Tour currentTour;

        public AddEditForm(bool isEditMode = false, Tour currentTour = null)
        {
            InitializeComponent();

            this.isEditMode = isEditMode;
            this.currentTour = currentTour ?? DataGenerator.CreateTour();
        }

        public Tour EditableTour { get => currentTour; set => currentTour = value; }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        // Настройка формы в зависимости от типа операции
        private void SetupForm()
        {
            if (isEditMode)
            {
                label1.Text = "Редактирование тура";
                Text = "Редактирование тура";
            }
            else
            {
                label1.Text = "Добавление тура";
                Text = "Добавление тура";
            }

            // Заполнение списка направлений
            foreach (var item in Enum.GetValues(typeof(Destination)))
            {
                comboBoxDirection.Items.Add(item);
            }

            // Привязка данных к элементам управления
            comboBoxDirection.AddBinding(t => t.SelectedItem, currentTour, s => s.Destination);
            dateTimePickerDeparture.AddBinding(t => t.Value, currentTour, s => s.DepartureDate);
            numericUpDownCountNights.AddBinding(t => t.Value, currentTour, s => s.Nights);
            numericUpDownSumPerson.AddBinding(t => t.Value, currentTour, s => s.PricePerPerson);
            numericUpDownCountPeople.AddBinding(t => t.Value, currentTour, s => s.NumberOfPeople);
            checkBoxWiFi.AddBinding(t => t.Checked, currentTour, s => s.HasWiFi);
        }

        private void comboBoxDirection_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.FillEllipse(Brushes.Red, new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Height - 4, e.Bounds.Height - 4));
            if (e.Index > -1)
            {
                var value = (Destination)(sender as ComboBox).Items[e.Index];
                e.Graphics.DrawString(value.GetDisplayValue(),
                   e.Font,
                   new SolidBrush(e.ForeColor),
                   e.Bounds.X + 20,
                   e.Bounds.Y);
            }
        }
    }
}
