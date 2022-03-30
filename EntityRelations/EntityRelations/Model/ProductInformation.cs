using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityRelations.Model
{
    public class ProductInformation
    {
        [Key]
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public decimal Price { get; set; }
        public string ModelName { get; set; } 
        public string ProdDetails { get; set; }
        public virtual ICollection<ProductInformation> ProductInformations { get; set; }
    }
}
