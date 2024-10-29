using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DGV.Standart.Contracts.Models;

namespace korobkov_winforms_DGV.Models
{
    /// <inheritdoc cref="Tour" />
    public class ValidateTour : Tour
    {
        /// <inheritdoc cref="Tour.Id" />
        public Guid Id { get; set; }


        /// <inheritdoc cref="Tour.Destination" />
        [Required]
        [DisplayName("Назначение")]
        public Destination Destination { get; set; }


        /// <inheritdoc cref="Tour.DepartureDate" />
        [DisplayName("Дата вылета")]
        public DateTime DepartureDate { get; set; }


        /// <inheritdoc cref="Tour.Nights" />
        [DisplayName("Кол-во ночей")]
        [Range(1, 31)]
        public int Nights { get; set; }


        /// <inheritdoc cref="Tour.PricePerPerson" />
        [DisplayName("Цена за человека")]
        public decimal PricePerPerson { get; set; }


        /// <inheritdoc cref="Tour.NumberOfPeople" />
        [DisplayName("Кол-во отдыхающих")]
        [Range(1, 10)]
        public int NumberOfPeople { get; set; }


        /// <inheritdoc cref="Tour.HasWiFi" />
        [DisplayName("Наличие Wi-Fi")]
        public bool HasWiFi { get; set; }


        /// <inheritdoc cref="Tour.AdditionalFees" />
        [DisplayName("Доплаты")]
        public decimal AdditionalFees { get; set; }


        /// <inheritdoc cref="Tour.Tour" />
        public ValidateTour()
        {
            Id = Guid.NewGuid();
        }
    }
}
