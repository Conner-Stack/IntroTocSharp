using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatForms
{
    class FireMagic : ICastable
    {
        private int m_damage;
        private int m_manacost;
        public int Damage
        {
            get { return m_damage; }
            set { m_damage = value; }
        }
        public int manaCost
        {
            get { return m_manacost; }
            set { m_manacost = value; }
        }

        FireMagic Firaga = new FireMagic(9001, 255);
        public FireMagic(int Dmg, int Mana)
        {
            m_damage = Dmg;
            m_manacost = Mana;
        }


        public void cast(IDamagable a)
        {
            this.DoDamage(a);
        }

        public void DoDamage(IDamagable a)
        {
            a.TakeDamage(this.Damage);
        }
    }
}
