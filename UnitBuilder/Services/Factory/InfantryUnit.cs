using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitBuilder.Arsenal.Sword;
using UnitBuilder.Environment.NPC;
using UnitBuilder.Services.UnitBuilder;

namespace UnitBuilder.Services.Factory
{
    public class InfantryUnit : AbstractUnitFactory
    {
        public override Unit create()
        {
            return (new NewUnitBuilder())
                .createInfantry()
                .setHP(200)
                .setDamage(50)
                .setMoralytiLvl(50)
                .setProtection(50)
                .addWeapon((new SwordCreator()).randomCreate())
                .putOnArrmor(new Arsenal.Armor.Armor(Arsenal.Armor.Armor.ArmorType.heavy, "armor", 20))
                .getUnit();
        }
    }
}
