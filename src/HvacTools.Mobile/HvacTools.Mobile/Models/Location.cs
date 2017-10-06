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

        [Column("fk_state_id"), ForeignKey("locations_fk01")]
        public int StateId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("unit")]
        public string Unit { get; set; }

        [Column("zip_code")]
        public string ZipCode { get; set; }
    }
}
