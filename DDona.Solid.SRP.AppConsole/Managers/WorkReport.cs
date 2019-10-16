using DDona.Solid.SRP.AppConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.Solid.SRP.AppConsole.Managers
{
    public class WorkReport : IManager<WorkReportEntry>
    {
        private readonly List<WorkReportEntry> _entries;

        public WorkReport()
        {
            _entries = new List<WorkReportEntry>();
        }

        public void Add(WorkReportEntry entry) => _entries.Add(entry);

        public void Remove(WorkReportEntry entry) => _entries.Remove(entry);

        public IReadOnlyList<WorkReportEntry> GetEntries()
        {
            return _entries.AsReadOnly();
        }
    }
}
