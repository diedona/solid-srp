using DDona.Solid.SRP.AppConsole.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DDona.Solid.SRP.AppConsole.FileSavers
{
    public class CSVSaver: BaseSaver
    {
        public CSVSaver(IManager reportManager) : base(reportManager, ".csv")
        {
        }

        protected override string EntriesToString()
        {
            var list = _reportManager.GetEntries();
            return string.Join(Environment.NewLine, list.Select(x => $"{x.ProjectCode},{x.ProjectName},{x.SpentHours}"));
        }
    }
}
