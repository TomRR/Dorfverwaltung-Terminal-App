using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public interface ICrudOptions : IMenu
    {
        List<Dwarf> Add(List<Dwarf> dwarves);
        //void Update(List<Dwarf> dwarves);
        void ShowDetail(List<Dwarf> dwarves);
        List<Dwarf> Remove(List<Dwarf> dwarves);
    }
}
