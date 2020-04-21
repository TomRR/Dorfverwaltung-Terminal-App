using Dorfverwaltung_TerminalApp.Controller;
using System;
using System.Collections.Generic;

namespace Dorfverwaltung_TerminalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool beenden = true;
            Option dwarfOption = new Option();
            Tribe tribe = new Tribe();
            //dwarfOption.setCurrentObject(new Dwarf());
            

            Weapon gimlisAxe = new Weapon() { WeaponType = "Axe", MagicalValue = 12, Description = "crabbie Old Axe", OwnerId = "1" };
            Weapon gimlisSword = new Weapon() { WeaponType = "Sword", MagicalValue = 15, Description = "Old Sword", OwnerId = "1" };
            Weapon zwinglisAxe = new Weapon() { WeaponType = "Axe", MagicalValue = 17, Description = "Shiny Axe", OwnerId = "2" };
            Weapon gumlisWand = new Weapon() { WeaponType = "Wand", MagicalValue = 45, Description = "Powerful Old Wand", OwnerId = "3" };
            Weapon gumlisWarHammer = new Weapon() { WeaponType = "War Hammer", MagicalValue = 15, Description = "normal War Hammer", OwnerId = "3" };

            Dwarf gimli = new Dwarf()
            {
                DwarfId = 1,
                DwarfName = "Gimli",
                DwarfAge = 140,
                DwarfTribe = "Altobarden",
                Inventory = new List<Weapon>() { gimlisAxe, gimlisSword },
            };
            Dwarf zwingli = new Dwarf()
            {
                DwarfId = 2,
                DwarfName = "Zwingli",
                DwarfAge = 70,
                DwarfTribe = "Altobarden",
                Inventory = new List<Weapon>() { zwinglisAxe },
            };
            Dwarf gumli = new Dwarf()
            {
                DwarfId = 3,
                DwarfName = "Gumli",
                DwarfAge = 163,
                DwarfTitle = "Dwarf-Veteran",
                DwarfTribe = "Elbknechte",
                Inventory = new List<Weapon>() { gumlisWand, gumlisWarHammer },

            };
            DwarfController dc = new DwarfController();
            TribeController tc = new TribeController();
            tc.Add
            List<Dwarf> dwarves = new List<Dwarf>
            {
                gimli, zwingli, gumli
            };
            List<Dwarf> altobardenMember = new List<Dwarf>();
            List<Dwarf> elbknechteMember = new List<Dwarf>();

            foreach (Dwarf dwarf in dwarves)
            {
                if (dwarf.DwarfTribe.Equals("Altobarden"))
                {
                    altobardenMember.Add(dwarf);
                }
                else if (dwarf.DwarfTribe.Equals("Elbknechte"))
                {
                    elbknechteMember.Add(dwarf);
                }
            }
                Tribe altpbarden = new Tribe()
                {
                    TribeName = "Altobarden",
                    ExistSince = "1247",
                    TribeLeader = "Gimli",
                    isLeaderSince = 25,
                    TribeMember = altobardenMember,

                };
                Tribe elbknechte = new Tribe()
                {
                    TribeName = "Elbknechte",
                    ExistSince = "1023",
                    TribeMember = elbknechteMember,
                };

            List<Tribe> tribeList = new List<Tribe>
                { altpbarden, elbknechte };
            PrintAll(dwarves, tribeList);

            do
            {
                
                string action;
                Console.Write("\nIn welchen Gebiet moechtest du eine Aktion ausfuehren \n\tZwergen Menu (d)\n\talles ausdrucken (p) \n\tBeenden (x)\n\t-->");
                action = Console.ReadLine();
                if(action.Equals("d")) { dwarfOption.EnterMenu(dwarves); }
                //if (action.Equals("t")) { tribe.ShowTribeDetail(); }
                if (action.Equals("p")) { PrintAll(dwarves, tribeList);}
                if (action.Equals("x")) { beenden = false; }
            } while (beenden);

        }
        private static void PrintAll(List<Dwarf> listofDwaves, List<Tribe> tribeList)
        {
            Console.WriteLine("die Gesamteinnahmen aus allen Staemmen betraegt: {0}", TotalTaxPerDwarfList(listofDwaves));
            foreach(Tribe tribe in tribeList)
            {
                tribe.ShowTribeDetail();
            }
        }

        private static double TotalTaxPerDwarfList(List<Dwarf> dwarves)
        {
            double taxRate = 2.125;
            int totalMagicalValue = 0;
 
                    foreach(Dwarf dwarf in dwarves)
                    {
                        foreach(Weapon weapons in dwarf.Inventory)
                        {
                            totalMagicalValue += weapons.MagicalValue;
                        }
                    }

            return totalMagicalValue * taxRate;
        }
        
        
    }
}
