using DGV.Standart.Contracts;
using DGV.Standart.Contracts.Models;
using DGV.Standart.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tours.WebApp.Controllers
{
    public class TourController : Controller
    {
        private readonly TourManager tourManager;

        public TourController(TourManager tourManager)
        {
            this.tourManager = tourManager;
        }

        /// <summary>
        /// Отображает список всех туров
        /// </summary>
        /// GET: TourController
        public async Task<IActionResult> Index()
        {
            var tours = tourManager.GetAllToursAsync();
            var statistics = tourManager.GetStatsAsync();
            await Task.WhenAll(tours, statistics);

            ViewData[nameof(ITourStats)] = statistics.Result;
            return View(tours.Result);
        }

        /// <summary>
        /// Отображает страницу создания нового тура
        /// </summary>
        /// <returns></returns>
        // GET: TourController/Create
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Обрабатывает создание нового тура.
        /// </summary>
        // POST: TourController/Create
        [HttpPost]
        async public Task<ActionResult> Create(Tour tour)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            tour.Id = Guid.NewGuid();
            await tourManager.AddTourAsync(tour);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Отображает страницу редактирования тура по его идентификатору
        /// </summary>
        // GET: TourController/Edit
        public async Task<IActionResult> Edit(Guid id)
        {
            var tours = await tourManager.GetAllToursAsync();
            var tour = tours.FirstOrDefault(p => p.Id == id);
            if (tour == null)
            {
                return NotFound();
            }

            return View(tour);
        }

        /// <summary>
        /// Обрабатывает редактирование текущего тура
        /// </summary>
        /// POST: TourController/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Tour tour)
        {
            if (!ModelState.IsValid)
            {
                return View(tour);
            }

            var tours = await tourManager.GetAllToursAsync();
            var existingTour = tours.FirstOrDefault(p => p.Id == id);
            if (existingTour == null)
            {
                return NotFound();
            }

            await tourManager.EditTourAsync(tour);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Обрабатывает удаление тура по его идентификатору
        /// </summary>
        /// DELETE: TourController/Delete
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await tourManager.DeleteTourAsync(id);
            if (result == false)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
