using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
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
    public class BattleManagerAddCreaturesTests
    {
        [Test]
        public void AddCreatures_WhenCreatureIdentifierIsNull_ShouldThrowArgumentNullException()
        {
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);
            
            Assert.Throws<ArgumentNullException>(() => battleManager.AddCreatures(null, 1));
        }

        [Test]
        public void AddCreatures_WhenValidIdentifierIsPassed_FactoryShouldCreateCreature()
        {
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);


            //var fixture = new Fixture();
           

            // Test For abstract class
            //fixture.Customizations.Add(
            //        new TypeRelay(
            //            typeof(Creature),
            //            typeof(Angel)));
            
            //var creature = fixture.Create<Angel>();
            var creature = new Angel();

            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            //var identifier = fixture.Create<CreatureIdentifier>();
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            battleManager.AddCreatures(identifier, 1);

            mockedFactory.Verify(x => x.CreateCreature(It.IsAny<string>()), Times.Exactly(1));
        }
        
        [Test]
        public void AddCreatures_WhenValidIdentifierIsPassed_WritelinShouldBeColled()
        {
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);


            //var fixture = new Fixture();


            // Test For abstract class
            //fixture.Customizations.Add(
            //        new TypeRelay(
            //            typeof(Creature),
            //            typeof(Angel)));

            //var creature = fixture.Create<Angel>();
            var creature = new Angel();

            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));

            //var identifier = fixture.Create<CreatureIdentifier>();
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            battleManager.AddCreatures(identifier, 1);

            mockedLogger.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Once);
        }
    }
}
