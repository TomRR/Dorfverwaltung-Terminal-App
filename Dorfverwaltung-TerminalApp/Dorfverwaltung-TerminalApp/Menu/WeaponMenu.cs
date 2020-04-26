using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.View
{
    class WeaponMenu : IState
    {
        private readonly WeaponController weaponController = new WeaponController();

        public void EnterMenu(List<Model> weapons)
        {          
            

            bool furtherOn = true;
            do
            {
                Console.Write("\nIn which area would you like to carry out an action \n\tAdd Weapon(add)\n\tWeapon Dwarf (remove)\n\tShow Weapon infos (show)\n\tPrint all Weapons (print) \n\tBack (x)\n\t-->");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "add":
                        weapons.Add(weaponController.AddModel());
                        break;
                    case "remove":
                        weaponController.Remove(weapons);
                        break;
                    case "show":
                        weaponController.ShowDetail(weapons);
                        break;
                    case "print":
                        weaponController.PrintAll(weapons);
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
