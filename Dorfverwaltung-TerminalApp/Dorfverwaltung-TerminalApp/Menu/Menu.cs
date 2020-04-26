
using Dorfverwaltung_TerminalApp.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Menu
    {
        private IMenu currentController;
        public void EnterMenu(List<Model> data) { currentController.EnterMenu(data); }
        public void SetMenu(IMenu currentMenu) { this.currentController = currentMenu; }
    }
}

