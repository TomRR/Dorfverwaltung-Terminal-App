using Dorfverwaltung_TerminalApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public class Dwarf : IVillage
    {
        public int DwarfId { get; set; }
        public string DwarfName { get; set; }
        public int DwarfAge { get; set; }
        public string DwarfTitle { get; set; }
        public string DwarfTribe { get; set; }
        public List<Weapon> Inventory { get; set; }
        public int ForceFactor { get; set; }

        public void Ad

    }
}

