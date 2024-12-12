using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitBuilder.Environment.NPC;

namespace UnitBuilder.Services.Factory
{
    public interface IUnitFactory
    {
        Unit create();
    }
}
