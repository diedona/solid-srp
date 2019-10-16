using DDona.Solid.SRP.AppConsole.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DDona.Solid.SRP.AppConsole.FileSavers
{
    public class TxtSaver : BaseSaver
    {
        public TxtSaver(IManager reportManager) : base(reportManager, ".txt")
        {
        }

        protected override string EntriesToString()
        {
            var list = _reportManager.GetEntries();
            return string.Join(Environment.NewLine, list.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
        }
    }
}
