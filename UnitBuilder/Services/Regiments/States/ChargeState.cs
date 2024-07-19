using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitBuilder.Services.Regiments.States
{
    public class ChargeState : State
    {
        public override void handle()
        {
            // Логіка бою

            if (true) // якщо мораль нижче заданого показника
            {
                this.context.TransitionTo(new RetreatState());
            }

            if (true) // якщо ворогів не зосталось
            {
                this.context.TransitionTo(new RestState());
            }
        }
    }
}
