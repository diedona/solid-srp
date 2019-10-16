using DDona.Solid.SRP.AppConsole.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DDona.Solid.SRP.AppConsole.FileSavers
{
    public class TxtSaver<T> : BaseSaver<T>
    {
        public TxtSaver(IManager<T> reportManager) : base(reportManager, ".txt")
        {
        }

        protected override string EntriesToString()
        {
            var list = _reportManager.GetEntries();
            var properties = list.FirstOrDefault().GetType().GetProperties();
            StringBuilder sb = new StringBuilder();

            foreach (T item in list)
            {
                foreach (var property in properties)
                {
                    sb.AppendLine($"{property.Name}: {property.GetValue(item, null)},");
                }

                if (item.GetHashCode() != list.LastOrDefault().GetHashCode())
                {
                    sb.AppendLine();
                }
            }

            return sb.ToString();

            //var list = _reportManager.GetEntries();
            //return string.Join(Environment.NewLine, list.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
        }
    }
}
