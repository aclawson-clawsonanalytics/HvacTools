using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Models
{
    public class ServiceRecord : IServiceRecord
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public string Description { get; set; }

        public virtual ILocation Location { get; set; }
    }
}
