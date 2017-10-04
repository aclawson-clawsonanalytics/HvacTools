using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Models
{
    public interface IContextModels
    {
        
        ICollection<ILocation> Locations { get; set; }
        ICollection<IServiceLocation> ServiceLocations { get; set; }
        
    }
}
