using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGV.Contracts;
using DGV.Tour.Manager.Models;

namespace DGV.Tour.Manager
{
    /// <summary>
    /// <inheritdoc cref="ITourManager />
    /// </summary>
    public class TourManager : ITourManager

    {
        private ITourStorage tourStorage;

        public TourManager(ITourStorage tourStorage)
        {
            this.tourStorage = tourStorage;
        }

        /// <summary>
        /// <inheritdoc cref="ITourManager.AddTourAsync(Contracts.Models.Tour)" />
        /// </summary>
        public async Task<Contracts.Models.Tour> AddTourAsync(Contracts.Models.Tour tour)
            => await tourStorage.AddTourAsync(tour);

        /// <summary>
        /// <inheritdoc cref="ITourManager.AddTourAsync(Contracts.Models.Tour)" />
        /// </summary>
        public async Task<bool> DeleteTourAsync(Guid id)
            => await tourStorage.DeleteTourAsync(id);

        /// <summary>
        /// <inheritdoc cref="ITourManager.EditTourAsync(Contracts.Models.Tour)" />
        /// </summary>
        public async Task EditTourAsync(Contracts.Models.Tour tour)
            => await tourStorage.EditTourAsync(tour);

        /// <summary>
        /// <inheritdoc cref="ITourManager.GetAllToursAsync()" />
        /// </summary>
        public async Task<IReadOnlyCollection<Contracts.Models.Tour>> GetAllToursAsync()
            => await tourStorage.GetAllToursAsync();

        /// <summary>
        /// <inheritdoc cref="ITourManager.GetStatsAsync()" />
        /// </summary>
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
