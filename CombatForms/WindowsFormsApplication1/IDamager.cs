using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatForms
{
   public interface IDamager 
    {
       void DoDamage(IDamagable a);
    }
}
