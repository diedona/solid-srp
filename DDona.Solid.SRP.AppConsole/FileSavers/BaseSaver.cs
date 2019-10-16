using DDona.Solid.SRP.AppConsole.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DDona.Solid.SRP.AppConsole.FileSavers
{
    public abstract class BaseSaver<T>
    {
        protected readonly IManager<T> _reportManager;
        protected readonly string _fileFormat;

        public BaseSaver(IManager<T> reportManager, string fileFormat)
        {
            _reportManager = reportManager;
            _fileFormat = fileFormat;
        }

        public void SaveToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, string.Concat(fileName, _fileFormat)), this.EntriesToString());
        }

        protected abstract string EntriesToString();
    }
}
