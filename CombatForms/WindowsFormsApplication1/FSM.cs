using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{

    enum PlayerStates
    {
        init = 0,
        idle = 1,
        turnup = 2,
        defend = 3,
        dead = 4,
        Exit = 5,
    }

    enum GameState
    {
        INIT = 0,
        START = 1,
        PLAY = 2,
        EXIT = 3,
    }
    class Character
    {
        private bool dead = false;
        private int m_charspeed;
        private int m_damage;
        private int m_defense;
        private int m_health;
        public Character() { }
        public Character(int speed, int damage, int defense, int hp, bool ded)
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
        public void chartimerval(Timer T, Character C, ProgressBar P)
        {
            //the timer used between the Idle/defense and turnUp
            T.Interval = (T.Interval * P.Maximum) / C.charspeed;
            //if defense selected
            T.Interval = (T.Interval * P.Maximum) / (C.charspeed / 2);
        }
        public void damagereduc(Character a, Character b)
        {
            float reduc = 0;
            for (int i = 0; i < a.defense; i++)
            {
                reduc += .03f;
            }
            float incdam = b.damage - (b.damage * reduc);
        }
    }
    class State
    {
        public string name;
        public delegate void OnEnter();
        public delegate void OnExit();
        public OnEnter onEnter;
        public OnExit onExit;
        public void AddEnterFunction(Delegate d)
        {
            onEnter += d as OnEnter;
        }
        public State() { }
        public State(Enum e)
        {
            name = e.ToString();
        }
    }
    class FSM<T>
    {
        private Dictionary<string, List<State>> transition;
        private Dictionary<string, State> states;


        public FSM()
        {
            states = new Dictionary<string, State>();
            var v = Enum.GetValues(typeof(T));
            foreach (var s in v)
            {

                State newstate = new State((Enum)s);
                states.Add(newstate.name, newstate);
            }
        }


        public State getState(T e)
        {
            string key = (e as State).name;
            return states[key];
        }


            State currstate;
            public void changeState(State state)
        {
            currstate.onExit();
            currstate = state;
            currstate.onEnter();
        }


        private bool ValidTrans(State next)
        {
            var currentstate = transition[currstate.name];
            if (states[currstate.name] == null)
            {
                return false; 
            }

        }
        
        
     
        }
    }

