namespace UnitBuilder.Arsenal.Weapon.OneHandWeapon
{
    public class OneHandedWeapon : Weapon
    {

        public OneHandedWeapon(string name, int damage) : base(name, damage)
        {
            setSLots(1);
            this.damage = damage;
            this.name = name;
        }
    }
}
