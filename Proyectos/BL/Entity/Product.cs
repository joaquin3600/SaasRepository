using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BL.Entity
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int          IdProduct   { get; set; }
        public string       Name        { get; set; } = string.Empty;
        public string       Description { get; set; } = string.Empty;
        public DateTime     Created_At  { get; set; } = DateTime.Now;
        public DateTime?    Deleted_At  { get; set; }
        public int          Active      { get; set; } = ValoresDefault.Active;
    }
}
