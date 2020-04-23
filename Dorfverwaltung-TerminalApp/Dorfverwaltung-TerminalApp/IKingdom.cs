using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp
{
    interface IKingdom : IMenu
    {
        IKingdom Add();
        void ShowDetail(List<IKingdom> kingdomData);
        void PrintAll(List<IKingdom> kingdomData);
        void Remove(int id);
        //void Update(int id);
    }
}
