using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BL.Entity
{
    [Table("Product_pricing")]
    public class Product_pricing
    {
        [Key]
        public int          IdProduct_pricing   { get; set; }
        public int          IdProduct           { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal      Price               { get; set; }
        public DateTime     From_Date           { get; set; } 
        public DateTime     To_Date             { get; set; }
        public DateTime?    Created_At          { get; set; } = DateTime.Now;
        public DateTime     Deleted_At          { get; set; }
        public int          IdCurrency          { get; set; }
        [NotMapped]
        public Currency?    Currency            { get; set; }
        public int          Active              { get; set; } = ValoresDefault.Active;
    }
}
