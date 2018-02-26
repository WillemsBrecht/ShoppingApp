using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models {
    public class Cart {
        public List<Product> List { get; set; } = new List<Product>();
        public void addToCart(Product productToAdd) {
            List.Add(productToAdd);
        }
    }
}
