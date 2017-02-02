using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

       public class Ability : IAbility
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
            public int cast(IDamagable a)
            {
                a.MagDamage(this.Damage);

                
            }
            public void LearnAbility(IDamager a)
            {
                throw new NotImplementedException();
            }
        }







       public class Ninja: IDamagable, IDamager
        {
            
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
            {
                this.m_health -= value;
            }
          public void CastOn(Ability a)
            {
                
                this.spell.cast(a);
                this.Mana -= this.spell.cast(a);
                
            }
        
            public void Attack(IDamagable a)
            {
                
            }
            

        }
       public class Zombie : IDamager, IDamagable
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
            {
                this.m_health -= value;
            }

            public void Rekt(IDamagable a, IAbility b)
            {
                a.Damage(b);
            }

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
          
        }
    }
}
