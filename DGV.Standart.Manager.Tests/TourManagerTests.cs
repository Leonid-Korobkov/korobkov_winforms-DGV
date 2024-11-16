using System.Threading.Tasks;
using DGV.Standart.Contracts;
using FluentAssertions;
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

        /// <summary>
        /// Получение пустых данных из хранилища
        /// </summary>
        [Fact]
        public async Task GetAllAsyncShouldReturnEmpty()
        {
            // Arrange
            storageMock.Setup(x => x.GetAllToursAsync());

            // Act
            var result = await tourManager.GetAllToursAsync();

            // Assert
            result.Should().BeNull();

            storageMock.Verify(x => x.GetAllToursAsync(), Times.Once);
            storageMock.VerifyNoOtherCalls();

            loggerMock.VerifyNoOtherCalls();
        }

    }
}
