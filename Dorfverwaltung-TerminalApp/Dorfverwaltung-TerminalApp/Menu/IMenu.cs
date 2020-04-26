using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.View
{
    interface IState
    {
        void EnterMenu(List<Model> data);
    }
}
