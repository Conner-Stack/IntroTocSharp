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

    class State: IGameManager
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

