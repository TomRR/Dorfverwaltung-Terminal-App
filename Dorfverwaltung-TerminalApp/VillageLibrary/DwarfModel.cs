using System;
using System.Collections.Generic;
using System.Text;

namespace VillageLibrary
{
    class DwarfModel
    {
        public int DwarfId { get; set; }
        public string DwarfName { get; set; }
        public int DwarfAge { get; set; }
        public string DwarfTitle { get; set; }
        public string DwarfTribe { get; set; }
        public List<WeaponModel> Inventory { get; set; }
        public int ForceFactor { get; set; }
    }
}
