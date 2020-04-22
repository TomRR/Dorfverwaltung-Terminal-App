using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.Controller
{
    public class Menu
    {
        private BaseController baseController;

        public void Add() { baseController.Add(); }
        public void ShowDetail(int id) { baseController.ShowDetail(id); }
        public void PrintAll() { baseController.PrintAll(); }
        public void Remove(int id) { baseController.Remove(id); }
        public void Update(int id) { baseController.Update(id); }

        public BaseController GetController() { return baseController; }
        public void setController(BaseController controller)
        {
            this.baseController = controller;
        }

    }
}
