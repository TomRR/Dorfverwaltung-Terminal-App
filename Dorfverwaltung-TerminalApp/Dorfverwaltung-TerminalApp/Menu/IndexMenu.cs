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
        public List<Model> EnterMenu(List<Model> data)
        {
            List<Model> weapons = new List<Model>();
            List<Model> dwarves = new List<Model>();
            List<Model> tribes = new List<Model>();
            List<Model> kingdom = data;


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
                Console.WriteLine("die Gesamteinnahmen aus allen Staemmen betraegt: {0}", TotalTax(weapons));

                string action;
                Console.Write("\nIn which area would you like to carry out an action \n\tDwarf Menu (dwarf)\n\tTribe Menu (tribe)\n\tWeapon Menu (weapon)\n\tPrint all (print) \n\tExit (x)\n\t-->");
                action = Console.ReadLine();
                switch (action)
                {
                    case "dwarf":
                        data = dwarfView.EnterMenu(data);
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
            return data;
        }
        private void PrintAll(List<Model> data)
        {
            int idDwarf = 1;
            List<Model> weapons = LoadWeaponList(data);
            List<Model> dwarves = LoadDwarfList(data);
            foreach(Model model in data)
            {
                if(model is Tribe tribe)
                {

                }
            }
            foreach(Dwarf dwarf in dwarves)
            {
                Console.WriteLine(
                    "\n\tId: " + idDwarf +
                    "\n\tName: " + dwarf.DwarfName +
                    "\n\tAge: " + dwarf.DwarfAge +
                    "\n\tTitle: " + dwarf.DwarfTitle +
                    "\n\tTribe: " + dwarf.DwarfTribe +
                    "\n" +
                    PrintWeapon(weapons, dwarf)
                     );
                idDwarf++;
            }
                //foreach (Tribe tribe in tribeList)
                //{
                //    tribe.ShowTribeDetail();
                //}
                //List<Weapon> weapons = data.FindAll()
                //TotalTax()
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

        private StringBuilder PrintWeapon(List<Model> weapons, Dwarf dwarf)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Weapon weapon in weapons)
            {
                string weaponOwner = weapon.Owner.ToLower();
                string dwarfName = dwarf.DwarfName.ToLower();
                bool isDwarfWeaponOwner = weaponOwner.Equals(dwarfName);

                if (isDwarfWeaponOwner)
                {
                    sb.Append(
                    "\n\t\tWeaponName: " + weapon.WeaponName +
                    "\n\t\tType: " + weapon.WeaponType +
                    "\n\t\tMagicalValue: " + weapon.MagicalValue +
                    "\n\t\tDescription: " + weapon.Description +
                    "\n"
                    );
                }
                
            }
            return sb;
            }
        }

    }

