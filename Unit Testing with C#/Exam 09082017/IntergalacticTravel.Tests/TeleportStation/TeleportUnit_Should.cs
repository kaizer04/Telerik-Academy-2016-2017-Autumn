using IntergalacticTravel.Contracts;
using IntergalacticTravel.Exceptions;
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
    public class TeleportUnit_Should
    {
        [Test]
        public void ThrowArgumentNullExceptionWithMessageContainsUnitToTeleport_WhenIUnitUnitToTeleportIsNull()
        {
            var ownerMock = new Mock<IBusinessOwner>();
            var galacticMapMock = new Mock<IEnumerable<IPath>>();
            var locationMock = new Mock<ILocation>();

            var teleportStationMock = new IntergalacticTravel.TeleportStation(ownerMock.Object, galacticMapMock.Object, locationMock.Object);

            //var unitToTeleportMock = new Mock<IUnit>();
            var targetLocationMock = new Mock<ILocation>();
            
            //Assert.Throws<ArgumentNullException>(() => teleportStationMock.TeleportUnit(null, locationMock.Object));
            var exc = Assert.Throws<ArgumentNullException>(
                () => teleportStationMock.TeleportUnit(null, targetLocationMock.Object));

            StringAssert.Contains("unitToTeleport", exc.Message);
        }

        [Test]
        public void ThrowArgumentNullExceptionWithMessageContainsDestination_WhenILocationDestinationIsNull()
        {
            var ownerMock = new Mock<IBusinessOwner>();
            var galacticMapMock = new Mock<IEnumerable<IPath>>();
            var locationMock = new Mock<ILocation>();

            var teleportStationMock = new IntergalacticTravel.TeleportStation(ownerMock.Object, galacticMapMock.Object, locationMock.Object);

            var unitToTeleportMock = new Mock<IUnit>();
            //var targetLocationMock = new Mock<ILocation>();

            //Assert.Throws<ArgumentNullException>(() => teleportStationMock.TeleportUnit(null, locationMock.Object));
            var exc = Assert.Throws<ArgumentNullException>(
                () => teleportStationMock.TeleportUnit(unitToTeleportMock.Object, null));

            StringAssert.Contains("destination", exc.Message);
        }

        [Test]
        public void ThrowTeleportOutOfRangeExceptionWithMessageContainsUnitToTeleportCurrentLocation_WhenUnitUseTeleportStationFromDistantLocation()
        {
            var ownerMock = new Mock<IBusinessOwner>();
            var galacticMapMock = new Mock<IEnumerable<IPath>>();
            var locationMock = new Mock<ILocation>();

            //var currPlanetMock = new Mock<IPlanet>();
            locationMock.SetupGet(x => x.Planet.Name).Returns("Planet One");
            locationMock.SetupGet(x => x.Planet.Galaxy.Name).Returns("Galaxy One");

            var teleportStationMock = new IntergalacticTravel.TeleportStation(ownerMock.Object, galacticMapMock.Object, locationMock.Object);

            var unitToTeleportMock = new Mock<IUnit>();
            unitToTeleportMock.SetupGet(x => x.CurrentLocation.Planet.Name).Returns("Planet two");
            unitToTeleportMock.SetupGet(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Galaxy two");
            
            var targetLocationMock = new Mock<ILocation>();
            
            //Assert.Throws<ArgumentNullException>(() => teleportStationMock.TeleportUnit(null, locationMock.Object));
            var exc = Assert.Throws<TeleportOutOfRangeException>(
                () => teleportStationMock.TeleportUnit(unitToTeleportMock.Object, targetLocationMock.Object));

            StringAssert.Contains("unitToTeleport.CurrentLocation", exc.Message);
        }

        [Test]
        public void ThrowInvalidTeleportationLocationExceptionWithMessageContainsUnitsWillOverlap_WhenTeleportUnitToLocationWhichAnotherUnitHasAlreadyTaken()
        {
            var ownerMock = new Mock<IBusinessOwner>();
            var locationMock = new Mock<ILocation>();

            var targetLocationMock = new Mock<ILocation>();
            var unitToTeleportMock = new Mock<IUnit>();

            var pathMock = new Mock<IPath>();
            pathMock.Setup(x => x.Cost.BronzeCoins).Returns(10);
            pathMock.Setup(x => x.Cost.SilverCoins).Returns(10);
            pathMock.Setup(x => x.Cost.GoldCoins).Returns(10);
            pathMock.Setup(x => x.TargetLocation.Planet.Name).Returns("Planet One");
            pathMock.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns("Galaxy One");

            var planetaryUnitMock = new Mock<IUnit>();
            planetaryUnitMock.Setup(x => x.CurrentLocation.Planet.Name).Returns("Planet One");
            planetaryUnitMock.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Galaxy One");
            planetaryUnitMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(50d);
            planetaryUnitMock.Setup(x => x.CurrentLocation.Coordinates.Longtitude).Returns(50d);

            var planetaryUnitsList = new List<IUnit> { planetaryUnitMock.Object };
            pathMock.Setup(x => x.TargetLocation.Planet.Units).Returns(planetaryUnitsList);

            var galacticMapMock = new List<IPath> { pathMock.Object };

            var teleportStationMock = new IntergalacticTravel.TeleportStation(ownerMock.Object, galacticMapMock, locationMock.Object);
          
            
            
            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Galaxy One");
            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Name).Returns("Planet One");
            unitToTeleportMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(50d);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(50d);
            
           
            targetLocationMock.Setup(x => x.Planet.Name).Returns("Planet One");
            targetLocationMock.Setup(x => x.Planet.Galaxy.Name).Returns("Galaxy One");
            targetLocationMock.Setup(x => x.Coordinates.Latitude).Returns(50d);
            targetLocationMock.Setup(x => x.Coordinates.Longtitude).Returns(50d);

            locationMock.SetupGet(x => x.Planet.Galaxy.Name).Returns("Galaxy One");
            locationMock.SetupGet(x => x.Planet.Name).Returns("Planet One");


            //Assert.Throws<ArgumentNullException>(() => teleportStationMock.TeleportUnit(null, locationMock.Object));
            var exc = Assert.Throws<InvalidTeleportationLocationException>(
                () => teleportStationMock.TeleportUnit(unitToTeleportMock.Object, targetLocationMock.Object));

            StringAssert.Contains("units will overlap", exc.Message);
        }

        [Test]
        public void ThrowInsufficientResourcesExceptionWithMessageContainsFREELUNCH_WhenTeleportUnitToLocationserviceButCostsMoreThanUnitCurrentAvailableResources()
        {
            var ownerMock = new Mock<IBusinessOwner>();
            var locationMock = new Mock<ILocation>();

            var targetLocationMock = new Mock<ILocation>();
            var unitToTeleportMock = new Mock<IUnit>();

            var pathMock = new Mock<IPath>();
            pathMock.Setup(x => x.Cost.BronzeCoins).Returns(10);
            pathMock.Setup(x => x.Cost.SilverCoins).Returns(10);
            pathMock.Setup(x => x.Cost.GoldCoins).Returns(10);
            pathMock.Setup(x => x.TargetLocation.Planet.Name).Returns("Planet One");
            pathMock.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns("Galaxy One");

            var planetaryUnitMock = new Mock<IUnit>();
            planetaryUnitMock.Setup(x => x.CurrentLocation.Planet.Name).Returns("Planet One");
            planetaryUnitMock.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Galaxy One");
            planetaryUnitMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(50d);
            planetaryUnitMock.Setup(x => x.CurrentLocation.Coordinates.Longtitude).Returns(50d);

            var planetaryUnitsList = new List<IUnit> { planetaryUnitMock.Object };
            pathMock.Setup(x => x.TargetLocation.Planet.Units).Returns(planetaryUnitsList);

            var galacticMapMock = new List<IPath> { pathMock.Object };

            var teleportStationMock = new IntergalacticTravel.TeleportStation(ownerMock.Object, galacticMapMock, locationMock.Object);



            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Galaxy One");
            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Name).Returns("Planet One");
            unitToTeleportMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(60d);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(60d);
            unitToTeleportMock.Setup(x => x.CanPay(It.IsAny<IResources>())).Returns(false);

            targetLocationMock.Setup(x => x.Planet.Name).Returns("Planet One");
            targetLocationMock.Setup(x => x.Planet.Galaxy.Name).Returns("Galaxy One");
            targetLocationMock.Setup(x => x.Coordinates.Latitude).Returns(60d);
            targetLocationMock.Setup(x => x.Coordinates.Longtitude).Returns(60d);

            locationMock.SetupGet(x => x.Planet.Galaxy.Name).Returns("Galaxy One");
            locationMock.SetupGet(x => x.Planet.Name).Returns("Planet One");


            //Assert.Throws<ArgumentNullException>(() => teleportStationMock.TeleportUnit(null, locationMock.Object));
            var exc = Assert.Throws<InsufficientResourcesException>(
                () => teleportStationMock.TeleportUnit(unitToTeleportMock.Object, targetLocationMock.Object));

            StringAssert.Contains("FREE LUNCH", exc.Message);
        }

        [Test]
        public void RequestPaymentFromTheUnitThatIsBeingTeleportedWithTheAmountOfPathCost_WhenTheValidationsPassSuccessfullyAndTheUnitsIsReadyForTeleportation()
        {
            var ownerMock = new Mock<IBusinessOwner>();
            var locationMock = new Mock<ILocation>();

            var targetLocationMock = new Mock<ILocation>();
            var unitToTeleportMock = new Mock<IUnit>();

            var pathMock = new Mock<IPath>();
            pathMock.Setup(x => x.Cost.BronzeCoins).Returns(10);
            pathMock.Setup(x => x.Cost.SilverCoins).Returns(10);
            pathMock.Setup(x => x.Cost.GoldCoins).Returns(10);
            pathMock.Setup(x => x.TargetLocation.Planet.Name).Returns("Planet One");
            pathMock.Setup(x => x.TargetLocation.Planet.Galaxy.Name).Returns("Galaxy One");

            var planetaryUnitMock = new Mock<IUnit>();
            planetaryUnitMock.Setup(x => x.CurrentLocation.Planet.Name).Returns("Planet One");
            planetaryUnitMock.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Galaxy One");
            planetaryUnitMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(50d);
            planetaryUnitMock.Setup(x => x.CurrentLocation.Coordinates.Longtitude).Returns(50d);

            var currentUnitLocationPlanetaryUnitsList = new List<IUnit> { unitToTeleportMock.Object };
            var planetaryUnitsList = new List<IUnit> { planetaryUnitMock.Object };
            pathMock.Setup(x => x.TargetLocation.Planet.Units).Returns(planetaryUnitsList);

            var galacticMapMock = new List<IPath> { pathMock.Object };

            var teleportStationMock = new IntergalacticTravel.TeleportStation(ownerMock.Object, galacticMapMock, locationMock.Object);



            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("Galaxy One");
            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Name).Returns("Planet One");
            unitToTeleportMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(60d);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Coordinates.Latitude).Returns(60d);
            unitToTeleportMock.Setup(x => x.CanPay(It.IsAny<IResources>())).Returns(true);
            unitToTeleportMock.Setup(x => x.Pay(pathMock.Object.Cost)).Returns(pathMock.Object.Cost);
            unitToTeleportMock.Setup(x => x.CurrentLocation.Planet.Units).Returns(currentUnitLocationPlanetaryUnitsList);

            targetLocationMock.Setup(x => x.Planet.Name).Returns("Planet One");
            targetLocationMock.Setup(x => x.Planet.Galaxy.Name).Returns("Galaxy One");
            targetLocationMock.Setup(x => x.Coordinates.Latitude).Returns(60d);
            targetLocationMock.Setup(x => x.Coordinates.Longtitude).Returns(60d);

            locationMock.SetupGet(x => x.Planet.Galaxy.Name).Returns("Galaxy One");
            locationMock.SetupGet(x => x.Planet.Name).Returns("Planet One");


            //Assert.Throws<ArgumentNullException>(() => teleportStationMock.TeleportUnit(null, locationMock.Object));
            teleportStationMock.TeleportUnit(unitToTeleportMock.Object, targetLocationMock.Object);

            unitToTeleportMock.Verify(x => x.Pay(pathMock.Object.Cost), Times.Once());
        }
    }
}
