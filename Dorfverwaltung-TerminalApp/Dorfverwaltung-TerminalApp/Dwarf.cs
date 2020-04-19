using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public class Dwarf : ICrudOptions
    {
        public string DwarfId { get; set; }
        public string DwarfName { get; set; }
        public int DwarfAge { get; set; }
        public string DwarfTitle { get; set; }
        public string DwarfTribe { get; set; }
        public List<Weapon> Inventory { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void EnterMenu(List<Dwarf> dwarves)
        {
            Console.Write("\nWas moechtest du machen \n\tZwerge hinzufuegen (add)\n\tZwerge hinzufuegen (remove)\n\tZwergeinfos ausdrucken (print) \n\tBeenden (any key)\n\t-->");
            string action = Console.ReadLine();
            switch (action)
            {
                case "add":
                    Add();
                    break;
                case "remove":
                    Remove();
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

            public void Remove()
            {
                throw new NotImplementedException();
            }

            public void ShowDetail(List<Dwarf> dwarves)
            {
                foreach (Dwarf dwarf in dwarves)
                {
                    Console.WriteLine(
                    "\n\tName: " + dwarf.DwarfName +
                    "\n\tAge: " + dwarf.DwarfAge +
                    "\n\tTitle: " + dwarf.DwarfTitle +
                    "\n\tTribe: " + dwarf.DwarfTribe
                     );
                }
            }

            public void Update()
            {
                throw new NotImplementedException();
            }
        }
    } 

