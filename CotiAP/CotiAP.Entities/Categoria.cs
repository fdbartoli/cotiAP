namespace CotiAP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Categoria")]
    public partial class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCategoria { get; set; }

        [Required]
        [StringLength(50)]
        public string numeroCategoria { get; set; }

        public double tasa { get; set; }

        public double tasaAsitencia { get; set; }
    }
}
