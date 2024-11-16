using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGV.Standart.Contracts;
using DGV.Standart.Contracts.Models;
using FluentAssertions;
using korobkov_winforms_DGV;
using korobkov_winforms_DGV.Classes;
using korobkov_winforms_DGV.Models;
using Xunit;

namespace DGV.Standart.Storage.Tests
{
    /// <summary>Тесты для <see cref="MemoryTourStorage"/></summary>
    public class MemoryTourStorageTests
    {
        private readonly ITourStorage tourStorage;

        public MemoryTourStorageTests()
        {
            tourStorage = new MemoryTourStorage();
        }

        /// <summary>
        /// Добавление в хранилище
        /// </summary>
        [Fact]
        public async Task AddShouldReturnValue()
        {
            // Arrange
            var model = DataGenerator.CreateTour();

            // Act
            var result = await tourStorage.AddTourAsync(model);

            // Assert
            result.Should()
                .NotBeNull()
                .And.BeEquivalentTo(new
                {
                    model.Id,
                    model.Destination,
                });
        }

        /// <summary>
        /// Удаление из хранилища
        /// </summary>
        [Fact]
        public async Task DeleteShouldReturnTrue()
        {
            // Arrange
            var model = ChangeTypeTour.TourValidation(DataGenerator.CreateTour());

            // Act
            await tourStorage.AddTourAsync(model);
            var result = await tourStorage.DeleteTourAsync(model.Id);

            var tourList = await tourStorage.GetAllToursAsync();
            var tryGetModel = tourList.FirstOrDefault(x => x.Id == model.Id);

            // Assert
            result.Should().BeTrue();
            tryGetModel.Should().BeNull();
        }

        /// <summary>
        /// Изменение данных в хранилище
        /// </summary>
        [Fact]
        public async Task EditShouldUpdateStorageData()
        {
            // Arrange
            var model = ChangeTypeTour.TourValidation(DataGenerator.CreateTour());
            var newTour = new Tour
            {
                Id = Guid.NewGuid(),
                Destination = Destination.Spain,
                DepartureDate = DateTime.Now.AddDays(16),
                Nights = 3,
                PricePerPerson = 80000M,
                NumberOfPeople = 2,
                HasWiFi = true,
                AdditionalFees = 3000M
            };

            // Act
            await tourStorage.AddTourAsync(model);
            await tourStorage.EditTourAsync(model);
            var applicantList = await tourStorage.GetAllToursAsync();
            var result = applicantList.FirstOrDefault(x => x.Id == model.Id);

            // Assert
            result?.Should().NotBeNull();
            result?.Id.Should().Be(model.Id);
            result?.Destination.Should().Be(model.Destination);
        }

        /// <summary>
        /// Получает пустой список <see cref="ITourStorage.GetAllToursAsync"/>
        /// </summary>
        [Fact]
        public async Task GetAllShouldReturnEmpty()
        {
            // Act
            var result = await tourStorage.GetAllToursAsync();

            // Assert
            result.Should()
                .NotBeNull()
                .And.BeEmpty();
        }


        /// <summary>
        /// При пустом списке нет ошибок <see cref="ITourStorage.GetAllToursAsync"/>
        /// </summary>
        [Fact]
        public async Task GetAllShouldNotThrow()
        {
            // Act
            Func<Task> act = () => tourStorage.GetAllToursAsync();

            // Assert
            await act.Should().NotThrowAsync();
        }
    }
}
