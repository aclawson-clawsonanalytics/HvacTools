using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Tools.Models;

namespace HvacTools.Mobile.Models
{
    [Table("service_records")]
    public class ServiceRecord : IServiceRecord
    {
        #region Member Variables
        [Column("pk_service_record_id")]
        public int Id { get; set; }

        [Column("fk_location_id"), ForeignKey("service_records_fk01")]
        public int LocationId { get; set; }
         
        [Column("customer_name")]
        public string CustomerName { get; set; }

        [Column("description")]
        public string Description { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Location Location { get; set; }
        #endregion


    }
}
