﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IDamager
    {
       void Attack(IDamagable a,IAbility b);
        void Cast(IDamagable a, IAbility b);
    }
}
