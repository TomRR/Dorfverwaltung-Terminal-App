using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Tribe : IKingdom
    {
        public int Id { get; set; }
        public string TribeName { get; set; }
        public string ExistSince { get; set; }
        public string TribeLeader { get; set; }
        public int IsLeaderSince { get; set; }
        public List<Dwarf> TribeMember { get; set; }

        public IKingdom Add()
        {
            Console.WriteLine("Wie heisst der neue Tribe:");
            string tribeName = Console.ReadLine();
            Console.WriteLine("Seit wann existiert er");
            string existSince = Convert.ToInt32(Console.ReadLine()) + "apw";
            Console.WriteLine("Wie heisst sein Anfuehrer");
            string tribeLeader = Console.ReadLine();
            Console.WriteLine("Seit wann ist er der Anfuehrer/ Enter fuer keine Ahnung");
            int isLeaderSince = Convert.ToInt32(Console.ReadLine());

            Tribe newTribe = new Tribe()
            {
                TribeName = tribeName,
                ExistSince = existSince,
                TribeLeader = tribeLeader,
                IsLeaderSince = isLeaderSince,
            };
            return newTribe;
        }

        public void EnterMenu(List<IKingdom> kingdomData)
        {
            Console.WriteLine("Tribe");
        }

        public void PrintAll(List<IKingdom> kingdomData)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void ShowDetail(List<IKingdom> kingdomData)
        {
            throw new NotImplementedException();
        }
    }
}
