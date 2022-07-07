namespace CotiAP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DerechoEmision")]
    public partial class DerechoEmision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idDerechoEmision { get; set; }

        [Required]
        [StringLength(50)]
        public string nombreDerechoEmision { get; set; }

        public double valor { get; set; }
    }
}
