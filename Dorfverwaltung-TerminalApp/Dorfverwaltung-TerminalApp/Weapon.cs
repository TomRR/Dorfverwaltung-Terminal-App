using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public class Weapon
    {
        public string WeaponType { get; set; }
        public int MagicalValue { get; set; }

        public string Description { get; set; }
        public string OwnerId { get; set; }

        public List<Weapon> Add(List<Weapon> weapons)
        {
            Console.WriteLine("Wie heisst der Zwerg:");
            string type = StringInput();
            Console.WriteLine("Welchen Magischen Wert hat die Waffe");
            int magicalValue = IntegerInput();
            Console.WriteLine("Hier kannst du eine Beschreibung hinzufuegen");
            string description = StringInput();

            Weapon newWeapon = new Weapon()
            {
                WeaponType = type,
                MagicalValue = magicalValue,
                Description = description,
            };
            weapons.Add(newWeapon);
            return weapons;
        }

        private string StringInput()
        {
            return Console.ReadLine();
        }
        private int IntegerInput()
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
