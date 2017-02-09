using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatForms
{
    class Defend : IAbilities
    {
        private bool m_active;
        private int m_mitigate;
        private int m_newdamage;
        private int m_olddamage;
        public Defend(bool act, int dmgreduc, int olddamage)
        {
            m_active = act;
            m_mitigate = dmgreduc;
            m_newdamage = olddamage - dmgreduc;
        }

        public int Mitigate
        {
            get { return m_mitigate; }
            set { m_mitigate = value; }
        }
        public bool Active
        {
            get { return m_active; }
            set { m_active = value; }
        }
        public void DoDamage(IDamagable a)
        {
            throw new NotImplementedException();
        }

        public void enemy()
        {
            throw new NotImplementedException();
        }

        public void self(Character a)
        {
            if (this.Active == true)
            {
              
            }
        }
    }
}
