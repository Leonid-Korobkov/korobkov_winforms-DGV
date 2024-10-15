using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DGV.Contracts;

namespace DGV.Tour.Storage
{
    /// <inheritdoc cref="ITourStorage" />
    public class MemoryTourStorage : ITourStorage
    {
        private List<Contracts.Models.Tour> tourList = new List<Contracts.Models.Tour>();

        /// <inheritdoc cref="ITourStorage.AddTourAsync(Contracts.Models.Tour)" />
        public Task<Contracts.Models.Tour> AddTourAsync(Contracts.Models.Tour tour)
        {
            tourList.Add(tour);
            return Task.FromResult(tour);
        }

        /// <inheritdoc cref="ITourStorage.DeleteTourAsync(Guid)" />
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

        /// <inheritdoc cref="ITourStorage.EditTourAsync(Contracts.Models.Tour)" />
        public Task EditTourAsync(Contracts.Models.Tour tour)
        {
            var target = tourList.FirstOrDefault(x => x.Id == tour.Id);
            if (target != null)
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

        /// <inheritdoc cref="ITourStorage.GetAllToursAsync()" />
        public Task<IReadOnlyCollection<Contracts.Models.Tour>> GetAllToursAsync()
            => Task.FromResult<IReadOnlyCollection<Contracts.Models.Tour>>(tourList);
    }
}
