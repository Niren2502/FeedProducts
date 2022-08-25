using System.Collections.Generic;

namespace FeedProducts.Models
{
    /// <summary>
    ///  Products class
    /// </summary>
    public class ProductsList
    {
        /// <summary>
        /// products list
        /// </summary>
        public List<Product> Products { get; set; }
    }

    /// <summary>
    /// Product class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Twitter
        /// </summary>
        public string Twitter { get; set; }

        /// <summary>
        /// Categories
        /// </summary>
        public List<string> Categories { get; set; }
    }
}
