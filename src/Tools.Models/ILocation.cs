using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Models
{
    public interface ILocation
    {
        int Id { get; set; }
        int StateId { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string Unit { get; set; }
        string ZipCode { get; set; }

    }
}
