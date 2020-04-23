using System;
using System.Collections.Generic;


namespace Dorfverwaltung_TerminalApp
{
    class Program
    {
        private static readonly double taxRate = 2.125;
        static void Main(string[] args)
        {

            Option dwarfOption = new Option();
            dwarfOption.setOption(new DwarfController());
            Option tribeOption = new Option();
            tribeOption.setOption(new Tribe());
            Option weaponOption = new Option();
            weaponOption.setOption(new Weapon());

            Data data = new Data();
            List<IKingdom> kingdomData = data.AddKingdomData();


            bool furtherOn = true;

            do
            {

                string action;
                Console.Write("\nIn which area would you like to carry out an action \n\tDwarf Menu (dwarf)\n\tTribe Menu (tribe)\n\tWeapon Menu (weapon)\n\tPrint all (print) \n\tExit (x)\n\t-->");
                action = Console.ReadLine();
                switch (action)
                {
                    case "dwarf":
                        dwarfOption.EnterMenu(kingdomData);
                        break;
                    case "tribe":
                        tribeOption.EnterMenu(kingdomData);
                        break;
                    case "weapon":
                        weaponOption.EnterMenu(kingdomData);
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

        private static void PrintAll(List<IKingdom> kingdomData)
        {
            //Console.WriteLine("die Gesamteinnahmen aus allen Staemmen betraegt: {0}", TotalTaxPerDwarfList());
            //foreach (Tribe tribe in tribeList)
            //{
            //    tribe.ShowTribeDetail();
            //}
        }
        private static double TotalTaxPerDwarfList(List<Dwarf> dwarves)
        {
            int totalMagicalValue = 0;

            foreach (Dwarf dwarf in dwarves)
            {
                foreach (Weapon weapons in dwarf.Inventory)
                {
                    totalMagicalValue += weapons.MagicalValue;
                }
            }

            return totalMagicalValue * taxRate;
        }


    }
}
