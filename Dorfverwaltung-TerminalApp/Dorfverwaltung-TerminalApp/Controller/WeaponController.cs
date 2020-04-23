using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.Controller
{
    class WeaponController
    {
        public IKingdom Add()
        {

            Console.WriteLine("Wie heisst der Zwerg:");
            string type = Console.ReadLine();
            Console.WriteLine("Welchen Magischen Wert hat die Waffe");
            int magicalValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hier kannst du eine Beschreibung hinzufuegen");
            string description = Console.ReadLine();
            Console.WriteLine("Hier kannst du eine Beschreibung hinzufuegen");
            string ownerId = Console.ReadLine();

            Weapon newWeapon = new Weapon()
            {
                WeaponType = type,
                MagicalValue = magicalValue,
                Description = description,
                OwnerId = ownerId,
            };
            return newWeapon;
        }

        public void EnterMenu(List<IKingdom> kingdomData)
        {
            Console.WriteLine("Weapon");
        }

        public void PrintAll(List<IKingdom> kingdomData)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void ShowDetail(List<IKingdom> kingdomData)
        {
            throw new NotImplementedException();
        }
    }
}
