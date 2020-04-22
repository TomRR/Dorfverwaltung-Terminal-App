using Dorfverwaltung_TerminalApp.Controller;
using System;
using System.Collections.Generic;
using System.Text;


namespace Dorfverwaltung_TerminalApp
{
    class DwarfController : BaseController
    {
        public BaseController Add(List<Dwarf> dwarves)
        {
            Console.WriteLine("Wie heisst der Zwerg:");
            string name = StringInput();
            Console.WriteLine("Wie alt ist er");
            int age = IntegerInput();
            Console.WriteLine("Falls er einen Title hat, gebe ihn ein");
            string title = StringInput();
            Console.WriteLine("zu welchen Tribe gehoert er. Elbknechte oder Altobarden");
            string tribe = StringInput();
            Dwarf newDwarf = new Dwarf()
            {
                DwarfId = dwarves.Count + 1,
                DwarfName = name,
                DwarfAge = age,
                DwarfTitle = title,
                DwarfTribe = tribe,
                Inventory = new List<Weapon>() { },
            };
            dwarves.Add(newDwarf);
            return ;
        }

        



        public List<Dwarf> Remove(List<Dwarf> dwarves)
        {
            Console.WriteLine("Welchen Zwerg moechtest du entfernen: gebe die Id ein");
            foreach (Dwarf dwarf in dwarves)
            {
                Console.WriteLine("(Id:{0}) {1}", dwarf.DwarfId, dwarf.DwarfName);
            }
            int id = IntegerInput() - 1;
            dwarves.RemoveAt(id);
            ShowDetail(dwarves);
            return dwarves;
        }

        public void ShowDetail(List<Dwarf> dwarves)
        {
            foreach (Dwarf dwarf in dwarves)
            {
                Console.WriteLine(
                "\n\tName: " + dwarf.DwarfId +
                "\n\tName: " + dwarf.DwarfName +
                "\n\tAge: " + dwarf.DwarfAge +
                "\n\tTitle: " + dwarf.DwarfTitle +
                "\n\tTribe: " + dwarf.DwarfTribe
                 );
            }
        }
    }
}
