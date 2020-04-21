using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Data
    {
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
        List<Dwarf> dwarves = new List<Dwarf>
        {
                gimli, zwingli, gumli
        };
    }
}
