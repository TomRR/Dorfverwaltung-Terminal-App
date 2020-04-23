
using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    class Option
    {
        private IKingdom currentOption;

        //public void Add() { currentOption.Add(); }
        public void EnterMenu(List<IKingdom> kingdomData) { currentOption.EnterMenu(kingdomData); }
        //public IKingdom getOption() { return currentOption; }
        public void setOption(IKingdom currentOption) { this.currentOption = currentOption; }
    }
}

