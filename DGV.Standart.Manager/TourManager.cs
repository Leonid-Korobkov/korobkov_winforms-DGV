using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using DGV.Standart.Contracts;
using DGV.Standart.Contracts.Models;
using DGV.Standart.Manager.Models;
using Microsoft.Extensions.Logging;

namespace DGV.Standart.Manager
{
    /// <inheritdoc cref="ITourManager />
    public class TourManager : ITourManager

    {
        private ITourStorage tourStorage;

        private readonly ILogger logger;
        private const string StopwatchTemplate = "Операция {0} c id {1} выполнялась {2} мс. Результат {@tour}";
        private const string StopwatchNon = "Операция {0} c id {1}  НЕ выполнилась";

        public TourManager(ITourStorage tourStorage, ILogger logger)
        {
            this.tourStorage = tourStorage;
            this.logger = logger;
        }

        /// <inheritdoc cref="ITourManager.AddTourAsync(Contracts.Models.Tour)" />
        public async Task<Contracts.Models.Tour> AddTourAsync(Contracts.Models.Tour tour)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Contracts.Models.Tour result = null;
            try
            {
                result = await tourStorage.AddTourAsync(tour);
                logger.LogInformation(StopwatchTemplate, nameof(ITourManager.AddTourAsync), tour.Id, stopWatch.ElapsedMilliseconds, result);
            }
            catch (Exception ex)
            {
                logger.LogInformation(StopwatchNon + ex.Message, nameof(ITourManager.AddTourAsync), tour.Id);
            }
            stopWatch.Stop();
            return result;
        }

        /// <inheritdoc cref="ITourManager.DeleteTourAsync(Guid)" />
        public async Task<bool> DeleteTourAsync(Guid id)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            bool result = false;
            try
            {
                result = await tourStorage.DeleteTourAsync(id);
                logger.LogInformation(StopwatchTemplate, nameof(ITourManager.DeleteTourAsync), id, stopWatch.ElapsedMilliseconds, result);
            }
            catch (Exception ex)
            {
                logger.LogInformation(StopwatchNon, nameof(ITourManager.DeleteTourAsync), id);
            }
            stopWatch.Stop();
            return result;
        }

        /// <inheritdoc cref="ITourManager.EditTourAsync(Contracts.Models.Tour)" />
        public async Task EditTourAsync(Contracts.Models.Tour tour)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            try
            {
                await tourStorage.EditTourAsync(tour);
                logger.LogInformation(StopwatchTemplate, nameof(ITourManager.EditTourAsync), tour.Id, stopWatch.ElapsedMilliseconds, tour);
            }
            catch (Exception ex)
            {
                logger.LogInformation(StopwatchNon, nameof(ITourManager.AddTourAsync), tour.Id);
            }
            stopWatch.Stop();
        }

        /// <inheritdoc cref="ITourManager.GetAllToursAsync()" />
        public async Task<IReadOnlyCollection<Contracts.Models.Tour>> GetAllToursAsync()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            List<Contracts.Models.Tour> result = null;

            try
            {
                result = (List<Tour>)await tourStorage.GetAllToursAsync();
                logger.LogInformation(
                    StopwatchTemplate,
                    nameof(ITourManager.GetAllToursAsync),
                    result,
                    stopWatch.ElapsedMilliseconds,
                    result);
            }
            catch (Exception ex)
            {
                logger.LogInformation(
                    StopwatchNon,
                    nameof(ITourManager.GetAllToursAsync),
                    result);
            }
            finally
            {
                stopWatch.Stop();
            }

            return result;
        }


        /// <inheritdoc cref="ITourManager.GetStatsAsync()" />
        public async Task<ITourStats> GetStatsAsync()
        {
            var result = await tourStorage.GetAllToursAsync();
            return new TourStats
            {
                TotalCountTours = result.Count,
                TotalSumTours = result.Sum(t => t.PricePerPerson * t.NumberOfPeople + t.AdditionalFees),
                CountToursWithDop = result.Count(t => t.AdditionalFees > 0),
                TotalSumDop = result.Sum(t => t.AdditionalFees)
            };
        }
    }
}
