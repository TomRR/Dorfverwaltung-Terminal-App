using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Weapon : Model
    {
        public int Id { get; set; }
        public string WeaponName { get; set; }
        public string WeaponType { get; set; }
        public int MagicalValue { get; set; }
        public string Description { get; set; }
        public string OwnerId { get; set; }
    }
}
