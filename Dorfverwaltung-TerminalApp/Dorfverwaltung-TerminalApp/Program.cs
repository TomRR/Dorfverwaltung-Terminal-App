using System;
using System.Collections.Generic;

namespace Dorfverwaltung_TerminalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool beenden = true;

            //Option tribeOption = new Option();
            //Option dwarfOption = new Option();

            ////Tribes
            //Tribe altobarden = new Tribe() { TribeName = "Altobarden", ExistSince = "1247 ndK", isLeaderSince = 25 };
            //Tribe elbknechte = new Tribe() { TribeName = "Elbknechte", ExistSince = "1023 ndK" };
            //// Weapons
            //var w1 = new Weapon() { WeaponType = "Axt", MagicalValue = 12 };
            //var w2 = new Weapon() { WeaponType = "Schwert", MagicalValue = 15 };
            //var w3 = new Weapon() { WeaponType = "Axt", MagicalValue = 17 };
            //var w4 = new Weapon() { WeaponType = "Zauberstab", MagicalValue = 45 };
            //var w5 = new Weapon() { WeaponType = "Streithammer", MagicalValue = 15 };

            ////Dwarfs
            //var gimli = new Dwarf() { DwarfName = "Gimli", DwarfAge = 140, DwarfTribe = altobarden.TribeName, Inventory = new List<Weapon>() { w1, w2 } };
            //var zwingli = new Dwarf() { DwarfName = "Zwingli", DwarfAge = 70, DwarfTribe = altobarden.TribeName, Inventory = new List<Weapon>() { w3 } };
            //var gumli = new Dwarf() { DwarfName = "Gumli", DwarfAge = 163, DwarfTribe = elbknechte.TribeName, Inventory = new List<Weapon>() { w4, w5 } };


            do
            {
                string action;
                Console.Write("\nIn welchen Gebiet moechtest du eine Aktion ausfuehren \n\tZwerge (dwarf)\n\tStaemme (tribe)\n\talles ausdrucken (printall) \n\tBeenden (x)\n\t-->");
                action = Console.ReadLine();
                if(action.Equals("dwarf")) { }
                if(action.Equals("tribe")) { }
                if(action.Equals("printall")) { }
                if (action.Equals("x")) { beenden = false; }
            } while (beenden);

        }

        private List<Dwarf> GetListOfDwarf()
        {
            Weapon gimlisAxe = new Weapon() { WeaponType = "Axe", MagicalValue = 12, Description = "crabbie Old Axe", OwnerId = "1" };
            Weapon gimlisSword = new Weapon() { WeaponType = "Sword", MagicalValue = 15, Description = "Old Sword", OwnerId = "1" };
            Weapon zwinglisAxe = new Weapon() { WeaponType = "Axe", MagicalValue = 17, Description = "Shiny Axe", OwnerId = "2" };
            Weapon gumlisWand = new Weapon() { WeaponType = "Wand", MagicalValue = 45, Description = "Powerful Old Wand", OwnerId = "3" };
            Weapon gumlisWarHammer = new Weapon() { WeaponType = "War Hammer", MagicalValue = 15, Description = "just an ordinary War Hammer", OwnerId = "3" };

            List<Dwarf> dwarfList = new List<Dwarf>
            {
                new Dwarf() {
                    DwarfId = "1",
                    DwarfName = "Gimli",
                    DwarfAge = 140,
                    DwarfTribe = "Altobarden",
                    Inventory = new List<Weapon>() { gimlisAxe, gimlisSword },
                    },
                new Dwarf() {
                    DwarfId = "2",
                   DwarfName = "Zwingli",
                   DwarfAge = 70,
                   DwarfTribe = "Altobarden",
                   Inventory =  new List<Weapon>() { zwinglisAxe },
                   },
             new Dwarf() {
                   DwarfId = "3",
                   DwarfName = "Gumli",
                   DwarfAge = 163,
                   DwarfTitle = "Dwarf-Veteran",
                   DwarfTribe = "Elbknechte",
                   Inventory = new List<Weapon>() { gumlisWand, gumlisWarHammer },

                   },
            };

            return dwarfList;
        }
        private List<Tribe> GetListOfTribes()
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
                    TaxRate = 2125
                },
                new Tribe()
                {
                    TribeName = "Elbknechte",
                    ExistSince = "1023",
                    TribeMember = elbknechteMember,
                    TaxRate = 2125
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
