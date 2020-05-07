using System;
namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
        }
        public Product(int productId)
        {
         ProductId = productId;
        }
        public decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }
        
    }
}

