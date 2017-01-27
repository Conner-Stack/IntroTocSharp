using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class Ninja: IDamagable, IDamager
        {
            private int m_health;
            private int m_damage;
            public void Damage(int value)
            {
                this.m_health -= value;
            }

            public void Rekt(IDamagable a, int b)
            {
               a.Damage(b); 
            }
        }
        class zombie : IDamager, IDamagable
        {
            private int m_health;
            private int m_damage;
            public void Damage( int value)
            {
                this.m_health -= value;
            }

            public void Rekt(IDamagable a, int b)
            {
                a.Damage(b);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
