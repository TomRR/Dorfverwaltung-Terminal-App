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
            dwarfOption.setCurrentObject(new Dwarf());

            Weapon gimlisAxe = new Weapon() { WeaponType = "Axe", MagicalValue = 12, Description = "crabbie Old Axe", OwnerId = "1" };
            Weapon gimlisSword = new Weapon() { WeaponType = "Sword", MagicalValue = 15, Description = "Old Sword", OwnerId = "1" };
            Weapon zwinglisAxe = new Weapon() { WeaponType = "Axe", MagicalValue = 17, Description = "Shiny Axe", OwnerId = "2" };
            Weapon gumlisWand = new Weapon() { WeaponType = "Wand", MagicalValue = 45, Description = "Powerful Old Wand", OwnerId = "3" };
            Weapon gumlisWarHammer = new Weapon() { WeaponType = "War Hammer", MagicalValue = 15, Description = "just an ordinary War Hammer", OwnerId = "3" };

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
            //PrintAll();
            Console.WriteLine("die Gesamteinnahmen aus allen Staemmen betraegt: {0}", TotalTax(dwarves));
                do
            {
                
                string action;
                Console.Write("\nIn welchen Gebiet moechtest du eine Aktion ausfuehren \n\tZwergen Menu (dwarf)\n\tStaemme ausdrucken (tribe)\n\talles ausdrucken (p) \n\tBeenden (x)\n\t-->");
                action = Console.ReadLine();
                if(action.Equals("d")) { /*List<Dwarf> dwarves = GetListOfDwarf();*/  dwarfOption.EnterMenu(dwarves); }
                //if(action.Equals("t")) { List<Tribe> tribes = GetListOfTribes(); tribeOption.EnterMenu(); }
                if(action.Equals("p")) { PrintAll(); }
                if (action.Equals("x")) { beenden = false; }
            } while (beenden);

        }
        private static void PrintAll()
        {

        }

        private static double TotalTax(List<Dwarf> dwarves)
        {
            double totalTax = 0;
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
        
        public static List<Dwarf> GetListOfDwarf()
        {
            Weapon gimlisAxe = new Weapon() { WeaponType = "Axe", MagicalValue = 12, Description = "crabbie Old Axe", OwnerId = "1" };
            Weapon gimlisSword = new Weapon() { WeaponType = "Sword", MagicalValue = 15, Description = "Old Sword", OwnerId = "1" };
            Weapon zwinglisAxe = new Weapon() { WeaponType = "Axe", MagicalValue = 17, Description = "Shiny Axe", OwnerId = "2" };
            Weapon gumlisWand = new Weapon() { WeaponType = "Wand", MagicalValue = 45, Description = "Powerful Old Wand", OwnerId = "3" };
            Weapon gumlisWarHammer = new Weapon() { WeaponType = "War Hammer", MagicalValue = 15, Description = "just an ordinary War Hammer", OwnerId = "3" };

            List<Dwarf> dwarfList = new List<Dwarf>
            {
                new Dwarf() {
                    DwarfId = 1,
                    DwarfName = "Gimli",
                    DwarfAge = 140,
                    DwarfTribe = "Altobarden",
                    Inventory = new List<Weapon>() { gimlisAxe, gimlisSword },
                    },
                new Dwarf() {
                    DwarfId = 2,
                   DwarfName = "Zwingli",
                   DwarfAge = 70,
                   DwarfTribe = "Altobarden",
                   Inventory =  new List<Weapon>() { zwinglisAxe },
                   },
             new Dwarf() {
                   DwarfId = 3,
                   DwarfName = "Gumli",
                   DwarfAge = 163,
                   DwarfTitle = "Dwarf-Veteran",
                   DwarfTribe = "Elbknechte",
                   Inventory = new List<Weapon>() { gumlisWand, gumlisWarHammer },

                   },
            };

            return dwarfList;
        }
        private static List<Tribe> GetListOfTribes()
        {
            List<Dwarf> dwarflist = GetListOfDwarf();
            List<Dwarf> altobardenMember = new List<Dwarf>();
            List<Dwarf> elbknechteMember = new List<Dwarf>();

            foreach (Dwarf dwarf in dwarflist)
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

            List<Tribe> tribeList = new List<Tribe>
            {
                new Tribe()
                {
                    TribeName = "Altobarden",
                    ExistSince = "1247",
                    TribeMember = altobardenMember,
      
                },
                new Tribe()
                {
                    TribeName = "Elbknechte",
                    ExistSince = "1023",
                    TribeMember = elbknechteMember,

                }
            };

            return tribeList;
        }

        private int GetSumOfMagicalVales(List<Weapon> weapons)
        {
            int sumMagicalValue = 0;
            foreach (Weapon weapon in weapons)
            {
                sumMagicalValue += weapon.MagicalValue;
            }
            return sumMagicalValue;
        }

        private List<Weapon> GetListOfWeapons(List<Dwarf> dwarfs)
        {
            List<Weapon> weaponList = new List<Weapon>();
            foreach (Dwarf dwarf in dwarfs)
            {
                foreach (Weapon weapon in dwarf.Inventory)
                    weaponList.Add(weapon);
            }
            return weaponList;
        }
    }
}
