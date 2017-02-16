using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatForms
{
    interface ICastable: IDamager
    {
        
        void cast(IDamagable a);
    }
}


