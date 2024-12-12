using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitBuilder.Services.Regiments.States
{
    public class RestState : State
    {
        public override void handle()
        {
            // Логіка відпочинку

            if (true) // Команда на атаку
            {
                this.context.TransitionTo(new ChargeState());
            }
        }
    }
}
