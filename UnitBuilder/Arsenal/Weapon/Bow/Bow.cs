namespace UnitBuilder.Arsenal.Weapon.Bow
{
    public class Bow : Weapon
    {
        public Bow(string name, int damage) : base(name, damage)
        {
            setSLots(2);
            this.damage = damage;
            this.name = name;
        }
    }
}
