using ArmyOfCreatures.Extended;
using ArmyOfCreatures.Logic;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests
{
    [TestFixture]
    public class CreaturesFactoryTests
    {
        [TestCase("Angel")]
        [TestCase("Archangel")]
        [TestCase("ArchDevil")]
        [TestCase("Behemoth")]
        [TestCase("Devil")]
        public void CreaturesFactory_WhenValidNameIsPassed_ShouldReturnExpectedType(string name)
        {
            //var factory = new CreaturesFactory();
            var factory = new ExtendedCreaturesFactory();

            var creature = factory.CreateCreature(name);

            Assert.AreEqual(name, creature.GetType().Name);
        }

        [Test]
        public void CreaturesFactory_WhenInvalidNameIsPassed_ShouldThrowArgumentException()
        {
            //var factory = new CreaturesFactory();
            var factory = new ExtendedCreaturesFactory();
            
            Assert.Throws<ArgumentException>(() => factory.CreateCreature("Gosho"));
        }
        
        [Test]
        public void CreaturesFactory_WhenInvalidNameIsPassed_ShouldThrowArgumentExceptionWithExpectedMessage()
        {
            //var factory = new CreaturesFactory();
            var factory = new ExtendedCreaturesFactory();

            try
            {
                factory.CreateCreature("Gosho");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual($"Invalid creature type \"Gosho\"!", ex.Message);
            }
        }
    }
}
