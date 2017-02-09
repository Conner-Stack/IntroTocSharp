using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatForms
{
    interface IAbilities: IDamager
    {
        void self(Character a);
        void enemy();


    }
}
