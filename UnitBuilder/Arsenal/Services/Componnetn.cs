
namespace UnitBuilder.Arsenal.Services
{
    public class Componnetn
    {
        protected int damage;
        protected string name;

        public Componnetn(int damage, string name)
        {
            this.damage = damage;
            this.name = name;
        }

        public int getDamage() => damage;
        public string getName() => name;
    }
}
