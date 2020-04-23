using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
        class Dwarf  : Model
        {
            public int DwarfId { get; set; }
            public string DwarfName { get; set; }
            public int DwarfAge { get; set; }
            public string DwarfTitle { get; set; }
            public string DwarfTribe { get; set; }
            public List<Weapon> Inventory { get; set; }

        public override void EnterMenu(List<Model> kingdomData)
        {
            throw new NotImplementedException();
        }

        //public IKingdom Add()
        //{
        //    Console.WriteLine("Wie heisst der Zwerg:");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Wie alt ist er");
        //    int age = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Falls er einen Title hat, gebe ihn ein");
        //    string title = Console.ReadLine();
        //    Console.WriteLine("zu welchen Tribe gehoert er. Elbknechte oder Altobarden");
        //    string tribe = Console.ReadLine();
        //    Dwarf newDwarf = new Dwarf()
        //    {
        //        DwarfId = 1,
        //        DwarfName = name,
        //        DwarfAge = age,
        //        DwarfTitle = title,
        //        DwarfTribe = tribe,
        //        Inventory = new List<Weapon>() { },
        //    };
        //    return newDwarf;
        //}



        //public void Remove(int id)
        //{
        //    //Console.WriteLine("Welchen Zwerg moechtest du entfernen: gebe die Id ein");
        //    //foreach (Dwarf dwarf in dwarves)
        //    //{
        //    //    Console.WriteLine("(Id:{0}) {1}", dwarf.DwarfId, dwarf.DwarfName);
        //    //}
        //    //int id = IntegerInput() - 1;
        //    //dwarves.RemoveAt(id);
        //    //ShowDetail(dwarves);

        //}

        //public void ShowDetail(List<IKingdom> kingdomData)
        //{
        //    foreach (IKingdom kingdom in kingdomData)
        //    {
        //        if (kingdom is Dwarf dwarf)
        //        {
        //            Console.WriteLine("welchen Zwerg suchst du?");
        //            string name = Console.ReadLine().ToLower();
        //            if (name == dwarf.DwarfName.ToLower())
        //            {
        //                Console.WriteLine(
        //                "\n\tId: " + dwarf.DwarfId +
        //                "\n\tName: " + dwarf.DwarfName +
        //                "\n\tAge: " + dwarf.DwarfAge +
        //                "\n\tTitle: " + dwarf.DwarfTitle +
        //                "\n\tTribe: " + dwarf.DwarfTribe
        //                 );
        //            } else
        //        {
        //            Console.WriteLine("Der Zwerg konnte nicht gefunden werden. Versuch es erneut oder druecke X");
        //        }

        //        }

        //    }
        //}

        //public void EnterMenu(List<IKingdom> kingdomData)
        //{
        //    bool furtherOn = true;
        //    do
        //    {


        //        Console.Write("\nIn which area would you like to carry out an action \n\tAdd Dwarf(add)\n\tRemove Dwarf (remove)\n\tShow info Menu (show)\n\tPrint all Dwarfs (print) \n\tBack (x)\n\t-->");
        //        string action = Console.ReadLine();
        //        switch (action)
        //        {
        //            case "add":
        //            kingdomData.Add(Add());
        //                break;
        //            case "remove":

        //                break;
        //            case "show":
        //                ShowDetail(kingdomData);
        //                break;
        //            case "print":
        //                PrintAll(kingdomData);
        //                break;
        //            case "x":
        //                furtherOn = false;
        //                break;
        //            default:
        //                Console.WriteLine("that was not correct. please choose from the listed options");
        //                break;
        //        }
        //    } while (furtherOn);
        //}

        //public void PrintAll(List<IKingdom> kingdomData)
        //{
        //    foreach (IKingdom kingdom in kingdomData)
        //    {
        //        if (kingdom is Dwarf dwarf)
        //        {
        //            Console.WriteLine(
        //            "\n\tId: " + dwarf.DwarfId +
        //            "\n\tName: " + dwarf.DwarfName +
        //            "\n\tAge: " + dwarf.DwarfAge +
        //            "\n\tTitle: " + dwarf.DwarfTitle +
        //            "\n\tTribe: " + dwarf.DwarfTribe
        //             );
        //        }
        //    }
        //}
    }
}
