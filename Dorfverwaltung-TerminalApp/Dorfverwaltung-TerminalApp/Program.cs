using Dorfverwaltung_TerminalApp.Controller;
using Dorfverwaltung_TerminalApp.Models;
using System;
using System.Collections.Generic;


namespace Dorfverwaltung_TerminalApp
{
    class Program
    {
        IVillage village = new Dwarf() { };
        static void Main(string[] args)
        {
            bool beenden = true;
            Option dwarfOption = new Option();
            Tribe tribe = new Tribe();
            //dwarfOption.setCurrentObject(new Dwarf());
            

            
            DwarfController dc = new DwarfController();
            TribeController tc = new TribeController();


            do
            {
                
                string action;
                Console.Write("\nIn welchen Gebiet moechtest du eine Aktion ausfuehren \n\tZwergen Menu (d)\n\talles ausdrucken (p) \n\tBeenden (x)\n\t-->");
                action = Console.ReadLine();
                //if(action.Equals("d")) { dwarfOption.EnterMenu(dwarves); }
                ////if (action.Equals("t")) { tribe.ShowTribeDetail(); }
                //if (action.Equals("p")) { PrintAll(dwarves, tribeList);}
                //if (action.Equals("x")) { beenden = false; }
            } while (beenden);

        }

 
        
        
    }
}
