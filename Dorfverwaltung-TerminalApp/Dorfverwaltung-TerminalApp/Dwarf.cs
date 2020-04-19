﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public class Dwarf : IMenu
    {
        public string Id { get; set; }
        public string DwarfName { get; set; }
        public int DwarfAge { get; set; }
        public string DwarfTitle { get; set; }
        public string DwarfTribe { get; set; }
        public List<Weapon> Inventory{ get; set; }
        //private Option option;

        public void Add(Dwarf dwarf)
        {
            //Console.Write("Wie soll der Zwerg heissen? ");
            //dwarf.DwarfName = option.StringInput();
            //Console.Write("Wie alt soll er sein? ");
            //option.IntegerInput();
            //Console.Write("Hat er einen Titel [y/n]?");
            //option.StringInput();
            //Console.Write("Zu Welche Stamm gehoert er? ");
            //Console.Write("Moechtest du ihn eine oder mehrere Waffen geben? ");

        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void ShowDetail()
        {
            Console.WriteLine(
                "\n\tName: " + DwarfName +
                "\n\tAge: " + DwarfAge +
                "\n\tTitle: " + DwarfTitle +
                "\n\tTribe: " + DwarfTribe
                );
            PrintInventory();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        private void PrintInventory()
        {
            foreach (Weapon weapon in Inventory)
            {
                weapon.ShowDetail();
            }
        }
    }
}
