using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuiaMVC4.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
