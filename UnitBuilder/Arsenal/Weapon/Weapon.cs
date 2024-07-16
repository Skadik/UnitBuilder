namespace UnitBuilder.Arsenal.Weapon
{
    public class Weapon
    {
        private static int countId;
        protected int id;
        protected string name;
        protected int damage;
        protected int slots;
       
        public int getID() => id;

        public string getName() => name;
        public void setName(string name)
        {
            this.name = name;
        }

        public int getDamage() => damage;
        public void setDamage(int damage)
        {
            this.damage = damage;
        }

        public int getSlots() => slots;
        public void setSLots(int slots)
        {
            this.slots = slots;
        } 
       
        public Weapon(string name,int damage)
        {
            this.name = name;
            this.damage = damage;
            id = countId++;
        }
    }
}
