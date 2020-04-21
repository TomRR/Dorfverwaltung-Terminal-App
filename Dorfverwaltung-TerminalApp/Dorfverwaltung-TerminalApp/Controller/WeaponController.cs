using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.Controller
{
    class WeaponController : BaseController
    {
        public List<Weapon> Add(List<Weapon> weapons)
        {
            Console.WriteLine("Wie heisst der Zwerg:");
            string type = StringInput();
            Console.WriteLine("Welchen Magischen Wert hat die Waffe");
            int magicalValue = IntegerInput();
            Console.WriteLine("Hier kannst du eine Beschreibung hinzufuegen");
            string description = StringInput();
            Console.WriteLine("Hier kannst du eine Beschreibung hinzufuegen");
            int ownerId = IntegerInput();

            Weapon newWeapon = new Weapon()
            {
                WeaponType = type,
                MagicalValue = magicalValue,
                Description = description,
                OwnerId = ownerId,
            };
            weapons.Add(newWeapon);
            return weapons;
        }
    }
}
