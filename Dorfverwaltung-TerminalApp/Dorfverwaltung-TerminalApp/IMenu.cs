using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public interface IMenu
    {
        void EnterMenu(List<Dwarf> dwarves);
        void PrintAll();
    }
}
