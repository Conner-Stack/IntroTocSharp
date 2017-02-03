using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
<<<<<<< HEAD
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
=======

        class Ability : IAbility
        {
            private int m_manacost;
            private int m_damage;
            public Ability(int dmg, int mana)
            {
                m_damage = dmg;
                m_manacost = mana;
            }
            public int Damage
            { get { return m_damage; }
            set { m_damage = value; }
            }
            public int manaCost
            {
                get { return m_manacost; }
                set { m_manacost = value; }
            }
            public void cast(IDamagable a)
            {
                a.MagDamage(this.Damage);

            }
            public void LearnAbility(IDamager a)
            {
                
            }
        }







        class Ninja: IDamagable, IDamager
        {
            IAbility spell;
            private int m_health;
            private int m_damage;
            private int m_mana;
            public Ninja(int hp, int dmg, int mana)
            {
                m_health = hp;
                m_damage = dmg;
                m_mana = mana;
            }
            public int Mana
            { get { return m_mana; }
              set { m_mana = value; }
            }
            public int Health
            { get { return m_health; }
            set { m_health = value; }
            }
            public int Dmg
            {
                get { return m_damage; }
                set { m_damage = value; }
            }

            public void Damage(int value)
>>>>>>> origin/master
            {
                m_health = hp;
                m_damage = dam;
            }
            public void TakeDamage(int dam)
            {
                this.Health -= dam;
                Console.WriteLine(this.Health);
            }
<<<<<<< HEAD

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
=======
          public void Cast(IAbility a)
            {
                
            }
        
            public void Attack(IDamagable a)
            {
                
            }
            

        }
        class Zombie : IDamager, IDamagable
        {
            public IAbility regen;
            public IAbility acidvom;
            private int m_health;
            private int m_damage;
            public Zombie(int hp, int dmg)
            {
                m_health = hp;
                m_damage = dmg;
            }
            public void Damage( int value)
>>>>>>> origin/master
            {
                get { return m_damage; }
                set { m_damage = value; }
            }

<<<<<<< HEAD
            enum GameState
=======
            public void Rekt(IDamagable a, IAbility b)
>>>>>>> origin/master
            {
                INIT = 0,
                START =1,
                PAUSED = 2,
                EXIT = 3,
            }
<<<<<<< HEAD

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
=======

            public void cast(IAbility a)
            {
                throw new NotImplementedException();
            }

            public void LearnAbility(IAbility a)
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            Ninja Brian = new Ninja(100, 25, 500);
            
>>>>>>> origin/master
        }
    }
}
