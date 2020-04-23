
using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Option
    {
        private Model currentOption;

        //public void Add() { currentOption.Add(); }
        public void EnterMenu(List<Model> kingdomData) { currentOption.EnterMenu(kingdomData); }
        //public IKingdom getOption() { return currentOption; }
        public void setOption(Model currentOption) { this.currentOption = currentOption; }
    }
}

