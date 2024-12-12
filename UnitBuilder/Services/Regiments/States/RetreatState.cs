using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitBuilder.Services.Regiments.States
{
    public class RetreatState : State
    {
        public override void handle()
        {
            // Логіка втечі

            if(true) // мораль піднялась вище мінімального значеня
            {
                // Зібратись в купу
                if (true) // Якщо є поруч вороги
                {
                    if (true) // Команда на атаку
                    {
                        this.context.TransitionTo(new ChargeState());
                    }
                    else
                    {
                        this.context.TransitionTo(new RestState());
                    }
                }    

            }   
        }
    }
}
