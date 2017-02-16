using IntergalacticTravel.Contracts;
using IntergalacticTravel.Test.Mocks;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests.TeleportStation
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void SetAllFields_WhenTeleportStationIsCreatedWithValidParameters()
        {
            var ownerMock = new Mock<IBusinessOwner>();
            var galacticMapMock = new Mock<IEnumerable<IPath>>();
            var locationMock = new Mock<ILocation>(); 

            var teleportStationMock = new TeleportStationMock(ownerMock.Object, galacticMapMock.Object, locationMock.Object);

            Assert.AreSame(ownerMock.Object, teleportStationMock.Owner);
            Assert.AreSame(galacticMapMock.Object, teleportStationMock.GalacticMap);
            Assert.AreSame(locationMock.Object, teleportStationMock.Location);
        }
    }
}
