
using Dorfverwaltung_TerminalApp.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Menu
    {
        private IState currentController;
        public void EnterMenu(List<Model> data) { currentController.EnterMenu(data); }
        public void SetMenu(IState currentMenu) { this.currentController = currentMenu; }
    }
}

