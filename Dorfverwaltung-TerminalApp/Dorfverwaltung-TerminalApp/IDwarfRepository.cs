using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public interface IDwarfRepository : IRepository<Dwarf>
    {
        IEnumerable<Dwarf> GetDwarves(int id);

    }
}
