using Dorfverwaltung_TerminalApp.View;
using System;
using System.Collections.Generic;


namespace Dorfverwaltung_TerminalApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            Data data = new Data();

            menu.setMenu(new _IndexView());
         
            List<Model> kingdomData = data.GetKingdomData();
            foreach(Model model in kingdomData)
            {
                Console.WriteLine(model);
            }
            menu.EnterMenu(kingdomData);
        }
    }
}
