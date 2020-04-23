using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    abstract class Controller
    {
        //public abstract void EnterMenu(List<Model> kingdomData);
        public abstract Model AddModel();
        public abstract void ShowDetail(List<Model> kingdomData);
        public abstract void Remove(List<Model> kingdomData);



        protected string StringInput()
        {
            return Console.ReadLine();
        }
        protected int IntegerInput()
        {
            while (true)
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hier muss eine Zahl eingegeben werden");
                    { };
                }
        }
    }
}
