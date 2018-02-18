using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

#region Internal Libraries
using Tools.Models;
#endregion

namespace HvacTools.Mobile.Models
{
    [Table("refrigerant_types")]
    public class RefrigerantType
    {
        #region Member Variables
        [Column("pk_refrigerant_type_id")]
        public int RefrigerantTypeId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("refrigerant_type_code")]
        public string Code { get; set; }
        #endregion
    }
}
