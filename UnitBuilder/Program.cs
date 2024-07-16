using UnitBuilder.Arsenal.Armor;
using UnitBuilder.Arsenal.Sword;
using UnitBuilder.Arsenal.Weapon.OneHandWeapon;
using UnitBuilder.Arsenal.Weapon.TwoHandedSword;
using static UnitBuilder.Arsenal.Armor.Armor;

namespace UnitBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwordCreator creator = new SwordCreator();
            Services.UnitBuilder.UnitBuilder unitBuilder = new Services.UnitBuilder.UnitBuilder();
            unitBuilder
                 .addWeapon(new OneHandedWeapon(creator.randomCreate()))
                 .addWeapon(new OneHandedWeapon(creator.randomCreate()))
                 .putOnArrmor(new Armor(ArmorType.heavy, "dd",15))
                 .getUnit();
        }
    }
}
