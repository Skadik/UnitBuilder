using UnitBuilder.Arsenal.Armor;
using UnitBuilder.Arsenal.Weapon;
using UnitBuilder.Environment.NPC;
using static UnitBuilder.Environment.NPC.Unit;

namespace UnitBuilder.Services.UnitBuilder
{
    public class NewUnitBuilder
    {
        private Unit unit;
        public NewUnitBuilder() 
        {
            unit = new Unit();
        }

        public NewUnitBuilder reInitUnit() 
        {
            unit = new Unit();

            return this;
        }

        public NewUnitBuilder setHP(int value)
        {
            unit.setHP(value);
            return this;
        }

        public NewUnitBuilder setDamage(int value)
        {
            unit.setDamage(value);
            return this;
        }

        public NewUnitBuilder setProtection(int value)
        {
            unit.setProtection(value);
            return this;
        }

        public NewUnitBuilder setMoralytiLvl(int value)
        {
            unit.setMoralityLvl(value);
            return this;
        }

        public NewUnitBuilder createInfantry() 
        {
            unit.setCasta(TypeUnit.hunting);

            return this;
        }

        public NewUnitBuilder createCavalry() 
        {
            unit.setCasta(TypeUnit.cavalry);

            return this;
        }

        public NewUnitBuilder createArcher()
        {
            unit.setCasta(TypeUnit.shooters);

            return this;
        }

        private void setCasts(TypeUnit casta)
        {
            unit.setCasta(casta);
        }

        public NewUnitBuilder putOnArrmor(Armor armor)
        {
            if(armor != null || unit.getArmor() == null)
            {
                unit.setArmor(armor);
                unit.setProtection(unit.getProtection() + armor.getProtection());
            }
            return this;
        }


        public NewUnitBuilder addWeapon(Weapon weapon)
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
