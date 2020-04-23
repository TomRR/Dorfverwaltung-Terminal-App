using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.View
{
    interface IView
    {
        void EnterMenu(List<Model> data);
    }
}
