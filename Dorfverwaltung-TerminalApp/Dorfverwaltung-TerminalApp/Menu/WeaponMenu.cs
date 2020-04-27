using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.View
{
    class WeaponMenu : IMenu
    {
        private readonly WeaponController weaponController = new WeaponController();

        public List<Model> EnterMenu(List<Model> data)
        {          
            
            bool furtherOn = true;
            do
            {
                Console.Write("\nIn which area would you like to carry out an action \n\tAdd Weapon(add)\n\tWeapon Dwarf (remove)\n\tShow Weapon infos (show)\n\tPrint all Weapons (print) \n\tBack (x)\n\t-->");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "add":
                        data.Add(weaponController.AddModel());
                        break;
                    case "remove":
                        weaponController.Remove(data);
                        break;
                    case "show":
                        weaponController.ShowDetail(data);
                        break;
                    case "print":
                        weaponController.PrintAll(data);
                        break;
                    case "x":
                        furtherOn = false;
                        break;
                    default:
                        Console.WriteLine("that was not correct. please choose from the listed options");
                        break;
                }
            } while (furtherOn);
            return data;
        }
    }
}
