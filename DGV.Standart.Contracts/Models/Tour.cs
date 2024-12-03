using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DGV.Standart.Contracts.Models
{
    /// <summary>
    /// Класс для горячего тура
    /// </summary>
    public class Tour
    {
        /// <summary>
        /// Уникальный идентификатор тура
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Направление тура (точка назначения)
        /// </summary>
        [DisplayName("Назначение")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Destination { get; set; }

        /// <summary>
        /// Дата вылета
        /// </summary>
        [DisplayName("Дата вылета")]
        public DateTime DepartureDate { get; set; }

        /// <summary>
        /// Количество ночей
        /// </summary>
        [DisplayName("Кол-во ночей")]
        [Range(0d, 30,
            ErrorMessage = "Число должно быть больше 0 и меньше 30")]
        public int Nights { get; set; }

        /// <summary>
        /// Стоимость за одного отдыхающего
        /// </summary>
        [DisplayName("Цена за человека")]
        [Range(0d, double.MaxValue,
            ErrorMessage = "Число должно быть больше 0")]
        public decimal PricePerPerson { get; set; }

        /// <summary>
        /// Количество отдыхающих
        /// </summary>
        [DisplayName("Кол-во отдыхающих")]
        [Range(0, int.MaxValue,
            ErrorMessage = "Число должно быть больше 0")]
        public int NumberOfPeople { get; set; }

        /// <summary>
        /// Наличие Wi-Fi
        /// </summary>
        [DisplayName("Наличие Wi-Fi")]
        public bool HasWiFi { get; set; }

        /// <summary>
        /// Доплаты
        /// </summary>
        [DisplayName("Доплаты")]
        [Range(0, 50000, ErrorMessage = "Стоимость должна быть от 100 до 50000 рублей")]
        [DefaultValue(0)]
        public decimal AdditionalFees { get; set; }

        /// <summary>
        /// Создать новый тур
        /// </summary>
        public Tour()
        {
            Id = Guid.NewGuid();
        }
    }
}
