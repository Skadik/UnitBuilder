using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitBuilder.Services.Factory;

namespace UnitBuilder.Environment.Regiments
{
    public class ArcherRegiment : Regiment
    {
        public ArcherRegiment(int count = 60) : base(new ArcherUnit(), count)
        {
        }
    }
}
