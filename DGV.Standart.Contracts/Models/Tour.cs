using System;
using System.ComponentModel;

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
        public Destination Destination { get; set; }

        /// <summary>
        /// Дата вылета
        /// </summary>
        [DisplayName("Дата вылета")]
        public DateTime DepartureDate { get; set; }

        /// <summary>
        /// Количество ночей
        /// </summary>
        [DisplayName("Кол-во ночей")]
        public int Nights { get; set; }

        /// <summary>
        /// Стоимость за одного отдыхающего
        /// </summary>
        [DisplayName("Цена за человека")]
        public decimal PricePerPerson { get; set; }

        /// <summary>
        /// Количество отдыхающих
        /// </summary>
        [DisplayName("Кол-во отдыхающих")]
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
