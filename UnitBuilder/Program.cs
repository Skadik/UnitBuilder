using System;

namespace UnitBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services.UnitBuilder.UnitBuilder unitBuilder = new Services.UnitBuilder.UnitBuilder();
            unitBuilder
            
                .getUnit();
        }
    }
}
