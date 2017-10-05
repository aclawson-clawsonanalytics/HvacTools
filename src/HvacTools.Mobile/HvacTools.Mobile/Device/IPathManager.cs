using System;
using System.Collections.Generic;
using System.Text;

namespace HvacTools.Mobile.Device
{
    public interface IPathManager
    {
        string ApplicationDirectory { get; set; }
        string ReferenceDirectory { get; set; }
        string DatabaseDirectory { get; set; }
        string ApplicationDatabaseFilename { get; }
        string ReferenceDatabaseFilename { get; }
        string ApplicationDatabasePath { get; }
        string ReferenceDatabasePath { get; }
    }
}
