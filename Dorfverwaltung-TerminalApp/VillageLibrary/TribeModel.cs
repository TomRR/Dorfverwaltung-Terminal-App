using System;
using System.Collections.Generic;
using System.Text;

namespace VillageLibrary
{
    class TribeModel
    {
        public int Id { get; set; }
        public string TribeName { get; set; }
        public string ExistSince { get; set; }
        public string TribeLeader { get; set; }
        public int isLeaderSince { get; set; }
        public List<DwarfModel> TribeMember { get; set; }
    }
}
