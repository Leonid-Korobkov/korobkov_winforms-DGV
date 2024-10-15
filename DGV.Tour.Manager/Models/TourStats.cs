using DGV.Contracts;

namespace DGV.Tour.Manager.Models
{
    /// <summary>
    /// Класс, представляющий статистику туров, 
    /// включая общее количество, суммы и дополнительные сборы.
    /// </summary>
    public class TourStats : ITourStats
    {
        /// <summary>
        /// Общее количество туров.
        /// </summary>
        public int TotalCountTours { get; set; }

        /// <summary>
        /// Общая сумма стоимости всех туров.
        /// Рассчитывается как сумма произведений стоимости на человека и количества человек для каждого тура.
        /// </summary>
        public decimal TotalSumTours { get; set; }

        /// <summary>
        /// Количество туров с дополнительными сборами.
        /// </summary>
        public int CountToursWithDop { get; set; }

        /// <summary>
        /// Общая сумма дополнительных сборов по всем турам.
        /// </summary>
        public decimal TotalSumDop { get; set; }
    }
}
