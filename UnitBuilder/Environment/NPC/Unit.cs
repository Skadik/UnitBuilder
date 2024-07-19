using UnitBuilder.Arsenal.Armor;
using UnitBuilder.Arsenal.Weapon;

namespace UnitBuilder.Environment.NPC
{
    //need aded
    //Fluent damage hp and protections 
    //Two hand for weapon hend = slots in weapon

    public class Unit 
    {
        public enum TypeUnit
        {
            hunting,
            cavalry,
            shooters
        }

        private int HP;
        private int damage;
        private int protection;
        private int moralityLvl;
        private TypeUnit casta;
        private Armor armor;
        private Weapon weaponSlot1;
        private Weapon weaponSlot2;
        private bool horse;

        public Unit()
        {
            HP = 1;
            damage = 1;
            protection = 1;
            moralityLvl = default;
            casta = default;
            armor = default;
            weaponSlot1 = default;
            weaponSlot2 = default;
            horse = default;
        }

        public int getHP() => HP;
        public void setHP(int value)
        {
            HP = value;
        }

        public int getDamage() => damage;
        public void setDamage(int value)
        {
            damage = value;
        }

        public int getProtection() => protection;
        public void setProtection(int value)
        {
            protection = value;
        }

        public int getMoralityLvl() => moralityLvl;
        public void setMoralityLvl(int value)
        {
            moralityLvl = value;
        }

        public TypeUnit getCasta() => casta;
        public void setCasta(TypeUnit value)
        {
            casta = value;
        }

        public Armor getArmor() => armor;
        public void setArmor(Armor armor)
        {
            this.armor = armor;
        }

        public Weapon getWeaponSlot1() => weaponSlot1;
        public void setWeaponSlot1(Weapon weaponSlot1)
        {
            this.weaponSlot1 = weaponSlot1;
        }

        public Weapon getWeaponSlot2() => weaponSlot2;
        public void setWeaponSlot2(Weapon weaponSlot2)
        {
            this.weaponSlot2 = weaponSlot2;
        }

        public bool getHorse() => horse;
        public void setHorse(bool value)
        {
            horse = value;
        }
    }
}
