using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Tribe
    {
        public int Id { get; set; }
        public string TribeName { get; set; }
        public string ExistSince { get; set; }
        public Dwarf TribeLeader { get; set; }
        public int isLeaderSince { get; set; }
        public List<Dwarf> TribeMember { get; set; }
        public int TaxRate { get; set; }



        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void ShowDetail()
        {
            Console.WriteLine(
                "\n\tName: " + TribeName +
                "\n\tAge: " + ExistSince +
                "\n\tTitle: " + TribeLeader +
                "\n\tTribe: " 
                );
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        private void PrintTribeMember()
        {
            
        }

        public void EnterMenu()
        {
            throw new NotImplementedException();
        }
    }
}
