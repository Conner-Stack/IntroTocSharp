using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IAbilities: IDamager
    {
        void self(Character a);
        void enemy();


    }
}
