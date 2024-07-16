namespace UnitBuilder.Arsenal.SwordComponent
{
    public class Blade
    {
        protected int damage;
        protected string name;

        public Blade(int damage,string name)
        {
            this.damage = damage;
            this.name = name;
        }
        public int getDamage() => damage;
        public string getName() => name;
    }
}
