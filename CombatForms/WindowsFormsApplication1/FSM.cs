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

        public IGameManager currstate;
        public StartState startState;
        public IdleState idleState;
        public TurnUpState turnUpState;
        public BotActionState botActionState;
        public PlayerActionState playerActionState;
        public DedState dedState;
        public EndTurnState endTurnState;
        public QuitState quitState;
        public FSM()
        {
        }
        public void createStates()
        {
            startState = new StartState(this);
            idleState = new IdleState(this);
            turnUpState = new TurnUpState(this);
            botActionState = new BotActionState(this);
            playerActionState = new PlayerActionState(this);
            dedState = new DedState(this);
            endTurnState = new EndTurnState(this);
            quitState = new QuitState(this);
        }
        void start()
        {
            currstate = startState;
        }

        void Exit()
        {

        }
    }

    class StartState : IGameManager
    {
        public readonly FSM State;

        public StartState(FSM fsm)
        {
            State = fsm;
        }

        public void BotAction()
        {
            throw new NotImplementedException();
        }

        public void Dead()
        {
            throw new NotImplementedException();
        }

        public void EndTurn()
        {
            throw new NotImplementedException();
        }

        public void Idle()
        {
            State.currstate = State.idleState;   
        }

        public void PlayerAction()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void TurnUp()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    class IdleState : IGameManager
    {
        public readonly FSM State;
        public IdleState(FSM fsm)
        {
            State = fsm;
        }
        public void BotAction()
        {
            throw new NotImplementedException();
        }

        public void Dead()
        {
            State.currstate = State.dedState;
        }

        public void EndTurn()
        {
            throw new NotImplementedException();
        }

        public void Idle()
        {
            throw new NotImplementedException();
        }

        public void PlayerAction()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            State.currstate = State.quitState;
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void TurnUp()
        {
            State.currstate = State.turnUpState;
        }


    }
    class TurnUpState : IGameManager
    {
        public readonly FSM State;
        public TurnUpState(FSM fsm)
        {
            State = fsm;
        }
        public void BotAction()
        {
            State.currstate = State.botActionState;
        }

        public void Dead()
        {
            throw new NotImplementedException();
        }

        public void EndTurn()
        {
            throw new NotImplementedException();
        }

        public void Idle()
        {
            throw new NotImplementedException();
        }

        public void PlayerAction()
        {
            State.currstate = State.playerActionState;
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void TurnUp()
        {
            throw new NotImplementedException();
        }
    }
    class BotActionState : IGameManager
    {
        public readonly FSM State;
        public BotActionState(FSM fsm)
        {
            State = fsm;
        }
        public void BotAction()
        {
            throw new NotImplementedException();
        }

        public void Dead()
        {
            State.currstate = State.dedState;
        }

        public void EndTurn()
        {
            State.currstate = State.endTurnState;
        }

        public void Idle()
        {
            throw new NotImplementedException();
        }

        public void PlayerAction()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void TurnUp()
        {
            throw new NotImplementedException();
        }
    }
    class PlayerActionState : IGameManager
    {
        public readonly FSM State;
        public PlayerActionState(FSM fsm)
        {
            State = fsm;
        }
        public void BotAction()
        {
            throw new NotImplementedException();
        }

        public void Dead()
        {
            State.currstate = State.dedState;
        }

        public void EndTurn()
        {
            State.currstate = State.endTurnState;
        }

        public void Idle()
        {
            throw new NotImplementedException();
        }

        public void PlayerAction()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void TurnUp()
        {
            throw new NotImplementedException();
        }
    }
    class EndTurnState: IGameManager
    {
        public readonly FSM State;
        public EndTurnState(FSM fsm)
        {
            State = fsm;
        }
        public void BotAction()
        {
            throw new NotImplementedException();
        }

        public void Dead()
        {
            throw new NotImplementedException();
        }

        public void EndTurn()
        {
            throw new NotImplementedException();
        }

        public void Idle()
        {
            State.currstate = State.idleState;
        }

        public void PlayerAction()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void TurnUp()
        {
            throw new NotImplementedException();
        }
    }
    class DedState : IGameManager
    {
        public readonly FSM State;
        public DedState(FSM fsm)
        {
            State = fsm;
        }
        public void BotAction()
        {
            throw new NotImplementedException();
        }

        public void Dead()
        {
            throw new NotImplementedException();
        }

        public void EndTurn()
        {
            State.currstate = State.endTurnState;
        }

        public void Idle()
        {
            State.currstate = State.idleState;
        }

        public void PlayerAction()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void TurnUp()
        {
            throw new NotImplementedException();
        }
    }
    class QuitState : IGameManager
    {
        public readonly FSM State;
        public QuitState(FSM fsm)
        {
            State = fsm;
        }

        public void BotAction()
        {
            throw new NotImplementedException();
        }

        public void Dead()
        {
            throw new NotImplementedException();
        }

        public void EndTurn()
        {
            throw new NotImplementedException();
        }

        public void Idle()
        {
            throw new NotImplementedException();
        }

        public void PlayerAction()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void TurnUp()
        {
            throw new NotImplementedException();
        }
    }

}


