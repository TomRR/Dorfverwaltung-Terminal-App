using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public class Dwarf : ICrudOptions
    {
        public int DwarfId { get; set; }
        public string DwarfName { get; set; }
        public int DwarfAge { get; set; }
        public string DwarfTitle { get; set; }
        public string DwarfTribe { get; set; }
        public List<Weapon> Inventory { get; set; }
        private int ForceFactor { get; set; }

        public List<Dwarf> Add(List<Dwarf> dwarves)
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
                DwarfTribe = tribe
            };
            dwarves.Add(newDwarf);
            return dwarves;
        }

        public void EnterMenu(List<Dwarf> dwarves)
        {
            Console.Write("\nWas moechtest du machen \n\tZwerge hinzufuegen (add)\n\tZwerge hinzufuegen (remove)\n\tZwergeinfos ausdrucken (print) \n\tBeenden (any key)\n\t-->");
            string action = Console.ReadLine();
            switch (action)
            {
                case "add":
                    Add(dwarves);
                    break;
                case "remove":
                    Remove(dwarves);
                    break;
                case "print":
                    ShowDetail(dwarves);
                    break;
                case "x":
                    break;
                default: break;
            }
        }

            public void PrintAll()
            {
                throw new NotImplementedException();
            }

            public List<Dwarf> Remove(List<Dwarf> dwarves)
            {
                Console.WriteLine("Welchen Zwerg moechtest du entfernen: gebe die Id ein");
                foreach(Dwarf dwarf in dwarves)
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

            public void Update(List<Dwarf> dwarves)
            {
                throw new NotImplementedException();
            }
        private string StringInput()
        {
            return Console.ReadLine();
        }
        private int IntegerInput()
        {
            while (true)
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hier muss eine Zahl eingegeben werden\nWie alt ist er");
                    {  };
                }
        }
        }
    }

