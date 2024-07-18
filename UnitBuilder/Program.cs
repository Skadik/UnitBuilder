using System;
using System.Collections.Generic;
using UnitBuilder.Arsenal.Armor;
using UnitBuilder.Arsenal.Services;
using UnitBuilder.Arsenal.Sword;
using UnitBuilder.Arsenal.Weapon;
using UnitBuilder.Arsenal.Weapon.Bow;
using UnitBuilder.Arsenal.Weapon.OneHandWeapon;
using UnitBuilder.Services.Json;

namespace UnitBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwordCreator creator = new SwordCreator();
            BowCreateor bowCreateor = new BowCreateor();
            Services.UnitBuilder.UnitBuilder unitBuilder = new Services.UnitBuilder.UnitBuilder();
            //JsonWeapons jsonWeapons = new JsonWeapons();
            //jsonWeapons.SaveObject(bowCreateor.randomCreate());
            //jsonWeapons.SaveObject(bowCreateor.randomCreate());
            //jsonWeapons.SaveObject(bowCreateor.randomCreate());
            //foreach (Weapon weapon in jsonWeapons.readAllObject())
            //{
            //    Console.WriteLine(weapon);
            //}
            unitBuilder
                 .setHP(1150)
                 .setDamage(1150)
                 .setCasts(Services.UnitBuilder.UnitBuilder.casta.cavalry)
                 .addWeapon(new Bow(bowCreateor.randomCreate()))
                 .addWeapon(new OneHandedWeapon(creator.randomCreate()))
                 .putOnArrmor(new Armor(Armor.ArmorType.heavy, "VeryBerry", 15))
                 .getUnit();
        }
    }
}
