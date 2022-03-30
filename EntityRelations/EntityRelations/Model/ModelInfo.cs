using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityRelations.Model
{
    public class ModelInfo
    {
        [Key]
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
