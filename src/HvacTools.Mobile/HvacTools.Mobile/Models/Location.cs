using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Tools.Models;

namespace HvacTools.Mobile.Models
{
    [Table("locations")]
    public class Location : ILocation
    {
        [Column("pk_location_id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
