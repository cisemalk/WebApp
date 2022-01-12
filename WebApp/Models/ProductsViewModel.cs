using System.Collections.Generic;

namespace WebApp.Models
{
    public class ProductsViewModel
    {
        public ProductsViewModel()
        {
            Products = new List<TblEmployee>();
        }
        public List<TblEmployee> Products { get; set; }
    }
}