using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitBuilder.Services.Factory;

namespace UnitBuilder.Environment.Regiments
{
    public class InfantryRegiment : Regiment
    {
        public InfantryRegiment(int count = 200) : base(new InfantryUnit(), count)
        {
        }
    }
}
