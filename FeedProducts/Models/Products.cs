using System.Collections.Generic;

namespace FeedProducts.Models
{
    public class Products
    {
        public List<Product> products { get; set; }
    }

    public class Product
    {
        public string title { get; set; }

        public string twitter { get; set; }

        public List<string> categories { get; set; }
    }
}
