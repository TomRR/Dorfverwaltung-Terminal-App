using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class DwarfController : Controller
    {
        

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
                DwarfName = name,
                DwarfAge = age,
                DwarfTitle = title,
                DwarfTribe = tribe,
                Inventory = new List<Weapon>() { },
            };
            return newDwarf;
        }



        public override void PrintAll(List<Model> data)
        {
            int id = 1;
            foreach (Model model in data)
            {
                if (model is Dwarf dwarf)
                {
                    Console.WriteLine(
                    "\n\tId: " + id +
                    "\n\tName: " + dwarf.DwarfName +
                    "\n\tAge: " + dwarf.DwarfAge +
                    "\n\tTitle: " + dwarf.DwarfTitle +
                    "\n\tTribe: " + dwarf.DwarfTribe
                     );
                    id++;
                }
            }
        }

        public override void Remove(List<Model> data)
        {
            GetDwarfIdAndName(data);
            Console.WriteLine("Welchen Zwerg moechtest du entfernen: gebe die Id ein");
            
                int id = IntegerInput() - 1;
                data.RemoveAt(id);
                PrintAll(data);
            
        }

        public override void ShowDetail(List<Model> data)
        {
            GetDwarfIdAndName(data);
            foreach (Model model in data)
            {
                if (model is Dwarf dwarf)
                {
                    Console.WriteLine("welchen Zwerg suchst du? (Namen eingeben)");
                    string name = Console.ReadLine().ToLower();
                    if (name == dwarf.DwarfName.ToLower())
                    {
                        Console.WriteLine(
                        "\n\tName: " + dwarf.DwarfName +
                        "\n\tAge: " + dwarf.DwarfAge +
                        "\n\tTitle: " + dwarf.DwarfTitle +
                        "\n\tTribe: " + dwarf.DwarfTribe
                         );
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Der Zwerg konnte nicht gefunden werden. Versuch es erneut oder druecke X");
                    }

                }
            }
        }
        private void GetDwarfIdAndName(List<Model> data)
        {
            int id = 1;
            foreach (Model model in data)
            {
                if (model is Dwarf dwarf)
                {
                    Console.WriteLine("(Id:{0}) {1} ", id, dwarf.DwarfName);                    
                }
                id++;
            }
        }
    }
}
