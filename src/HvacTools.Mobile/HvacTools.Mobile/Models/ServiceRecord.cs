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

        public int LocationId { get; set; }
         
        public string CustomerName { get; set; }

        public string Description { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Location Location { get; set; }
        #endregion


    }
}
