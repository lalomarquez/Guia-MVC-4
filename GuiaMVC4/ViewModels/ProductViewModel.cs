using GuiaMVC4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GuiaMVC4.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "required")]
        public string ProductName { get; set; }

        public int SelectedValue { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        [DisplayName("Product Category")]
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}