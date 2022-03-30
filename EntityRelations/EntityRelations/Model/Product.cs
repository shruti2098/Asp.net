using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityRelations.Model
{
    public class Product
    {
        [Key]
        public int ProdId { get; set; }
        public string ProductName { get; set; }
        public virtual ICollection<ModelInfo> ModelInfos { get; set; }
        public int ModelId { get; set; }
        public int Price { get; set; }
    }
}
