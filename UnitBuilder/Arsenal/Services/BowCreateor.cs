
using System;
using System.Collections.Generic;
using UnitBuilder.Arsenal.Services.BowComponnent;
using UnitBuilder.Arsenal.Weapon.Bow;
namespace UnitBuilder.Arsenal.Services
{
    public class BowCreateor 
    {
        Random rnd = new Random();
        List<BowHandle> bowHandles;
        List<BowString> bowStrings;
        public BowCreateor()
        {
            bowHandles = new List<BowHandle>()
            {
                new BowHandle(180,"володар"),
                new BowHandle(500,"тітанова"),
                new BowHandle(100,"вогнева"),
            };
            bowStrings = new List<BowString>() 
            {
                 new BowString(100,"тітєва"),
                new BowString(25,"дощ"),
                new BowString(10000,"світу"),
            };
        }

        public Bow randomCreate()
        {
            BowHandle bowHandle = bowHandles[rnd.Next(0, bowHandles.Count - 1)];
            BowString bowString = bowStrings[rnd.Next(0, bowStrings.Count - 1)];

            return new Bow(bowHandle.getName() + " " + bowString.getName(), (bowHandle.getDamage() + bowString.getDamage()) / 2);
        }

    }
}
