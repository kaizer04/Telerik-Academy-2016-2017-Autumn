using System.Collections.Generic;
using IntergalacticTravel.Contracts;

namespace IntergalacticTravel.Test.Mocks
{
    public class TeleportStationMock : TeleportStation
    {
        public TeleportStationMock(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location)
            : base(owner, galacticMap, location)
        {
        }

        public IBusinessOwner Owner
        {
            get
            {
                return this.owner;
            }
        }

        public ILocation Location
        {
            get
            {
                return this.location;
            }
        }

        public IEnumerable<IPath> GalacticMap
        {
            get
            {
                return this.galacticMap;
            }
        }

        public IResources Resources
        {
            get
            {
                return this.resources;
            }
        }
    }
}
