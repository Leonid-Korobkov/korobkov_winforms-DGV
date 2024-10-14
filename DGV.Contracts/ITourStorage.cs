using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DGV.Contracts.Models;

namespace DGV.Contracts
{
    /// <summary>
    /// Определяет интерфейс для управления хранилищем туров.
    /// Предоставляет методы для выполнения CRUD-операций (создание, чтение, обновление, удаление).
    /// </summary>
    public interface ITourStorage
    {

        /// <summary>
        /// Асинхронно возвращает список всех доступных туров.
        /// </summary>
        /// <returns>Набор туров в виде неизменяемой коллекции <see cref="IReadOnlyCollection{Tour}"/>.</returns>
        Task<IReadOnlyCollection<Tour>> GetAllToursAsync();

        /// <summary>
        /// Асинхронно добавляет новый тур в коллекцию.
        /// </summary>
        /// <param name="tour">Экземпляр тура, который необходимо добавить.</param>
        /// <returns>Добавленный тур с уникальным идентификатором.</returns>
        Task<Tour> AddTourAsync(Tour tour);

        /// <summary>
        /// Асинхронно обновляет данные существующего тура.
        /// </summary>
        /// <param name="tour">Экземпляр тура с измененными данными.</param>
        Task EditTourAsync(Tour tour);

        /// <summary>
        /// Асинхронно удаляет тур по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Уникальный идентификатор тура, который необходимо удалить.</param>
        /// <returns>Значение <see cref="bool"/>, указывающее, был ли тур успешно удален.</returns>
        Task<bool> DeleteTourAsync(Guid id);
    }
}
