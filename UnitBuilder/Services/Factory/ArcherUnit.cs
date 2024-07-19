using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitBuilder.Arsenal.Services;
using UnitBuilder.Environment.NPC;
using UnitBuilder.Services.UnitBuilder;

namespace UnitBuilder.Services.Factory
{
    public class ArcherUnit : AbstractUnitFactory
    {
        public override Unit create()
        {

            return (new NewUnitBuilder())
                .createArcher()
                .setHP(100)
                .setDamage(40)
                .setMoralytiLvl(30)
                .setProtection(20)
                .addWeapon((new BowCreateor()).randomCreate())
                .putOnArrmor(new Arsenal.Armor.Armor(Arsenal.Armor.Armor.ArmorType.light, "armor", 10))
                .getUnit();
        }
    }
}
