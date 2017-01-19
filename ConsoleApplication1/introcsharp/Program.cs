using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introcsharp
{




   
    class Entity
    {
        public Entity() { }
        public Entity(int h, int att)
        {}
        private int m_health;
        public int Health
        {
        get { return m_health; }
            set { m_health = value; }
        }
        private int m_attackpwr;
        public int AttackPwr
        {
            get { return m_attackpwr; }
            set { m_attackpwr = value;}
        }
        public virtual bool Attack(Entity thing)
        {
            thing.Health -= AttackPwr;
            
            return true;
        }
        private string m_name;
        public string Name
        {
            get { return m_name;}
            set { m_name = value;}
        }
    }
   
    class Zombie : Entity
    {
        public Zombie() { }
        public Zombie(int h, int att)
        {
            Health = h;
            AttackPwr = att;
        }
      public override bool Attack(Entity Player)
        {
            base.Attack(Player);
            Console.WriteLine("OMNOMNOMNOMNOM");
            return true;
        }
    }
    class Player : Entity
    {
        public Player() { }
        public Player(int h, int att)
        {
            Health = h;
            AttackPwr = att;
        }
        public override bool Attack(Entity Zombie)
        {
            base.Attack(Zombie);
            Console.WriteLine("durka durka mohammad jihad");
            
            return true;   
        }
        public bool Defend()
        {
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Zombie> zombies = new List<Zombie>();
            for (int i = 1; i <= 5; i++)
            {
                zombies.Add(new Zombie(100 % i, 10));
         
            }
            Player player = new Player(100, 50);

            foreach(var E in zombies)
            {
                player.Attack(E);
                E.Attack(player);
                if (E.Health <= 0)
                zombies.Remove(E);  
                if (player.Health <= 0)
                {
                    Console.WriteLine("GameOver");
                    break;
                }
                Console.WriteLine(player.Health + E.Health);

            }
            Console.ReadLine();
        }
  
    }
    }

