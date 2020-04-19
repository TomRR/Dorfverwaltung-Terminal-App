using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    interface ICrudOptions
    {
        void Add();
        void Update();
        void ShowDetail();
        void Remove();
    }
}
