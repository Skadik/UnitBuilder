namespace UnitBuilder.Arsenal.Armor
{
    public class Armor
    {
        public enum ArmorType
        {
            heavy,
            medium,
            light
        }


        private static int countId = 0;
        protected int id;
        protected ArmorType type;
        protected string name;
        protected int protection;

        public int getId() => id;
        public ArmorType geType() => type;
        public string getName() => name;
        public int getProtection() => protection;

        public Armor (ArmorType type, string name, int protection)
        {
            id = countId++;
            this.type = type;
            this.name = name;
            this.protection = protection;
        }
    }
}
