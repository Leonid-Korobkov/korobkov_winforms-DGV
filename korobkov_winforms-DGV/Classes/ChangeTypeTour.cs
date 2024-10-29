using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGV.Standart.Contracts.Models;
using korobkov_winforms_DGV.Models;

namespace korobkov_winforms_DGV.Classes
{
    public class ChangeTypeTour
    {
        /// <summary>
        /// Меняем тип <see cref="ValidateTour"/> на <see cref="Tour"/>
        /// </summary>
        public static Tour TourValidation(ValidateTour tour)
        {
            return new Tour
            {
                Id = tour.Id,
                Destination = tour.Destination,
                DepartureDate = tour.DepartureDate,
                Nights = tour.Nights,
                PricePerPerson = tour.PricePerPerson,
                NumberOfPeople = tour.NumberOfPeople,
                HasWiFi = tour.HasWiFi,
                AdditionalFees = tour.AdditionalFees
            };
        }

        /// <summary>
        /// Меняем тип <see cref="Tour"/> на <see cref="ValidateTour"/>
        /// </summary>
        public static ValidateTour TourValidation(Tour tour)
        {
            return new ValidateTour
            {
                Id = tour.Id,
                Destination = tour.Destination,
                DepartureDate = tour.DepartureDate,
                Nights = tour.Nights,
                PricePerPerson = tour.PricePerPerson,
                NumberOfPeople = tour.NumberOfPeople,
                HasWiFi = tour.HasWiFi,
                AdditionalFees = tour.AdditionalFees
            };
        }
    }
}
