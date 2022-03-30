using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityRelations.Model
{
    public class ProductDescription
    {
        [Key]
        public int ProductDesId { get; set; }
        public int ProductId { get; set; }
        public int ProductDetails { get; set; }
    }
}
