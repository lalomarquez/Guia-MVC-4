using GuiaMVC4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuiaMVC4.Repositories
{
    public class ProductRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public ProductCategory GetProductCategory(int categoryId)
        {
            var productCategoryList = GetAllProductCategoriesMockDatas();

            return (from p in productCategoryList
                    where (p.Id == categoryId)
                    select p).FirstOrDefault();
        }

        public List<ProductCategory> GetAllProductCategories()
        {
            var productCategoryList = GetAllProductCategoriesMockDatas();

            return (from p in productCategoryList
                    select p)
                    .OrderBy(p => p.CategoryName)
                    .ToList();
        }

        private List<ProductCategory> GetAllProductCategoriesMockDatas()
        {
            var productCategoryList = new List<ProductCategory>();

            productCategoryList.Add(new ProductCategory
            {
                Id = 1,
                CategoryName = "Foods",
            });

            productCategoryList.Add(new ProductCategory
            {
                Id = 2,
                CategoryName = "Toys",
            });

            productCategoryList.Add(new ProductCategory
            {
                Id = 3,
                CategoryName = "Mobile Phones",
            });

            return productCategoryList;
        }
    }
}