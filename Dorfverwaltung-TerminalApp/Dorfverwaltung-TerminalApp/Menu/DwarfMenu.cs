using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.Menu
{
    abstract class DwarfMenu : IMenu
    {
        public void EnterMenu()
        {
            Console.Write("\nWas moechtest du machen \n\tZwerge hinzufuegen (add)\n\tZwerge entfernen (remove)\n\tZwergeninfos ausdrucken (print) \n\tBeenden (any key)\n\t-->");
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
                    ShowDetail();
                    break;
                case "x":
                    break;
                default: break;
            }
        }
    }
}
