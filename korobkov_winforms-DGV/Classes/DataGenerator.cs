using System;
using DGV.Standart.Contracts.Models;
using korobkov_winforms_DGV.Models;

namespace korobkov_winforms_DGV
{
    /// <summary>
    /// Генерация данных о турах
    /// </summary>
    public static class DataGenerator
    {
        public static ValidateTour CreateTour(Action<ValidateTour> customizeTour = null)
        {
            // Создаем тур с заранее заданными значениями
            var newTour = new ValidateTour
            {
                Id = Guid.NewGuid(),
                Destination = Destination.Turkey,
                DepartureDate = DateTime.Now.AddDays(7),  // Выезд через 7 дней
                Nights = 7,
                PricePerPerson = 80000M,
                NumberOfPeople = 2,
                HasWiFi = true,
                AdditionalFees = 3000M
            };

            // Если передана кастомная логика, применяем её
            customizeTour?.Invoke(newTour);

            return newTour;
        }
    }
}
