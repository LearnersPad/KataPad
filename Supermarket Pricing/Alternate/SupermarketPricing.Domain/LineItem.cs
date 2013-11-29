namespace SupermarketPricing.Domain
{

    /// <summary>
    /// Represents the concept of a line item or a single item in the cart
    /// </summary>
    public class LineItem
    {
        private readonly Product            _product;
        private readonly Quantity           _quantity;

        /// <summary>
        /// CTor
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        public LineItem(Product product, Quantity quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        /// <summary>
        /// Gets the Product
        /// </summary>
        public virtual Product Product
        {
            get { return _product; }
        }

        /// <summary>
        /// The facility to add quantity to an existing quantity
        /// </summary>
        /// <param name="qunatity"></param>
        public virtual void AddQuantity(Quantity qunatity)
        {
            _quantity.Replenish(qunatity);
        }

        /// <summary>
        /// The facility to remove quantity to an existing qunatity
        /// </summary>
        /// <param name="quantity"></param>
        public virtual void RemoveQuantity(Quantity quantity)
        {
            _quantity.Deplete(quantity);
        }

        /// <summary>
        /// Calcualtes the price for the Line Item
        /// </summary>
        /// <returns></returns>
        public virtual double CalculatePrice()
        {
            return _product.PriceCalculator.CalculatePrice(_quantity);
        }
    }
}