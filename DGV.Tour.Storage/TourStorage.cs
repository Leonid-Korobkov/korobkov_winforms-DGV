using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DGV.Contracts;
using DGV.Contracts.Models;

namespace DGV.Tour.Storage
{
    /// <summary>
    /// <inheritdoc cref="ITourStorage" />
    /// </summary>
    public class TourStorage : ITourStorage
    {
        private List<Contracts.Models.Tour> tourList = new List<Contracts.Models.Tour>();
        /// <summary>
        /// <inheritdoc cref="ITourStorage.AddTourAsync(Contracts.Models.Tour)" />
        /// </summary>
        public Task<Contracts.Models.Tour> AddTourAsync(Contracts.Models.Tour tour)
        {
            tourList.Add(tour);
            return Task.FromResult(tour);
        }

        // <summary>
        /// <inheritdoc cref="ITourStorage.DeleteTourAsync(Guid)" />
        /// </summary>
        public Task<bool> DeleteTourAsync(Guid id)
        {
            var tour = tourList.FirstOrDefault(x => x.Id == id);
            if (tour != null)
            {
                tourList.Remove(tour);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        // <summary>
        /// <inheritdoc cref="ITourStorage.EditTourAsync(Contracts.Models.Tour)" />
        /// </summary>
        public Task EditTourAsync(Contracts.Models.Tour tour)
        {
            var target = tourList.FirstOrDefault(x => x.Id == tour.Id);
            if (tour != null)
            {
                target.Destination = tour.Destination;
                target.DepartureDate = tour.DepartureDate;
                target.Nights = tour.Nights;
                target.PricePerPerson = tour.PricePerPerson;
                target.NumberOfPeople = tour.NumberOfPeople;
                target.HasWiFi = tour.HasWiFi;
                target.AdditionalFees = tour.AdditionalFees;
            }

            return Task.CompletedTask;
        }

        // <summary>
        /// <inheritdoc cref="ITourStorage.GetAllToursAsync()" />
        /// </summary>
        public Task<IReadOnlyCollection<Contracts.Models.Tour>> GetAllToursAsync()
            => Task.FromResult<IReadOnlyCollection<Contracts.Models.Tour>>(tourList);
    }
}
