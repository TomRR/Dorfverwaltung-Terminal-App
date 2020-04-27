using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Data
    {
        private List<Weapon> getWeaponList()
        {
            Weapon gimlisAxe = new Weapon() { WeaponName = "Gimli's Axe", WeaponType = "Axe", MagicalValue = 12, Description = "crabbie Old Axe", Owner = "Gimli" };
            Weapon gimlisSword = new Weapon() { WeaponName = "Gimli's Sword", WeaponType = "Sword", MagicalValue = 15, Description = "Old Sword", Owner = "Gimli" };
            Weapon zwinglisAxe = new Weapon() { WeaponName = "Zwingli's Axe", WeaponType = "Axe", MagicalValue = 17, Description = "Shiny Axe", Owner = "Zwingli" };
            Weapon gumlisWand = new Weapon() { WeaponName = "Gumli's Wand", WeaponType = "Wand", MagicalValue = 45, Description = "Powerful Old Wand", Owner = "Gumli" };
            Weapon gumlisWarHammer = new Weapon() { WeaponName = "Gumli's War Hammer", WeaponType = "War Hammer", MagicalValue = 15, Description = "normal War Hammer", Owner = "Gumli" };

            List<Weapon> weapons = new List<Weapon>()
            {
                gimlisAxe, gimlisSword, zwinglisAxe, gumlisWand, gumlisWarHammer
            };
            return weapons;

        }
        private List<Dwarf> getDwarfList()
        {
            Dwarf gimli = new Dwarf()
            {
                DwarfName = "Gimli",
                DwarfAge = 140,
                DwarfTribe = "Altobarden",
                //Inventory = new List<Weapon>() { gimlisAxe, gimlisSword },
            };
            Dwarf zwingli = new Dwarf()
            {
                DwarfName = "Zwingli",
                DwarfAge = 70,
                DwarfTribe = "Altobarden",
                //Inventory = new List<Weapon>() { zwinglisAxe },
            };
            Dwarf gumli = new Dwarf()
            {
                DwarfName = "Gumli",
                DwarfAge = 163,
                DwarfTitle = "Dwarf-Veteran",
                DwarfTribe = "Elbknechte",
                //Inventory = new List<Weapon>() { gumlisWand, gumlisWarHammer },

            };
            List<Dwarf> dwarves = new List<Dwarf>
            {
                gimli, zwingli, gumli
            };
            return dwarves;
        }

        private List<Tribe> getTribeList()
        {
            List<Dwarf> dwarves = getDwarfList();
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
                IsLeaderSince = 25,
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
            return tribeList;
        }

        public List<Model> GetKingdomData()
        {
            List<Dwarf> dwarves = getDwarfList();
            List<Weapon> weapons = getWeaponList();
            List<Tribe> tribes = getTribeList();

            List<Model> kingdom = new List<Model>();
            foreach (Dwarf dwarf in dwarves)
            {
                kingdom.Add(dwarf);
            }
            foreach (Weapon weapon in weapons)
            {
                kingdom.Add(weapon);
            }
            foreach (Tribe tribe in tribes)
            {
                kingdom.Add(tribe);
            }
            return kingdom;
        }
    }
}
