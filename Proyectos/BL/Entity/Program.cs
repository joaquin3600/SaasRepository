using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BL.Entity
{
    [Table("Program")]
    public class Program
    {
        [Key]
        public int          IdProgram        { get; set; }
        public int          IdProduct        { get; set; }
        [NotMapped]
        public Product?     Product          { get; set; }
        public int          Months           { get; set; }
        public DateTime     Created_At       { get; set; } = DateTime.Now;
        public DateTime?    Deleted_At       { get; set; }
        public int          Active           { get; set; } = ValoresDefault.Active;
            
    }
}
