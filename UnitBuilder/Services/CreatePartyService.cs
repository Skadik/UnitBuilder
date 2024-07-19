using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitBuilder.Environment.NPC;
using UnitBuilder.Services.Factory;

namespace UnitBuilder.Services
{
    public class CreatePartyService
    {
        private List<Unit> units;
        public CreatePartyService()
        {
            units = new List<Unit>();
        }

        public void reInitParty()
        {
            units.Clear();
        }

        public List<Unit> createParty(IUnitFactory unitFactory, int count)
        {
            for (int i = 0; i < count; i++)
            {
                units.Add(unitFactory.create());
            }

            return units;   
        }
    }
}
