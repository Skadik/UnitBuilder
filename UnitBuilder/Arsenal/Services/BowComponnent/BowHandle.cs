namespace UnitBuilder.Arsenal.Services.BowComponnent
{
    public class BowHandle : Componnetn
    {
        public BowHandle(int damage, string name) : base(damage, name) 
        {
            this.damage = damage;
            this.name = name;
        }
    }
}
