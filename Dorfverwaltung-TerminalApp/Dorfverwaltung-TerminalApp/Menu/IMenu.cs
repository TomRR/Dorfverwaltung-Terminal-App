using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.View
{
    interface IMenu
    {
        List<Model> EnterMenu(List<Model> data);
    }
}
