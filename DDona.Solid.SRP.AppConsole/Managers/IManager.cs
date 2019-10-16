using DDona.Solid.SRP.AppConsole.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.SRP.AppConsole.Managers
{
    public interface IManager<T>
    {
        void Add(T entry);
        void Remove(T entry);
        IReadOnlyList<T> GetEntries();
    }
}
