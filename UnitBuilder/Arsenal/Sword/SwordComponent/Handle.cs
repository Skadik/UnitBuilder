namespace UnitBuilder.Arsenal.SwordComponent
{
    public class Handle
    {
        private int damage;
        private string name;

        public Handle(int damage, string name)
        {
            this.damage = damage;
            this.name = name;
        }

        public int getDamage() => damage;
        public string getName() => name;
    }
} 
  
  