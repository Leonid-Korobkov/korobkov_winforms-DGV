using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DGV.Contracts.Models;

namespace korobkov_winforms_DGV
{
    public partial class AddEditForm : Form
    {
        private bool isEditMode;
        private Tour currentTour;

        public AddEditForm(Tour currentTour = null)
        {
            InitializeComponent();

            if (currentTour != null)
            {
                this.currentTour = new Tour
                {
                    Id = currentTour.Id,
                    AdditionalFees = currentTour.AdditionalFees,
                    DepartureDate = currentTour.DepartureDate,
                    Destination = currentTour.Destination,
                    HasWiFi = currentTour.HasWiFi,
                    Nights = currentTour.Nights,
                    NumberOfPeople = currentTour.NumberOfPeople,
                    PricePerPerson = currentTour.PricePerPerson,
                };
                isEditMode = true;
            }
            else
            {
                this.currentTour = DataGenerator.CreateTour();
            }
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
            //comboBoxDirection.AddBinding(t => t.SelectedItem, currentTour, s => s.Destination, errorProvider1);
            //dateTimePickerDeparture.AddBinding(t => t.Value, currentTour, s => s.DepartureDate, errorProvider1);
            //numericUpDownCountNights.AddBinding(t => t.Value, currentTour, s => s.Nights, errorProvider1);
            //numericUpDownSumPerson.AddBinding(t => t.Value, currentTour, s => s.PricePerPerson, errorProvider1);
            //numericUpDownCountPeople.AddBinding(t => t.Value, currentTour, s => s.NumberOfPeople, errorProvider1);
            //checkBoxWiFi.AddBinding(t => t.Checked, currentTour, s => s.HasWiFi, errorProvider1);
            //textBoxSumDop.AddBinding(t => t.Value, currentTour, s => s.AdditionalFees, errorProvider1);
            comboBoxDirection.AddBinding(t => t.SelectedItem, currentTour, s => s.Destination);
            dateTimePickerDeparture.AddBinding(t => t.Value, currentTour, s => s.DepartureDate);
            numericUpDownCountNights.AddBinding(t => t.Value, currentTour, s => s.Nights);
            numericUpDownSumPerson.AddBinding(t => t.Value, currentTour, s => s.PricePerPerson);
            numericUpDownCountPeople.AddBinding(t => t.Value, currentTour, s => s.NumberOfPeople);
            checkBoxWiFi.AddBinding(t => t.Checked, currentTour, s => s.HasWiFi);
            textBoxSumDop.AddBinding(t => t.Value, currentTour, s => s.AdditionalFees);
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (HasValidationErrors())
            {
                MessageBox.Show("Некоторые поля заполнены неверно. Проверьте ошибки и попробуйте снова.",
"Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool HasValidationErrors()
        {
            var context = new ValidationContext(currentTour);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(currentTour, context, results, true);

            foreach (var result in results)
            {
                Debug.WriteLine($"Ошибка: {result.ErrorMessage}");
            }

            return !isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
