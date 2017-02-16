using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public interface IDamager
    {
<<<<<<< HEAD
       void DoDamage(IDamagable a);
=======
       void Attack(IDamagable a,IAbility b);
        void Cast(IDamagable a, IAbility b);
>>>>>>> origin/master
    }
}
