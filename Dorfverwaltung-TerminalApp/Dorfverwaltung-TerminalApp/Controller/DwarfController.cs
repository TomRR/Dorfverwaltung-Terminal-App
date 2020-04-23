using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class DwarfController : IKingdom
    {
        Dwarf dwarf = new Dwarf();



        public void EnterMenu(List<IKingdom> kingdomData)
        {
            bool furtherOn = true;
            do
            {


                Console.Write("\nIn which area would you like to carry out an action \n\tAdd Dwarf(add)\n\tRemove Dwarf (remove)\n\tShow info Menu (show)\n\tPrint all Dwarfs (print) \n\tBack (x)\n\t-->");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "add":
                        kingdomData.Add(Add());
                        break;
                    case "remove":

                        break;
                    case "show":
                        ShowDetail(kingdomData);
                        break;
                    case "print":
                        PrintAll(kingdomData);
                        break;
                    case "x":
                        furtherOn = false;
                        break;
                    default:
                        Console.WriteLine("that was not correct. please choose from the listed options");
                        break;
                }
            } while (furtherOn);
        }


        public IKingdom Add()
        {
            throw new NotImplementedException();
        }

        

        public void PrintAll(List<IKingdom> kingdomData)
        {
            foreach (IKingdom kingdom in kingdomData)
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
