using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{ 
    class WeaponController : Controller
    {
        public override Model AddModel()
        {
            Console.WriteLine("Wass fuer ein Waffentyp:");
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


        public override void PrintAll(List<Model> data)
        {
            foreach (Model model in data)
            {
                if (model is Weapon weapon)
                {
                    Console.WriteLine(
                    "\n\tId: " + weapon.WeaponType +
                    "\n\tName: " + weapon.MagicalValue +
                    "\n\tAge: " + weapon.Description
                     );
                }
            }
        }

        public override void Remove(List<Model> data)
        {
            Console.WriteLine("Welchen Waffe moechtest du entfernen: gebe die Id ein");
            PrintIdAndName(data);
            int id = IntegerInput() - 1;
            data.RemoveAt(id);
            PrintAll(data);
        }

        public override void ShowDetail(List<Model> data)
        {
            PrintIdAndName(data);
            foreach (Model model in data)
            {
                if (model is Weapon weapon)
                {
                    Console.WriteLine("welche Waffe suchst du? (Id eingeben)");
                    int id = IntegerInput();
                    if (id == weapon.Id)
                    {
                        Console.WriteLine(
                            "\n\tId: " + weapon.WeaponType +
                            "\n\tName: " + weapon.MagicalValue +
                            "\n\tAge: " + weapon.Description
                            );
                    }
                    else
                    {
                        Console.WriteLine("Waffe konnte nicht gefunden werden. Versuch es erneut oder druecke X");
                    }

                }
            }
        }

        private void PrintIdAndName(List<Model> data)
        {
            foreach (Model model in data)
            {
                if (model is Weapon weapon)
                {
                    Console.WriteLine("(Id:{0}) {1} ", weapon.Id, weapon.WeaponType);

                }
            }
        }
    }
}
