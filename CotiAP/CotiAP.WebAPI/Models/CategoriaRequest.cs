using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CotiAP.WebAPI.Models
{
    public class CategoriaRequest
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
    