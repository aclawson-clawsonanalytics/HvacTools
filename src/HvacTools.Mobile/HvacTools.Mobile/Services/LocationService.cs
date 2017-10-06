using System;
using System.Collections.Generic;
using System.Text;
using HvacTools.Mobile.Database;
using HvacTools.Mobile.Models;

namespace HvacTools.Mobile.Services
{
    public class LocationService
    {
        #region Member Variables
        private MobileContext _mobileContext { get; set; }
        #endregion

        public LocationService(MobileContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("Invalide application context.");
            }
            _mobileContext = context;
        }

        public IEnumerable<Location> GetLocations()
        {
            return _mobileContext.Locations;
        }

        public Location GetById(int locationId)
        {
            return _mobileContext.Locations.Find(locationId);
        }        
    }
}
