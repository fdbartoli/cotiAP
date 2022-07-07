namespace CotiAP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Descuento")]
    public partial class Descuento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idDescuento { get; set; }

        [Required]
        [StringLength(50)]
        public string nombreDescuento { get; set; }

        public double porcentaje { get; set; }
    }
}
