using ArmyOfCreatures.Logic.Battles;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Tests
{
    [TestFixture]
    public class CreatureIdentifierTests
    {
        [Test]
        public void CreatureIdentifier_WhenNullValueIsPassed_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => CreatureIdentifier.CreatureIdentifierFromString(null));
        }

        //AncientBehemoth(1)
        [Test]
        public void CreatureIdentifier_WhenInvalidValueToParseIntIsPassed_ShouldThrowFormatException()
        {
            Assert.Throws<FormatException>(() => CreatureIdentifier.CreatureIdentifierFromString("Angel(test)"));
        }

        [Test]
        public void CreatureIdentifier_WhenInvalidValueIsPassed_ShouldThrowIndexOutOfRangeException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => CreatureIdentifier.CreatureIdentifierFromString("Angel"));
        }

        [Test]
        public void CreatureIdentifier_WhenValidValuePassed_ShouldReturnExpectedType()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.IsInstanceOf<CreatureIdentifier>(identifier);
        }


        [Test]
        public void CreatureIdentifier_WhenValidValuePassed_ShouldReturnExpectedCreatureType()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.AreEqual("Angel", identifier.CreatureType);
        }

        [Test]
        public void CreatureIdentifier_WhenValidValuePassed_ShouldReturnExpectedArmyNumber()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.AreEqual(1, identifier.ArmyNumber);
        }

        [Test]
        public void CreatureIdentifier_WhenValidValueIsPassed_ToStringShouldReturnExpectedString()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            var result = identifier.ToString();

            Assert.AreEqual("Angel(1)", result);
        }
    }
}
