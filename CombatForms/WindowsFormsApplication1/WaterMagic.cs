using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class WaterMagic : ICastable
    {
        private int m_Damage;
        private int m_manacost;
        public int Damage
        {
            get { return m_Damage; }
            set { m_Damage = value; }
        }
        public int manaCost
        {
            get { return m_manacost; }
            set { m_manacost = value; }
        }

        WaterMagic Blizzara = new WaterMagic(45, 73);
        
        public WaterMagic(int Dmg, int Mana)
        {
            m_Damage = Dmg;
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
