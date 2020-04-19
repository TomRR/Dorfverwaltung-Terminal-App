﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public class Option
    {
        private ICrudOptions currentObject;
        private List<Dwarf> dwarves;
        public void Add()
        {
            currentObject.Add();
        }

        public void ShowDetail()
        {
            currentObject.ShowDetail(dwarves);
        }
        public void Remove()
        {
            currentObject.Remove();
        } 
        public void EnterMenu(List<Dwarf> dwarves)
        {
            currentObject.EnterMenu(dwarves);
        }

        public ICrudOptions getCurrentObject()
        {
            return currentObject;
        }

        public void setCurrentObject(ICrudOptions currentObject)
        {
            this.currentObject = currentObject;
        }
    }
}
