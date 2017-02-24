using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatForms
{
   public class Character : IDamagable, IDamager
    {
        private int m_health;
        private int m_basedamage;
        private string m_name;
        private bool m_alive;
        private bool m_dead;
        private float m_speed;
        public Character(int hp, int dmg, string name, bool alive, bool dead, float speed)
        {
            m_health = hp;
            m_basedamage = dmg;
            m_name = name;
            m_alive = alive;
            m_dead = dead;
            m_speed = speed;
        }
        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }
        public int Damage
        {
            get { return m_basedamage; }
            set { m_basedamage = value; }
        }
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public bool Alive
        {
            get { return m_alive; }
            set { m_alive = value; }
        }
        public bool Dead
        {
            get { return m_dead; }
            set { m_dead = value; }
        }
        public float Speed
        {
            get { return m_speed; }
            set { m_speed = value; }
        }
        public void DoDamage(IDamagable a)
        {
            a.TakeDamage(this.Damage);
        }
        public void TakeDamage(int dam)
        {
            this.Health -= dam;
            
        }
    }
}
