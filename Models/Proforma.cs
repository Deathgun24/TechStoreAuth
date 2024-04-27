using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TechStoreAuth.Models
{
    [Table("t_proforma")]
    public class Proforma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? UserID { get; set; }
        public Producto? Producto { get; set; }
        public int Cantidad { get; set; }
        [NotNull]
        public Decimal Precio { get; set; }
        public string Status { get; set; } = "PENDIENTE";
    }
}