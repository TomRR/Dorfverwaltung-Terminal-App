using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public class Option
    {
        private IMenu currentObject;

        public void Add()
        {
            currentObject.Add();
        }

        public void ShowDetail()
        {
            currentObject.ShowDetail();
        }
        public void Remove()
        {
            currentObject.Remove();
        } 
        public void EnterMenu()
        {
            currentObject.EnterMenu();
        }

        public IMenu getCurrentObject()
        {
            return currentObject;
        }

        public void setCurrentOpject(IMenu currentObject)
        {
            this.currentObject = currentObject;
        }
    }
}
