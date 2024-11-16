using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DGV.Standart.Contracts;
using DGV.Standart.Contracts.Models;
using FluentAssertions;
using korobkov_winforms_DGV;
using korobkov_winforms_DGV.Classes;
using korobkov_winforms_DGV.Models;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;


namespace DGV.Standart.Manager.Tests
{
    /// <summary>Тесты для <see cref="TourManager"/></summary>
    public class TourManagerTests
    {
        private readonly ITourManager tourManager;
        private readonly Mock<ITourStorage> storageMock;
        private readonly Mock<ILogger> loggerMock;

        public TourManagerTests()
        {
            storageMock = new Mock<ITourStorage>();
            loggerMock = new Mock<ILogger>();

            loggerMock.Setup(x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()));

            tourManager = new TourManager(storageMock.Object, loggerMock.Object);
        }

        /// <summary>
        /// Добавление в хранилище
        /// </summary>
        [Fact]
        public async Task AddShouldWork()
        {
            // Arrange
            var model = ChangeTypeTour.TourValidation(DataGenerator.CreateTour());

            storageMock.Setup(x => x.AddTourAsync(It.IsAny<Tour>()))
                .ReturnsAsync(model);

            // Act
            var result = await tourManager.AddTourAsync(model);

            // Asset
            result.Should().NotBeNull()
                .And.Be(model);

            loggerMock.Verify(
                x => x.Log
                (LogLevel.Information,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((state, t) => state.ToString().Contains(nameof(ITourManager.AddTourAsync))),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);
            loggerMock.VerifyNoOtherCalls();

            storageMock.Verify(
                x => x.AddTourAsync(It.Is<Tour>(y => y.Id == model.Id)),
                Times.Once);

            storageMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// Изменение данных в хранилище
        /// </summary>
        [Fact]
        public async Task EditShouldWork()
        {
            // Arrange
            var model = ChangeTypeTour.TourValidation(DataGenerator.CreateTour());
            storageMock.Setup(x => x.EditTourAsync(It.IsAny<Tour>())).Returns(Task.CompletedTask);

            // Act
            await tourManager.EditTourAsync(model);

            // Asset
            loggerMock.Verify(x => x.Log
                (LogLevel.Information,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((state, t) => state.ToString().Contains(nameof(ITourManager.EditTourAsync))),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);
            loggerMock.VerifyNoOtherCalls();

            storageMock.Verify(
                x => x.EditTourAsync(It.Is<Tour>(y => y.Id == model.Id)),
                Times.Once);
            storageMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// Удаление из хранилища
        /// </summary>
        [Fact]
        public async Task DeleteShouldWork()
        {
            // Arrange
            var model = ChangeTypeTour.TourValidation(DataGenerator.CreateTour());
            storageMock.Setup(x => x.DeleteTourAsync(model.Id))
                .ReturnsAsync(true);

            // Act
            var result = await tourManager.DeleteTourAsync(model.Id);

            // Asset
            result.Should().BeTrue();

            loggerMock.Verify(x => x.Log
                (LogLevel.Information,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((state, t) => state.ToString().Contains(nameof(ITourManager.DeleteTourAsync))),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);
            loggerMock.VerifyNoOtherCalls();

            storageMock.Verify(x => x.DeleteTourAsync(model.Id),
                Times.Once);
            storageMock.VerifyNoOtherCalls();

        }

        /// <summary>
        /// Получение пустых данных из хранилища
        /// </summary>
        [Fact]
        public async Task GetAllShouldReturnNull()
        {
            // Arrange
            storageMock.Setup(x => x.GetAllToursAsync())
                       .ReturnsAsync(new List<Tour>().AsReadOnly());

            // Act
            var result = await tourManager.GetAllToursAsync();

            // Assert
            result.Should().BeNull();

            storageMock.Verify(x => x.GetAllToursAsync(), Times.Once);
            storageMock.VerifyNoOtherCalls();

            loggerMock.Verify(
                x => x.Log(
                    LogLevel.Information,
                    It.IsAny<EventId>(),
                    It.Is<It.IsAnyType>((state, t) => state.ToString().Contains("Операция")),
                    null,
                    It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);
            loggerMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// Тест: Метод <see cref="ApplicantManager.GetAllAsync"/>
        /// </summary>
        [Fact]
        public async Task GetAllShouldWorkWith2Tours()
        {
            // Arrange
            var tourList = new List<Tour>
                {
                    ChangeTypeTour.TourValidation(DataGenerator.CreateTour()),
                    ChangeTypeTour.TourValidation(DataGenerator.CreateTour(x => { x.PricePerPerson = 2000; x.Nights = 2; }))
                };
            storageMock.Setup(x => x.GetAllToursAsync())
                .ReturnsAsync(tourList);

            // Act
            var result = await tourManager.GetAllToursAsync();

            // Assert
            result.Should().NotBeNull()
                .And.HaveCount(tourList.Count)
                .And.BeEquivalentTo(tourList);

            storageMock.Verify(x => x.GetAllToursAsync(), Times.Once);
            storageMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// Тест: Метод <see cref="ApplicantManager.GetStatsAsync"/>
        /// </summary>
        [Fact]
        public async Task GetStatsShouldWork()
        {
            // Arrange
            var tourList = new List<Tour>
                {
                    ChangeTypeTour.TourValidation(DataGenerator.CreateTour()),
                    ChangeTypeTour.TourValidation(DataGenerator.CreateTour(x => { x.PricePerPerson = 2000; x.Nights = 2; x.AdditionalFees = 0;}))
                };
            storageMock.Setup(x => x.GetAllToursAsync())
                .ReturnsAsync(tourList);

            // Act
            var result = await tourManager.GetStatsAsync();

            // Assert
            result.Should().NotBeNull();
            result.TotalCountTours.Should().Be(tourList.Count);
            result.CountToursWithDop.Should().Be(1);
            result.TotalSumTours.Should().Be(164000);
            result.TotalSumDop.Should().Be(3000);

            storageMock.Verify(x => x.GetAllToursAsync(), Times.Once);
            storageMock.VerifyNoOtherCalls();
        }
    }
}
