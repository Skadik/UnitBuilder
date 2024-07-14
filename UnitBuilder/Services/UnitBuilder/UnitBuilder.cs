using System.Dynamic;
using System.Runtime.Remoting.Messaging;
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

        public enum arrmorType
        {
            heavy,
            medium,
            light
        }

        public enum weaponType
        {
            sword,
            bow,
            axe,
            crossbow,
            staff,
            wand,
            twoHandedSword,
            dagger,
            shield
        }

        private Unit unit;
        public UnitBuilder() 
        {
            unit = new Unit();
        }

        public UnitBuilder buildHP(int value)
        {
            unit.setHP(value);
            return this;
        }

        public UnitBuilder buildDamage(int value)
        {
            unit.setDamage(value);
            return this;
        }

        public UnitBuilder buildProtection(int value)
        {
            unit.setProtection(value);
            return this;
        }

        public UnitBuilder buildMoralytiLvl(int value)
        {
            unit.setMoralityLvl(value);
            return this;
        }

        public UnitBuilder buildCasts(casta casta)
        {
            unit.setCasta(casta.ToString());
            return this;
        }

        public UnitBuilder buildArrmor(arrmorType arrmorType)
        {
            unit.setArrmor(arrmorType.ToString());
            return this;
        }

        public UnitBuilder buildSword(weaponType weaponType)
        {
            unit.setWeapon(weaponType.ToString());
            return this;
        }

        public Unit getUnit()
        {
            return unit;
        }
    }
}
