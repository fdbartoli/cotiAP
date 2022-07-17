using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CotiAP.WebAPI.Models
{
    public class CondicionRequest
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