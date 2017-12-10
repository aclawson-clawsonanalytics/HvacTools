using System;
using System.Collections.Generic;
using System.Text;

namespace HvacTools.Mobile.Web
{
    public static class Uri
    {
        private static string ReferenceServiceDomain
        {
            get
            {
                return "localhost:1234";                
            }
        }

        public static string ReferenceService
        {
            get
            {
                return ReferenceServiceDomain + "/HvacReference";
            }
        }

        public static string CurrentDatabase
        {
            get
            {
                return ReferenceService + "/current";
            }
        }

        public static string ReferenceVersion(int version)
        {
            return ReferenceService + "/" + version.ToString();
        }
    }
}
