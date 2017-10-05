using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using HvacTools.Mobile.Device;

namespace HvacTools.Mobile.Droid.Device
{
    public class PathManager : IPathManager
    {
        public string ApplicationDirectory { get; set; }
        public string ReferenceDirectory { get; set; }
        public string DatabaseDirectory { get; set; }

        public string ApplicationDatabaseFilename
        {
            get
            {
                return "hvac_tools.db";
            }
        }

        public string ReferenceDatabaseFilename
        {
            get
            {
                return "hvac_reference.db";
            }
        }

        public string ApplicationDatabasePath
        {
            get
            {
                return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), ApplicationDatabaseFilename);
            }
        }

        public string ReferenceDatabasePath
        {
            get
            {
                return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), ReferenceDatabaseFilename);
            }
        }
    }
}