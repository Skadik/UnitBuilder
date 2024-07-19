using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitBuilder.Arsenal.Services;
using UnitBuilder.Arsenal.Sword;
using UnitBuilder.Environment.NPC;
using UnitBuilder.Services.UnitBuilder;

namespace UnitBuilder.Services.Factory
{
    public class CavaleryUnit : AbstractUnitFactory
    {
        public override Unit create()
        {
            return (new NewUnitBuilder())
               .createCavalry()
               .setHP(500)
               .setDamage(120)
               .setMoralytiLvl(80)
               .setProtection(120)
               .addWeapon((new SwordCreator()).randomCreate())
               .putOnArrmor(new Arsenal.Armor.Armor(Arsenal.Armor.Armor.ArmorType.heavy, "armor", 40))
               .getUnit();
        }
    }
}
