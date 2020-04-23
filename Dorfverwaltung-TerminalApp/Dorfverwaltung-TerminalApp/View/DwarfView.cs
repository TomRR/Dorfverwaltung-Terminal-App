using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.View
{
    class DwarfView : IView
    {
        private readonly DwarfController dwarfController = new DwarfController();
        public void EnterMenu(List<Model> data)
        {
            bool furtherOn = true;
            do
            {
                Console.Write("\nIn which area would you like to carry out an action \n\tAdd Dwarf(add)\n\tRemove Dwarf (remove)\n\tShow info Menu (show)\n\tPrint all Dwarfs (print) \n\tBack (x)\n\t-->");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "add":
                        data.Add(dwarfController.AddModel());
                        break;
                    case "remove":
                        dwarfController.Remove(data);
                        break;
                    case "show":
                        dwarfController.ShowDetail(data);
                        break;
                    case "print":
                        dwarfController.PrintAll(data);
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
    }
}
