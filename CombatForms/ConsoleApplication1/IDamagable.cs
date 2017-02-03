using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public interface IDamagable
    {
       void TakeDamage( int dam);
    }

    public interface IShootable
    {
        void Shoot();
    }

    class RocketLauncher : IShootable
    {
        public RocketLauncher(int num)
        {
            damage = num;
        }
        int damage;
        public void Shoot()
        {

            Console.WriteLine("SHOOT MISSLES EXPLOSIONS!!!!" + damage);
        }
    }

    class MachineGun : IShootable
    {
        public MachineGun()
        {

        }
        public void Shoot()
        {
            Console.WriteLine("RattaTatTat");
        }
    }

    class DefaultGun : IShootable
    {
        public DefaultGun()
        { }
        public void Shoot()
        {
            Console.WriteLine("pew pew");
        }

    }
}
