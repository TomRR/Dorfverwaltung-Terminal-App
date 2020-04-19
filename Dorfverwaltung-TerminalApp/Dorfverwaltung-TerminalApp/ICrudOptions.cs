using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public interface ICrudOptions : IMenu
    {
        void Add();
        void Update();
        void ShowDetail(List<Dwarf> dwarves);
        void Remove();
    }
}
