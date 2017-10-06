using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Tools.Models;

namespace HvacTools.Mobile.Models
{
    [Table("states")]
    public class State : IState
    {
        #region Member Variables
        [Column("pk_state_id"), Key]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        #endregion
    }
}
