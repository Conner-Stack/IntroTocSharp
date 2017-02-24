using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatForms
{
    interface ICastable
    {
        
        void cast(IDamagable a, int manacost);
    }
}


