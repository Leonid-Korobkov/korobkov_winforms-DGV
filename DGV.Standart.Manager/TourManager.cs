using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DGV.Standart.Contracts;
using DGV.Standart.Manager.Models;

namespace DGV.Standart.Manager
{
    /// <inheritdoc cref="ITourManager />
    public class TourManager : ITourManager

    {
        private ITourStorage tourStorage;

        public TourManager(ITourStorage tourStorage)
        {
            this.tourStorage = tourStorage;
        }

        /// <inheritdoc cref="ITourManager.AddTourAsync(Contracts.Models.Tour)" />
        public async Task<Contracts.Models.Tour> AddTourAsync(Contracts.Models.Tour tour)
            => await tourStorage.AddTourAsync(tour);

        /// <inheritdoc cref="ITourManager.AddTourAsync(Contracts.Models.Tour)" />
        public async Task<bool> DeleteTourAsync(Guid id)
            => await tourStorage.DeleteTourAsync(id);

        /// <inheritdoc cref="ITourManager.EditTourAsync(Contracts.Models.Tour)" />
        public async Task EditTourAsync(Contracts.Models.Tour tour)
            => await tourStorage.EditTourAsync(tour);

        /// <inheritdoc cref="ITourManager.GetAllToursAsync()" />
        public async Task<IReadOnlyCollection<Contracts.Models.Tour>> GetAllToursAsync()
            => await tourStorage.GetAllToursAsync();

        /// <inheritdoc cref="ITourManager.GetStatsAsync()" />
        public async Task<ITourStats> GetStatsAsync()
        {
            var result = await tourStorage.GetAllToursAsync();
            return new TourStats
            {
                TotalCountTours = result.Count,
                TotalSumTours = result.Sum(t => t.PricePerPerson * t.NumberOfPeople),
                CountToursWithDop = result.Count(t => t.AdditionalFees > 0),
                TotalSumDop = result.Sum(t => t.AdditionalFees)
            };
        }
    }
}
