using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Tests
{
    public class MockedBattleManager : BattleManager
    {
        private ICreaturesInBattle attacker;
        private ICreaturesInBattle defender;

        public MockedBattleManager(
            ICreaturesInBattle attacker,
            ICreaturesInBattle defender,
            ICreaturesFactory creaturesFactory,
            ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.attacker = attacker;
            this.defender = defender;
        }

        protected override ICreaturesInBattle GetByIdentifier(
            CreatureIdentifier identifier)
        {
            if (identifier.ArmyNumber == 1)
            {
                return this.attacker;
            }

            else if (identifier.ArmyNumber == 2)
            {
                return this.defender;
            }

            return null;
        }
    }
}
