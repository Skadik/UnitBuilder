using UnitBuilder.Arsenal.Services;

namespace UnitBuilder.Arsenal.SwordComponent
{
    public class Blade : Componnetn
    {
        public Blade(int damage, string name) : base(damage, name)
        {
            this.damage = damage;
            this.name = name;
        }
    }
}
