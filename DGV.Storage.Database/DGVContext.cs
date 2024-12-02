using System.Data.Entity;
using DGV.Standart.Contracts.Models;

namespace DGV.Storage.Database
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public class DGVContext : DbContext
    {
        /// <summary>
        /// Конструктор контекста базы данных
        /// </summary>
        public DGVContext() : base("DBConnection")
        {
        }

        /// <summary>
        /// Таблица <see cref="Tour"/> в базе данных
        /// </summary>
        public DbSet<Tour> Tours { get; set; }
    }
}
