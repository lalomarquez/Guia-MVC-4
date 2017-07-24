using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuiaMVC4.Models
{
    public class Product
    {
        public Product() { Id = Guid.NewGuid(); }
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}