using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DGV.Standart.Contracts;
using DGV.Standart.Contracts.Models;

namespace DGV.Storage.Database
{
    /// <summary>
    /// Работа с контекстом бд туров
    /// </summary>
    public class DBTour : ITourStorage
    {
        /// <inheritdoc cref="ITourStorage.AddTourAsync(Contracts.Models.Tour)" />
        public async Task<Tour> AddTourAsync(Tour tour)
        {
            using (var context = new DGVContext())
            {
                context.Tours.Add(tour);
                await context.SaveChangesAsync();
            }
            return tour;
        }

        /// <inheritdoc cref="ITourStorage.DeleteTourAsync(Guid)" />
        public async Task EditTourAsync(Tour tour)
        {
            using (var context = new DGVContext())
            {
                var target = await context.Tours.FirstOrDefaultAsync(x => x.Id == tour.Id);
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
                await context.SaveChangesAsync();
            }
        }

        /// <inheritdoc cref="ITourStorage.EditTourAsync(Contracts.Models.Tour)" />
        public async Task<bool> DeleteTourAsync(Guid id)
        {
            using (var context = new DGVContext())
            {
                var item = await context.Tours.FirstOrDefaultAsync(x => x.Id == id);
                if (item != null)
                {
                    context.Tours.Remove(item);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }

        /// <inheritdoc cref="ITourStorage.GetAllToursAsync()" />
        public async Task<IReadOnlyCollection<Tour>> GetAllToursAsync()
        {
            using (var context = new DGVContext())
            {
                var items = await context.Tours
                    .OrderByDescending(x => x.PricePerPerson)
                    .ToListAsync();
                return items;
            }
        }
    }
}
