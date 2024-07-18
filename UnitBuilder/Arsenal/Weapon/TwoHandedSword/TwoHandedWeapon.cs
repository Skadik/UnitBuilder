namespace UnitBuilder.Arsenal.Weapon.TwoHandedSword
{
    public class TwoHandedWeapon : Weapon
    {
        public TwoHandedWeapon(string name, int damage) : base(name, damage)
        {
            setSLots(2);
            this.damage = damage;
            this.name = name;
        }
    }
}
