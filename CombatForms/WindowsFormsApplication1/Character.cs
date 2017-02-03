using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Character : IDamagable, IDamager, ILevelable
    {
        private int m_health;
        private int m_basedamage;
        public Character(int hp, int dmg)
        {
            m_health = hp;
            m_basedamage = dmg;
        }
        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }

        public void DoDamage(IDamagable a)
        {
            throw new NotImplementedException();
        }

        public void LevelUp(Character a)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int dam)
        {
            throw new NotImplementedException();
        }
    }
}
