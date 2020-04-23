using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
        class Dwarf  : Model
        {
            public int DwarfId { get; set; }
            public string DwarfName { get; set; }
            public int DwarfAge { get; set; }
            public string DwarfTitle { get; set; }
            public string DwarfTribe { get; set; }
            public List<Weapon> Inventory { get; set; }
    }
}
