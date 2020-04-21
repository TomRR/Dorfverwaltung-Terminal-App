using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Menu
    {

        public virtual string StringInput()
        {
            return Console.ReadLine();       
        }
        public virtual int IntegerInput()
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
