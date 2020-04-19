using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public class Weapon : IMenu
    {
        public string WeaponType { get; set; }
        public int MagicalValue { get; set; }

        public string Description { get; set; }
        public string OwnerId { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void ShowDetail()
        {
            Console.WriteLine(
                "\n\tName: " + WeaponType +
                "\n\tAge: " + MagicalValue 
                //"\n\tDescription: " + Description
                );
            
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
