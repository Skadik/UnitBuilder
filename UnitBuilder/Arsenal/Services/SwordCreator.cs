using System;
using System.Collections.Generic;
using UnitBuilder.Arsenal.Services;
using UnitBuilder.Arsenal.SwordComponent;

namespace UnitBuilder.Arsenal.Sword
{
    public class SwordCreator
    {
        Random rnd = new Random();
        private List<Blade> blades;
        private List<Handle> handles;
        public SwordCreator()
        {
            blades = new List<Blade>()
            {
                new Blade(100,"Chaos"),
                new Blade(500,"Gods"),
                new Blade(110,"Light"),
                new Blade(250,"Dragon")
            };

            handles = new List<Handle>()
            {
                new Handle(100,"killer"),
                new Handle(500,"blood"),
                new Handle(110,"moon"),
                new Handle(250,"age"),
            };

        }

        public  Weapon.Weapon randomCreate()
        {
            Handle handl = handles[rnd.Next(0,handles.Count - 1)];
            Blade blade = blades[rnd.Next(0,blades.Count - 1)];

            return new Weapon.Weapon(handl.getName() + " " + blade.getName() , (handl.getDamage() + blade.getDamage())/2);
        }
    }
}
