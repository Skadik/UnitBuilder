namespace UnitBuilder.Arsenal.Weapon.TwoHandedSword
{
    public class TwoHandedWeapon : Weapon
    {
        public TwoHandedWeapon(Weapon weapon) : base(weapon.getName(), weapon.getDamage())
        {
            setSLots(2);
            setName(weapon.getName());
            setDamage(weapon.getDamage());
        }
    }
}
