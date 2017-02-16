using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Tests.MockedClasses;
using Moq;
using NUnit.Framework;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Tests
{
    [TestFixture]
    public class BattleManagerAttackTests
    {
        [Test]
        public void Attack_WhenAttackingCreatureIdentifierIsNull_ShouldThrowArgumentException()
        {
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.Throws<ArgumentException>(() => battleManager.Attack(identifier, identifier));
        }

        [Test]
        public void Attack_WhenDefenderCreatureIdentifierIsNull_ShouldThrowArgumentException()
        {
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Pesho(1)");

            Assert.Throws<ArgumentException>(() => battleManager.Attack(identifier, identifier));
        }

        [Test]
        public void Attack_WhenAttackIsSucessful_ShouldCallWriteline4Times()
        {
            // Arrange
            var mockedFactory = new Mock<CreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new MockedBattleManager(mockedFactory.Object, mockedLogger.Object);

            var identifierAttacker = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var identifierDefender = CreatureIdentifier.CreatureIdentifierFromString("Angel(2)");

            var creature = new Angel();

            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));

            battleManager.AddCreatures(identifierAttacker, 1);
            battleManager.AddCreatures(identifierDefender, 1);

            // Act
            battleManager.Attack(identifierAttacker, identifierDefender);

            mockedLogger.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(4));
        }

        [Test]
        public void Attack_WhenAttackingOwnArmy_ShouldThrowArgumentException()
        {
            // Arrange
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new MockedBattleManager(mockedFactory.Object, mockedLogger.Object);

            var identifierAttacker = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var identifierDefender = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            var creature = new Angel();

            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));

            battleManager.AddCreatures(identifierAttacker, 1);
            battleManager.AddCreatures(identifierDefender, 1);

            // Act and Assert
            Assert.Throws<ArgumentException>(() => battleManager.Attack(identifierAttacker, identifierDefender));
        }

        //[Test]
        //public void Attack_WhenAttacking_ShouldReturnExpectedHealthPoints()
        //{
        //    // Arrange
        //    var mockedFactory = new Mock<ICreaturesFactory>();
        //    var mockedLogger = new Mock<ILogger>();

        //    var battleManager = new MockedBattleManager(mockedFactory.Object, mockedLogger.Object);

        //    var identifierAttacker = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
        //    var identifierDefender = CreatureIdentifier.CreatureIdentifierFromString("Angel(2)");

        //    var creature = new Angel();

        //    mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

        //    mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));

        //    battleManager.AddCreatures(identifierAttacker, 1);
        //    battleManager.AddCreatures(identifierDefender, 1);

        //    // Act and Assert
        //    battleManager.Attack(identifierAttacker, identifierDefender);
        //    var defender = battleManager.SecondArmyOfCreatures.FirstOrDefault();

        //    Assert.AreEqual(150, defender.TotalHitPoints);
        //}
    }
}
