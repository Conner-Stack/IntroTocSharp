using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class PlayerParty
    {
            private bool dead = false;
            private int m_charspeed;
            private int m_damage;
            private int m_defense;
            private int m_health;
            public PlayerParty() { }
            public PlayerParty(int speed, int damage, int defense, int hp, bool ded)
            {

                m_charspeed = speed;
                m_damage = damage;
                m_defense = defense;
                m_health = hp;
                dead = ded;
            }
            public int charspeed
            {
                get { return m_charspeed; }
                set { charspeed = value; }
            }
            public int damage
            {
                get { return m_damage; }
                set { damage = value; }
            }
            public int defense
            {
                get { return m_defense; }
                set { defense = value; }
            }
            public int health
            {
                get { return m_health; }
                set { health = value; }
            }
            public bool isDead
            {
                get { return dead; }
                set { isDead = value; }
            }
            public void chartimerval(Timer T, PlayerParty C, ProgressBar P)
            {
                //the timer used between the Idle/defense and turnUp
                T.Interval = (T.Interval * P.Maximum) / C.charspeed;
                //if defense selected
                T.Interval = (T.Interval * P.Maximum) / (C.charspeed / 2);
            }
            public void damagereduc(PlayerParty a, PlayerParty b)
            {
                float reduc = 0;
                for (int i = 0; i < a.defense; i++)
                {
                    reduc += .03f;
                }
                float incdam = b.damage - (b.damage * reduc);
            }
        }
    }
}
