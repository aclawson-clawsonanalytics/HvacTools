using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Models
{
    public class Location : ILocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }

        public int LocationId { get; set; }
        public int ZipCode { get; set; }
    }
}
