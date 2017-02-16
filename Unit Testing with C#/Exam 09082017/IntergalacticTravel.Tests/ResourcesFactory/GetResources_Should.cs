using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests.ResourcesFactory
{
    [TestFixture]
    public class GetResources_Should
    {
        [Test]
        public void ReturnNewlyCreatedResources_WithCorrectlySetProperties()
        {
            var resourcesParameters = new IntergalacticTravel.ResourcesFactory();

            var command = "create resources gold(20) silver(30) bronze(40)";

            Assert.AreEqual(20, resourcesParameters.GetResources(command).GoldCoins);
            Assert.AreEqual(30, resourcesParameters.GetResources(command).SilverCoins);
            Assert.AreEqual(40, resourcesParameters.GetResources(command).BronzeCoins);
        }

        [Test]
        public void ThrowInvalidOperationExceptionWhichContainsCommand_WhenInputStringRepresentsInvalidCommand()
        {
            var resourcesParameters = new IntergalacticTravel.ResourcesFactory();

            var command = "tansta resources a b";

            Assert.Throws<InvalidOperationException>(() => resourcesParameters.GetResources(command));
        }

        [Test]
        public void ThrowOverflowException_WhenCommandIsInCorrectFormat_ButAnyValuesOfResourceAmountIsLargerThanUintMaxValue()
        {
            var resourcesParameters = new IntergalacticTravel.ResourcesFactory();

            var command = "create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)";

            Assert.Throws<OverflowException>(() => resourcesParameters.GetResources(command));
        }
    }
}
