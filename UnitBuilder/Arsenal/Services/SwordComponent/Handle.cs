using UnitBuilder.Arsenal.Services;

namespace UnitBuilder.Arsenal.SwordComponent
{
    public class Handle : Componnetn
    {
        public Handle(int damage, string name) : base(damage, name)
        {
            this.damage = damage;
            this.name = name;
        }
    }
} 
  
  