using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combatForms
{

    class FSM
    {
        public State Current;

        public List<State> States = new List<State>();

        public void addState(string a)
        {
            State b = new State(a);
            States.Add(b);
        }

        public void changeState(State a)
        {

            Current = a;
        }
        
        public class State
        {
            private string m_name;

            public string Name
            {
                get { return m_name; }
                set { m_name = value; }
            }
           public State(string name)
            {
                m_name = name;
            }
        }
    }
}