using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DGV.Standart.Contracts.Models;

namespace DGV.Standart.Contracts
{
    /// <summary>
    /// Управление коллекцией туров с выполнением CRUD-операций:  
    /// создание, чтение, обновление и удаление.
    /// </summary>
    public interface ITourManager
    {
        /// <summary>
        /// Получение списка <see cref="Tour"/> в виде неизменяемой коллекции.
        /// </summary>
        /// <returns><see cref="IReadOnlyCollection{Tour}"/> со всеми турами.</returns>
        Task<IReadOnlyCollection<Tour>> GetAllToursAsync();

        /// <summary>
        /// Добавление нового <see cref="Tour"/>.
        /// </summary>
        /// <param name="tour">Добавляемый экземпляр <see cref="Tour"/>.</param>
        /// <returns>Добавленный <see cref="Tour"/> с уникальным идентификатором.</returns>
        Task<Tour> AddTourAsync(Tour tour);

        /// <summary>
        /// Обновление существующего <see cref="Tour"/>.
        /// </summary>
        /// <param name="tour">Экземпляр <see cref="Tour"/> с измененными данными.</param>
        Task EditTourAsync(Tour tour);

        /// <summary>
        /// Удаление <see cref="Tour"/> по идентификатору.
        /// </summary>
        /// <param name="id">Уникальный идентификатор удаляемого <see cref="Tour"/>.</param>
        /// <returns><see cref="bool"/>, указывающий на успешное удаление.</returns>
        Task<bool> DeleteTourAsync(Guid id);

        /// <summary>
        /// Получение объекта <see cref="ITourStats"/> со статистикой туров.
        /// </summary>
        Task<ITourStats> GetStatsAsync();
    }
}
