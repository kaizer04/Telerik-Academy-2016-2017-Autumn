using IntergalacticTravel.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests.UnitsFactory
{
    [TestFixture]
    public class GetUnit_Should
    {
        [Test]
        public void ReturnNewProcyonUnit_WhenValidCorrespondingCommandIsPassed()
        {
            var command = "create unit Procyon Gosho 1";

            var unitsFactory = new IntergalacticTravel.UnitsFactory();

            var unit = unitsFactory.GetUnit(command);

            //Assert.AreEqual("Gosho", unit.NickName);
            //Assert.AreEqual(1, unit.IdentificationNumber);
            Assert.IsInstanceOf<Procyon>(unit);
        }

        [Test]
        [TestCase("create unit Pesho Gosho 1")]
        [TestCase("create unit Procyon Gosho")]
        public void ThrowInvalidUnitCreationCommandException_WhenCommandPassedIsNotValid(string command)
        {
            //var command = "create unit Pesho Gosho 1";

            var unitsFactory = new IntergalacticTravel.UnitsFactory();
            
            Assert.Throws<InvalidUnitCreationCommandException>(() => unitsFactory.GetUnit(command));
        }
    }
}
