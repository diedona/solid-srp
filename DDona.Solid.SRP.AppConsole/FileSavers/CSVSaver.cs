using DDona.Solid.SRP.AppConsole.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DDona.Solid.SRP.AppConsole.FileSavers
{
    public class CSVSaver<T> : BaseSaver<T>
    {
        public CSVSaver(IManager<T> reportManager) : base(reportManager, ".csv")
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
                    sb.AppendLine($"{property.GetValue(item, null)},");
                }

                if (item.GetHashCode() != list.LastOrDefault().GetHashCode())
                {
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }
    }
}
