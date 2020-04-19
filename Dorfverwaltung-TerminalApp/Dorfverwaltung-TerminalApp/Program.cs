using System;
using System.Collections.Generic;

namespace Dorfverwaltung_TerminalApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Option tribeOption = new Option();
            //Option dwarfOption = new Option();

            //Tribes
            Tribe altobarden = new Tribe() { TribeName = "Altobarden", ExistSince = "1247 ndK", isLeaderSince = 25 };
            Tribe elbknechte = new Tribe() { TribeName = "Elbknechte", ExistSince = "1023 ndK" };
            // Weapons
            var w1 = new Weapon() { WeaponType = "Axt", MagicalValue = 12 };
            var w2 = new Weapon() { WeaponType = "Schwert", MagicalValue = 15 };
            var w3 = new Weapon() { WeaponType = "Axt", MagicalValue = 17 };
            var w4 = new Weapon() { WeaponType = "Zauberstab", MagicalValue = 45 };
            var w5 = new Weapon() { WeaponType = "Streithammer", MagicalValue = 15 };

            //Dwarfs
            var gimli = new Dwarf() { DwarfName = "Gimli", DwarfAge = 140, DwarfTribe = altobarden.TribeName, Inventory = new List<Weapon>() { w1, w2 } };
            var zwingli = new Dwarf() { DwarfName = "Zwingli", DwarfAge = 70, DwarfTribe = altobarden.TribeName, Inventory = new List<Weapon>() { w3 } };
            var gumli = new Dwarf() { DwarfName = "Gumli", DwarfAge = 163, DwarfTribe = elbknechte.TribeName, Inventory = new List<Weapon>() { w4, w5 } };
   

            gumli.ShowDetail();
            //elbknechte.TribeMember.Add(gimli);
            //elbknechte.TribeMember.Add(zwingli);
            //altobarden.TribeMember.Add(gumli);
            foreach(Dwarf ddwarf in elbknechte.TribeMember)
            {
                Console.WriteLine(ddwarf.DwarfName);
            }


            do
            {
                gumli.ShowDetail();

            } while (false);
        }
    }
}
