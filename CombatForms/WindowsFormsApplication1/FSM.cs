using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combatForms
{
         public enum gameState
        {
            INIT = 0,
            Start= 1,
            Combat = 2,
            Dead = 3,
            Exit = 4,
        }
    
    public class FSM
    {
        public delegate void onEnter();
        public delegate void onExit();
        public FSM()
        {
            var a = Enum.GetValues(typeof(State));
            foreach(gameState state in a)
            {
                State s = new State(state);
                States.Add(s.stateName, s);
            }

        }
        public void changeState(State a)
        {
            string b = a.ToString();    
        }
        public State getState(string a)
        { 
            currentState = States[a];
            return currentState;
                }
        //Start -> Idle
        //Idle -> TurnUp
        //Idle -> Dead
        //TurnUp -> Idle
        // Dead -> Exit
        private State currentState; 

        Dictionary<string, State> States = new Dictionary<string, State>();

        
        public class State
        {
            private string m_name;

            public string stateName
            {
                get { return m_name; }
                set { m_name = value; }
            }
           public State(Enum a)
            {
                m_name = a.ToString();
            }
        }
    }
}