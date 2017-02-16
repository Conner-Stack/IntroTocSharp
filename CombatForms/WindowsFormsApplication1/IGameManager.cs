using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatForms
{
    interface IGameManager
    {
        void Start();
        void Idle();
        void TurnUp();
        void BotAction();
        void PlayerAction();
        void Dead();
        void EndTurn();        
        void Quit();
    }
}

