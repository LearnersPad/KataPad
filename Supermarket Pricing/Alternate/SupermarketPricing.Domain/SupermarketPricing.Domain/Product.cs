namespace SupermarketPricing.Domain
{
    /// <summary>
    /// Represents the Abstract Concept of a Product that has to be sold by the SuperMarket
    /// </summary>
    public class Product
    {
        private readonly string                     _name;
        private readonly ProductPriceQuantifierUnit _productPriceQuantifierUnit;
        private readonly Category                   _category;
        private readonly Brand                      _brand;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="priceDesc"></param>
        /// <param name="prodCategory"></param>
        /// <param name="brand"></param>
        public Product(string name,
                ProductPriceQuantifierUnit priceDesc,
                Category prodCategory,
                Brand brand)
        {

            _name = name;
            _productPriceQuantifierUnit = priceDesc;
            _category = prodCategory;
            _brand = brand;
        }

        /// <summary>
        /// Name of the Product
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// The reference to the ProductPriceQuantifierUnit
        /// </summary>
        public ProductPriceQuantifierUnit PriceCalculator
        {
            get
            {
                return _productPriceQuantifierUnit;
            }
        }

        /// <summary>
        /// Product Category
        /// </summary>
        public Category ProductCategory
        {
            get
            {
                return _category;
            }
        }

        /// <summary>
        /// Brand of the Product
        /// </summary>
        public Brand Brand
        {
            get
            {
                return _brand;
            }
        }

    }
}