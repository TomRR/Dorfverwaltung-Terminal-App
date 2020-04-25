using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Tribe : Model
    {
        public int Id { get; set; }
        public string TribeName { get; set; }
        public string ExistSince { get; set; }
        public string TribeLeader { get; set; }
        public int IsLeaderSince { get; set; }
        public List<Dwarf> TribeMember { get; set; }
    }
}
