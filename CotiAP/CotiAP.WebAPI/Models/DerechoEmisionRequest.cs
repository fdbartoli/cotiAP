using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CotiAP.WebAPI.Models
{
    public class DerechoEmisionRequest
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