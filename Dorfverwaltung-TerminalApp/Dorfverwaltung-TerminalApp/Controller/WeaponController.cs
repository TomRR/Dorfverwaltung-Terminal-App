using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Welcher Zwerg soll die Waffe bekommen (Namen, achte auf Rechtschreibung)");
            string owner = Console.ReadLine();

            Weapon newWeapon = new Weapon()
            {
                WeaponType = type,
                MagicalValue = magicalValue,
                Description = description,
                Owner = owner,
            };
            return newWeapon;
        }


        public override void PrintAll(List<Model> data)
        {
            int id = 1;
            foreach (Model model in data)
            {
                if (model is Weapon weapon)
                {
                    Console.WriteLine(
                    "\n\tId: " + id +
                    "\n\tType: " + weapon.WeaponName +
                    "\n\tType: " + weapon.WeaponType +
                    "\n\tName: " + weapon.MagicalValue +
                    "\n\tDescription: " + weapon.Description
                     );
                    id++;
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
                    Model w = data.ElementAt(id);
                    
                        if (id == weapon.WeaponName)
                    {
                        Console.WriteLine(
                        "\n\tType: " + weapon.WeaponName +
                        "\n\tType: " + weapon.WeaponType +
                        "\n\tName: " + weapon.MagicalValue +
                        "\n\tDescription: " + weapon.Description
                                );
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Waffe konnte nicht gefunden werden.");
                    }
                }
            }
        }

        private void PrintIdAndName(List<Model> data)
        {
            int id = 1;
            foreach (Model model in data)
            {
                
                if (model is Weapon weapon)
                {
                    Console.WriteLine("(Id:{0}) {1} ", id, weapon.WeaponType);
                    id++;
                }
                
            }
        }
    }
}
