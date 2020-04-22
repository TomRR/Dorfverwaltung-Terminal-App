using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung_TerminalApp.Models
{
    interface IVillage
    {
        void Add() { }
        void ShowDetail(int id) { }
        void PrintAll() { }
        void Remove(int id) { }
        void Update(int id) { }
    }
}
