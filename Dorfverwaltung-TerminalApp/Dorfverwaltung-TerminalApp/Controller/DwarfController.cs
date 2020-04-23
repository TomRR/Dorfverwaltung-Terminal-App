using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class DwarfController : Controller
    {
        private Dwarf dwarf = new Dwarf();


        public override Model AddModel()
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
                DwarfId = 1,
                DwarfName = name,
                DwarfAge = age,
                DwarfTitle = title,
                DwarfTribe = tribe,
                Inventory = new List<Weapon>() { },
            };
            return newDwarf;
        }



        public void PrintAll(List<Model> kingdomData)
        {
            foreach (Model kingdom in kingdomData)
            {
                if (kingdom is Dwarf dwarf)
                {
                    Console.WriteLine(
                    "\n\tId: " + dwarf.DwarfId +
                    "\n\tName: " + dwarf.DwarfName +
                    "\n\tAge: " + dwarf.DwarfAge +
                    "\n\tTitle: " + dwarf.DwarfTitle +
                    "\n\tTribe: " + dwarf.DwarfTribe
                     );
                }
            }
        }

        public override void Remove(List<Model> kingdomData)
        {
            //    //Console.WriteLine("Welchen Zwerg moechtest du entfernen: gebe die Id ein");
            //    //foreach (Dwarf dwarf in dwarves)
            //    //{
            //    //    Console.WriteLine("(Id:{0}) {1}", dwarf.DwarfId, dwarf.DwarfName);
            //    //}
            //    //int id = IntegerInput() - 1;
            //    //dwarves.RemoveAt(id);
            //    //ShowDetail(dwarves);
        }

        public override void ShowDetail(List<Model> kingdomData)
        {
            foreach (Model kingdom in kingdomData)
            {
                if (kingdom is Dwarf dwarf)
                {
                    Console.WriteLine("welchen Zwerg suchst du?");
                    string name = Console.ReadLine().ToLower();
                    if (name == dwarf.DwarfName.ToLower())
                    {
                        Console.WriteLine(
                        "\n\tId: " + dwarf.DwarfId +
                        "\n\tName: " + dwarf.DwarfName +
                        "\n\tAge: " + dwarf.DwarfAge +
                        "\n\tTitle: " + dwarf.DwarfTitle +
                        "\n\tTribe: " + dwarf.DwarfTribe
                         );
                    }
                    else
                    {
                        Console.WriteLine("Der Zwerg konnte nicht gefunden werden. Versuch es erneut oder druecke X");
                    }

                }
            }
        }
    }
}
