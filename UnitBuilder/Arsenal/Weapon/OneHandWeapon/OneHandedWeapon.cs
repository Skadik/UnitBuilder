namespace UnitBuilder.Arsenal.Weapon.OneHandWeapon
{
    public class OneHandedWeapon : Weapon
    {

        public OneHandedWeapon(Weapon weapon) : base(weapon.getName(), weapon.getDamage())
        {
            setSLots(1);
            setName(weapon.getName());
            setDamage(weapon.getDamage());
        }
    }
}
