using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BL.Entity
{
    [Table("Currency")]
    public class Currency
    {
        public long     ProductId { get; set; }
        public string   Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(8, 2)")]
        public decimal  Price { get; set; }
        public long     CategoryId { get; set; }
        public Category? Category { get; set; }
        public long SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

    }
}
