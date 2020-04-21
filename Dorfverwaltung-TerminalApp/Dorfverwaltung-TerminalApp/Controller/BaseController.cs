using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.Controller
{
    public abstract class BaseController
    {
        public void Add() { }
        public void ShowDetail(int id) { }
        public void PrintAll() { }
        public void Remove(int id) { }
        public void Update(int id) { }

        public string StringInput()
        {
            return Console.ReadLine();
        }
        public int IntegerInput()
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
