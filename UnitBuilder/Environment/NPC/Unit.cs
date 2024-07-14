using static System.Net.Mime.MediaTypeNames;

namespace UnitBuilder.Environment.NPC
{
    public class Unit
    {
        private int HP;
        private int damage;
        private int protection;
        private int moralityLvl;
        private string casta;
        private string arrmorType;
        private string weapon;
        private bool horse;

        public Unit()
        {
            HP = 1;
            damage = 1;
            protection = 1;
            moralityLvl = default;
            casta = default;
            arrmorType = default;
            weapon = default;
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

        public string getCasta() => casta;
        public void setCasta(string value)
        {
            casta = value;
        }

        public string getArrmor() => arrmorType;
        public void setArrmor(string type)
        {
            arrmorType = type;
        }

        public string getWeapon() => weapon;
        public void setWeapon(string type)
        {
            weapon = type;
        }

        public bool getHorse() => horse;
        public void setHorse(bool value)
        {
            horse = value;
        }
    }
}
