namespace SupermarketPricing.Domain
{
    /// <summary>
    /// The Representation of a Brand of a Product
    /// </summary>
    public class Brand
    {
        private readonly string _brandName;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name"></param>
        public Brand(string name)
        {
            _brandName = name;
        }

        /// <summary>
        /// Gets the Brand Name
        /// </summary>
        public string BrandName
        {
            get { return _brandName; }
        }
    }
}