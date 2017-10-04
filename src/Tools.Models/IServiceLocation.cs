using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Models
{
    public interface IServiceLocation
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string Unit { get; set; }
        string City { get; set; }
        int StateId { get; set; }
        string ZipCode { get; set; }     
    }
}
