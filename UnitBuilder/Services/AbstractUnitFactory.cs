using UnitBuilder.Environment.NPC;
using UnitBuilder.Services.Factory;

namespace UnitBuilder.Services
{
    public abstract class AbstractUnitFactory : IUnitFactory
    {
        public abstract Unit create();
    }
}
