using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    interface IMenu
    {
        void EnterMenu(List<IKingdom> kingdomData);
    }
}
