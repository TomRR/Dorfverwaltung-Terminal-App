using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.View
{
    class TribeMenu : IState
    {
        private readonly TribeController tribeController = new TribeController();
        public void EnterMenu(List<Model> data)
        {
            bool furtherOn = true;
            do
            {
                Console.Write("\nIn which area would you like to carry out an action \n\tAdd Tribe(add)\n\tRemove Tribe (remove)\n\tShow Tribe info (show)\n\tPrint all Tribe (print) \n\tBack (x)\n\t-->");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "add":
                        data.Add(tribeController.AddModel());
                        break;
                    case "remove":
                        break;
                    case "show":
                        tribeController.ShowDetail(data);
                        break;
                    case "print":
                        tribeController.PrintAll(data);
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
