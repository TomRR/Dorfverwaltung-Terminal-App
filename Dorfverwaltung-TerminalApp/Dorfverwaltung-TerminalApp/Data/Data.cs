using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Data
    {
        private List<Weapon> getWeaponList()
        {
            Weapon gimlisAxe = new Weapon() { Id = 1, WeaponName = "Gimli's Axe", WeaponType = "Axe", MagicalValue = 12, Description = "crabbie Old Axe", OwnerId = "1" };
            Weapon gimlisSword = new Weapon() { Id = 2, WeaponName = "Gimli's Sword", WeaponType = "Sword", MagicalValue = 15, Description = "Old Sword", OwnerId = "1" };
            Weapon zwinglisAxe = new Weapon() { Id = 3, WeaponName = "Zwingli's Axe", WeaponType = "Axe", MagicalValue = 17, Description = "Shiny Axe", OwnerId = "2" };
            Weapon gumlisWand = new Weapon() { Id = 4, WeaponName = "Gumli's Wand", WeaponType = "Wand", MagicalValue = 45, Description = "Powerful Old Wand", OwnerId = "3" };
            Weapon gumlisWarHammer = new Weapon() { Id = 5, WeaponName = "Gumli's War Hammer", WeaponType = "War Hammer", MagicalValue = 15, Description = "normal War Hammer", OwnerId = "3" };

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
                DwarfId = 1,
                DwarfName = "Gimli",
                DwarfAge = 140,
                DwarfTribe = "Altobarden",
                //Inventory = new List<Weapon>() { gimlisAxe, gimlisSword },
            };
            Dwarf zwingli = new Dwarf()
            {
                DwarfId = 2,
                DwarfName = "Zwingli",
                DwarfAge = 70,
                DwarfTribe = "Altobarden",
                //Inventory = new List<Weapon>() { zwinglisAxe },
            };
            Dwarf gumli = new Dwarf()
            {
                DwarfId = 3,
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
