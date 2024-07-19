using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitBuilder.Environment.NPC;
using UnitBuilder.Services.Factory;
using UnitBuilder.Services.Regiments.States;

namespace UnitBuilder.Environment
{
    public abstract class Regiment
    {
        public List<Unit> units = null;

        public State State = null;

        public Regiment(IUnitFactory factory, int count) 
        {
            State = new RestState();
            units = new List<Unit>();

            for (int i = 0; i < count; i++)
            {
                units.Add(factory.create());
            }
        }

        public void TransitionTo(State state)
        {
            this.State = state;
            this.State.setContext(this);
        }
    }
}
