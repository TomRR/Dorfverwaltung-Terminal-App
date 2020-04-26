using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dorfverwaltung_TerminalApp.View
{
    class IndexMenu : IMenu
    {
        private static readonly double taxRate = 2.125;
        private readonly DwarfMenu dwarfView = new DwarfMenu();
        private readonly TribeMenu tribeView = new TribeMenu();
        private readonly WeaponMenu weaponView = new WeaponMenu();
        public void EnterMenu(List<Model> data)
        {
            List<Model> weapons = new List<Model>();
            if (weapons.Count == 0)
            {
                weapons = LoadWeaponList(data);
            }
            bool furtherOn = true;
            do
            {

                string action;
                Console.Write("\nIn which area would you like to carry out an action \n\tDwarf Menu (dwarf)\n\tTribe Menu (tribe)\n\tWeapon Menu (weapon)\n\tPrint all (print) \n\tExit (x)\n\t-->");
                action = Console.ReadLine();
                switch (action)
                {
                    case "dwarf":
                        dwarfView.EnterMenu(data);
                        break;
                    case "tribe":
                        tribeView.EnterMenu(data);
                        break;
                    case "weapon":
                        weaponView.EnterMenu(weapons);
                        break;
                    case "print":
                        PrintAll(data);
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
        private void PrintAll(List<Model> data)
        {
            
            //Console.WriteLine("die Gesamteinnahmen aus allen Staemmen betraegt: {0}", TotalTaxPerDwarfList());
            //foreach (Tribe tribe in tribeList)
            //{
            //    tribe.ShowTribeDetail();
            //}
            //List<Weapon> weapons = data.FindAll()
            //TotalTax()
        }
        private bool FindWeapons(List<Model> data)
        {
            return true;//data.OfType<Weapon>;
        }
        private double TotalTax(List<Weapon> weapons)
        {
            int totalMagicalValue = 0;
                foreach (Weapon weapon in weapons)
                {
                    totalMagicalValue += weapon.MagicalValue;
                }

            return totalMagicalValue * taxRate;
        }
        private List<Model> LoadWeaponList(List<Model> data)
        {
            List<Model> weapons = new List<Model>();
            foreach (Model model in data)
            {
                if (model is Weapon waeapon)
                {
                    weapons.Add(model);
                }
            }
            return weapons;
        }

    }
}
