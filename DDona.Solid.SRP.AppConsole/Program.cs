using DDona.Solid.SRP.AppConsole.FileSavers;
using DDona.Solid.SRP.AppConsole.Managers;
using DDona.Solid.SRP.AppConsole.Model;
using System;
using System.Collections.Generic;

namespace DDona.Solid.SRP.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new WorkReport();
            report.Add(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.Add(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });
            report.Add(new WorkReportEntry { ProjectCode = "aaa33", ProjectName = "Three", SpentHours = 18 });

            var savers = new List<BaseSaver>() { new TxtSaver(report), new CSVSaver(report) };
            foreach (var saver in savers)
            {
                saver.SaveToFile("Reports", "WorkReport");
            }
        }
    }
}
