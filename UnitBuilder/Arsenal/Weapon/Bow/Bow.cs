namespace UnitBuilder.Arsenal.Weapon.Bow
{
    public class Bow : Weapon
    {
        public Bow(Weapon weapon) : base(weapon.getName(), weapon.getDamage())
        {
            setSLots(2);
            setName(weapon.getName());
            setDamage(weapon.getDamage());
        }
    }
}
