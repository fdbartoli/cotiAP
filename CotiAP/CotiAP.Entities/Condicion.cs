namespace CotiAP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Condicion")]
    public partial class Condicion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCondicion { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        public double tasa { get; set; }
    }
}
