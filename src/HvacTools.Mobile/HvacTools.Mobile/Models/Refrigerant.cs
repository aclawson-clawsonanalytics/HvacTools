using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tools.Models;

namespace HvacTools.Mobile.Models
{
    [Table("refrigerants")]
    public class Refrigerant : IRefrigerant
    {
        [Column("pk_refrigerantId"), Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
