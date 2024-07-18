using System;
using System.Collections.Generic;
using UnitBuilder.Arsenal.Services.BowComponnent;
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
                new BowHandle(180,"крижаний"),
                new BowHandle(500,"білий"),
                new BowHandle(100,"горбатий"),
            };
            bowStrings = new List<BowString>() 
            {
                 new BowString(100,"болт"),
                new BowString(25,"вбивця"),
                new BowString(10000,"велетень"),
            };
        }

        public Weapon.Weapon randomCreate()
        {
            BowHandle bowHandle = bowHandles[rnd.Next(0, bowHandles.Count - 1)];
            BowString bowString = bowStrings[rnd.Next(0, bowStrings.Count - 1)];

            return new Weapon.Weapon(bowHandle.getName() + " " + bowString.getName(), (bowHandle.getDamage() + bowString.getDamage()) / 2);
        }

    }
}
