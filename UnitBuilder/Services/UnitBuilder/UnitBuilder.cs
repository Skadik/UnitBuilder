using UnitBuilder.Arsenal.Armor;
using UnitBuilder.Arsenal.Weapon;
using UnitBuilder.Environment.NPC;

namespace UnitBuilder.Services.UnitBuilder
{
    public class UnitBuilder
    {
        public enum casta
        {
            hunting,
            cavalry,
            shooters,
            magicians
        }

        private Unit unit;
        public UnitBuilder() 
        {
            unit = new Unit();
        }

        public UnitBuilder setdHP(int value)
        {
            unit.setHP(value);
            return this;
        }

        public UnitBuilder setDamage(int value)
        {
            unit.setDamage(value);
            return this;
        }

        public UnitBuilder setProtection(int value)
        {
            unit.setProtection(value);
            return this;
        }

        public UnitBuilder setMoralytiLvl(int value)
        {
            unit.setMoralityLvl(value);
            return this;
        }

        public UnitBuilder setCasts(casta casta)
        {
            unit.setCasta(casta.ToString());
            return this;
        }

        public UnitBuilder putOnArrmor(Armor armor)
        {
            if(armor != null || unit.getArmor() == null)
            {
                unit.setArmor(armor);
                unit.setProtection(unit.getProtection() + armor.getProtection());
            }
            return this;
        }


        public UnitBuilder addWeapon(Weapon weapon)
        {
            if (unit.getWeaponSlot1() == default) //двуручка  або одноручка
            {
                unit.setWeaponSlot1(weapon);
            }
            else if (unit.getWeaponSlot1().getSlots() == 1) // тільки одноручка 
            {
                if (weapon.getSlots() == 1)
                {
                    unit.setWeaponSlot2(weapon);
                }
            }
            return this;
        }

        public Unit getUnit()
        {
            return unit;
        }
    }
}
