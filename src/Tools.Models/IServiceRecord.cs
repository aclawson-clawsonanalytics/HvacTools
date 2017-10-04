using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Models
{
    public interface IServiceRecord
    {
        int Id { get; set; }
        int LocationId { get; set; }

        ILocation Location { get; set; }
    }
}
