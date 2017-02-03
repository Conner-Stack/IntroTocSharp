using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class Ninja : IDamagable, IDamager
        {
            //private IShootable gun;
            //public void PickUp(IShootable shooter)
            //{
            //    gun = shooter;
            //}
            //public void ShootGun()
            //{
            //    gun.Shoot();
            //}
            private int m_health;
            private int m_damage;
            public Ninja() { }
            public Ninja(int hp, int dam)
            {
                m_health = hp;
                m_damage = dam;
            }
            public void TakeDamage(int dam)
            {
                this.Health -= dam;
                Console.WriteLine(this.Health);
            }

            public void DoDamage(IDamagable a)
            {
                a.TakeDamage(Damage);
            }
            public int Health
            {
                get { return m_health; }
                set { m_health = value; }
            }
            public int Damage
            {
                get { return m_damage; }
                set { m_damage = value; }
            }

            enum GameState
            {
                INIT = 0,
                START =1,
                PAUSED = 2,
                EXIT = 3,
            }

            //0->1
            //1->2
            //1->3
            //2->1
            //2->3
            public class FSM
            {

                public FSM()
                {

                }

                public void AddTransition(int s1, int s2)
                {

                }
                List<Tuple<Enum, Enum>> transitions;
                public void AddTransition(Enum from, Enum to)
                {

                    transitions.Add(new Tuple<Enum, Enum>(from, to));

                }
            }

            class Zombie : IDamager, IDamagable
            {
                private FSM fsm;
                private int m_health;
                private int m_damage;
                public Zombie() { }
                public Zombie(int hp, int dam)
                {
                    //fsm.AddTransition()
                    m_health = hp;
                    m_damage = dam;
                }
                public void TakeDamage(int dam)
                {
                    this.Health -= dam;
                    Console.WriteLine(this.Health);
                }

                public void DoDamage(IDamagable a)
                {
                    a.TakeDamage(Damage);
                }

                public int Health
                {
                    get { return m_health; }
                    set { m_health = value; }
                }
                public int Damage
                {
                    get { return m_damage; }
                    set { m_damage = value; }

                }
                static void Main(string[] args)
                {
                    Ninja Brian = new Ninja(100, 25);
                    Zombie Shawn = new Zombie(100, 20);
                    //string input =
                    //    "";
                    //Brian.PickUp(new DefaultGun());
                    //while(input != "q")
                    //{
                    //    input = Console.ReadLine();
                        
                    //    if (input == "m")
                    //        Brian.PickUp(new MachineGun());
                    //    if (input == "r")
                    //        Brian.PickUp(new RocketLauncher(25));




                    //    Brian.ShootGun();
                    //}
                    
                }
            }
        }
    }
}
