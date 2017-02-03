using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IGameManager
    {
        void Start();
        void Idle();
        void Update();
        void TurnUp();
        
        void Quit();
    }
}
