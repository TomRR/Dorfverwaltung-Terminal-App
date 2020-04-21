using Dorfverwaltung_TerminalApp.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    public class Option
    {
        private BaseController currentObject;

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

        public BaseController getCurrentObject()
        {
            return currentObject;
        }

        public void setCurrentObject(BaseController currentObject)
        {
            this.currentObject = currentObject;
        }
    }
}
