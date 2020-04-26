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
            List<Model> dwarves = new List<Model>();
            List<Model> tribes = new List<Model>();
            
            if (weapons.Count == 0)
            {
                weapons = LoadWeaponList(data);
            }            
            if (dwarves.Count == 0)
            {
                dwarves = LoadDwarfList(data);
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
                        PrintAll(dwarves, weapons);
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
        private void PrintAll(List<Model> dwarves, List<Model> weapons)
        {


            Console.WriteLine("die Gesamteinnahmen aus allen Staemmen betraegt: {0}", TotalTax(weapons));
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
        private double TotalTax(List<Model> weapons)
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
        private List<Model> LoadDwarfList(List<Model> data)
        {
            List<Model> dwarves = new List<Model>();
            foreach (Model model in data)
            {
                if (model is Dwarf dwarf)
                {
                    dwarves.Add(model);
                }
            }
            return dwarves;
        }

        public void PrintWeapon(List<Model> data)
        {
            int id = 1;
            foreach (Model model in data)
            {
                if (model is Weapon weapon)
                {
                    Console.WriteLine(
                    "\n\tId: " + id +
                    "\n\tType: " + weapon.WeaponName +
                    "\n\tType: " + weapon.WeaponType +
                    "\n\tName: " + weapon.MagicalValue +
                    "\n\tAge: " + weapon.Description
                     );
                    id++;
                }
            }
        }
        public void PrintDwarf(List<Model> data)
        {
            foreach (Model model in data)
            {
                if (model is Dwarf dwarf)
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

    }
}
