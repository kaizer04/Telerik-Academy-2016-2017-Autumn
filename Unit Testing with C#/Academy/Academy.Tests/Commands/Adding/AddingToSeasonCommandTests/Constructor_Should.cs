using Academy.Commands.Adding;
using Academy.Core.Contracts;
using Academy.Core.Factories;
using Academy.Tests.Commands.Adding.Mocks;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Commands.Adding.AddingToSeasonCommandTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenThePassedFactoryIsNull()
        {
            // Arrange
            var engineMock = new Mock<IEngine>();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(null, engineMock.Object));
        }

        [Test]
        public void ThrowArgumentNullException_WhenThePassedEngineIsNull()
        {
            // Arrange
            var factoryMock = new Mock<IAcademyFactory>();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(factoryMock.Object, null));
        }

        [Test]
        public void SetFactory_WhenThePassedFactoryIsNotNull()
        {
            // Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();

            // Act
            var command = new AddStudentToSeasonCommandMock(factoryMock.Object, engineMock.Object);

            // Assert
            Assert.AreSame(factoryMock.Object, command.AcademyFactory);
        }

        [Test]
        public void SetFactory_WhenThePassedEngineIsNotNull()
        {
            // Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();

            // Act
            var command = new AddStudentToSeasonCommandMock(factoryMock.Object, engineMock.Object);

            // Assert
            Assert.AreSame(engineMock.Object, command.Engine);
        }
    }
}
