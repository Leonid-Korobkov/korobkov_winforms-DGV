using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korobkov_winforms_DGV
{
    /// <summary>
    /// Генерация данных о турах
    /// </summary>
    public static class DataGenerator
    {
        public static Tour CreateTour(Action<Tour> customizeTour = null)
        {
            // Создаем тур с заранее заданными значениями
            var newTour = new Tour
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
