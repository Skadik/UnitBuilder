using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitBuilder.Environment;

namespace UnitBuilder.Services.Regiments.States
{
    public abstract class State
    {
        protected Regiment context = null;
        public void setContext(Regiment context)
        {
            this.context = context;
        }

        public abstract void handle();
    }
}
