using DDona.Solid.SRP.AppConsole.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.SRP.AppConsole.Managers
{
    public interface IManager
    {
        void Add(WorkReportEntry entry);
        void Remove(WorkReportEntry entry);
        IReadOnlyList<WorkReportEntry> GetEntries();
    }
}
